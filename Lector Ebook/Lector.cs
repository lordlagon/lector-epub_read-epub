using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Packaging;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using TheArtOfDev.HtmlRenderer.WinForms;
using VersFx.Formats.Text.Epub;

namespace Lector_Ebook
{
    public partial class Lector : Form
    {

        private bool areFontsRegistered;

        public Lector(EpubBook epub)
        {
            InitializeComponent();

            this.epub = epub;
            areFontsRegistered = false;

            mostrar();
        }

        EpubBook epub;
        EpubChapter capitulo_actual;

        void mostrar()
        {
            String pagina;
            pagina = obtenerContenidoCap(epub.Chapters[2]);

            if (!areFontsRegistered)
           //     RegisterFonts();

            htmlPanel.Text = pagina;
        }
        
        String obtenerContenidoCap(EpubChapter chapter)
        {

            capitulo_actual = chapter;
            return chapter.HtmlContent;

        }

        

        

        private void htmlPanel_ImageLoad(object sender, HtmlImageLoadEventArgs e)
        {
            /**
             * Codigo al iniciar el evento de cargar de imagen une la direccion relativa de 
             * la carga de imagen y la direccion fisica del capitulo, luego lo busca 
             * en el diccionario de imagenes y luego de obtener la imagen carga la imagen.
             * Y la regreso al evento de carga de imagenes.
             */ 

            string imageFilePath = GetFullPath(capitulo_actual.ContentFileName, e.Src);

            EpubByteContentFile imageContent;
            if (epub.Content.Images.TryGetValue(imageFilePath, out imageContent))
            {
                using (MemoryStream imageStream = new MemoryStream(imageContent.Content))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = imageStream;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze();
                    e.Callback(BitmapImage2Bitmap(bitmapImage));
                }
                e.Handled = true;
            }
        }

        //OBTENER LA DIRECCION DE LA IMAGEN EN EL CONTENIDO DEL EPUB
        private string GetFullPath(string htmlFilePath, string relativePath)
        {
            if (relativePath.StartsWith("/"))
                return relativePath.Length > 1 ? relativePath.Substring(1) : String.Empty;
            string basePath = Path.GetDirectoryName(htmlFilePath);
            while (relativePath.StartsWith("../"))
            {
                relativePath = relativePath.Length > 3 ? relativePath.Substring(3) : String.Empty;
                basePath = Path.GetDirectoryName(basePath);
            }
            string fullPath = String.Concat(basePath.Replace('\\', '/'), '/', relativePath);
            return fullPath.Length > 1 ? fullPath.Substring(1) : String.Empty;
        }

        //FUNCION SACADA DE INTERNET PARA CONVERTIR BITMAPiMAGE EN BITMAP
        private Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }

        private void htmlPanel_StylesheetLoad(object sender, HtmlStylesheetLoadEventArgs e)
        {
            string styleSheetFilePath = GetFullPath(capitulo_actual.ContentFileName, e.Src);
            EpubTextContentFile styleSheetContent;
            if (epub.Content.Css.TryGetValue(styleSheetFilePath, out styleSheetContent))
                e.SetStyleSheet = styleSheetContent.Content;
        }

        private void RegisterFonts()
        {
            foreach (KeyValuePair<string, EpubByteContentFile> fontFile in epub.Content.Fonts)
            {

                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = fontFile.Value.Content;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontData.Length);
                //AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Font myFont = new Font(fonts.Families[0], 16.0F);

                HtmlRender.AddFontFamily(myFont.FontFamily);

                /**
                MemoryStream packageStream = new MemoryStream();
                Package package = Package.Open(packageStream, FileMode.Create, FileAccess.ReadWrite);
                Uri packageUri = new Uri(fontFile.Key + ":");
                PackageStore.AddPackage(packageUri, package);
                Uri packPartUri = new Uri("/content", UriKind.Relative);
                PackagePart packPart = package.CreatePart(packPartUri, "font/content");
                packPart.GetStream().Write(fontFile.Value.Content, 0, fontFile.Value.Content.Length);
                Uri fontUri = PackUriHelper.Create(packageUri, packPart.Uri);
                Fon**/


            }
            areFontsRegistered = true;
        }
    }
}
