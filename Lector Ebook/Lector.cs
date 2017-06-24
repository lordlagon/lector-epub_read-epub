using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using VersFx.Formats.Text.Epub;

namespace Lector_Ebook
{
    public partial class Lector : Form
    {
        public Lector(EpubBook epub)
        {
            InitializeComponent();

            this.epub = epub;

            mostrar();
        }

        EpubBook epub;
        EpubChapter capitulo_actual;
        int[] paginacion = new int[2];

        void mostrar()
        {
            paginacion[0] = 0;
            paginacion[1] = 0;

            String pagina;
            pagina = obtenerContenidoCap(epub.Chapters[paginacion[0]],paginacion[1]);
            
            htmlPanel.Text = pagina;

            //Configurar comboBox con capitulos
            for(int i=0; i< epub.Chapters.Count; i++)
            {
                cbo_pagina.Items.Add(epub.Chapters[i].Title);

                if (epub.Chapters[i].SubChapters.Count != 0)
                {
                    foreach(EpubChapter sub_cap in epub.Chapters[i].SubChapters )
                    {
                        cbo_pagina.Items.Add("  "+sub_cap.Title);
                    }
                }
            }
            
        }
        
        String obtenerContenidoCap(EpubChapter chapter,int sub_pagina)
        {

            if (paginacion[1] == 0)
            {
                capitulo_actual = chapter;
                return chapter.HtmlContent;
            }
            else
            {
                capitulo_actual = chapter.SubChapters[sub_pagina-1];
                return chapter.HtmlContent;
            }
            

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

      
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
