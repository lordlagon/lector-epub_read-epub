using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VersFx.Formats.Text.Epub;

namespace Lector_Ebook
{
    public partial class Inicio : Form
    {

        //Declarar variables
        ImageList imgL;
        String direccion_raiz;
        ArrayList ebook = new ArrayList();
        EpubBook epub_general;
        Image image_default;

        public Inicio()
        {
            InitializeComponent();

            //Incializar variables
            direccion_raiz = "";
            image_default = Properties.Resources.cover_default;

            //Configurar progressBar
            progressBar.Visible = false;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            mostrar();
        }

        void mostrar()
        {
            //Inicializar ComboBox
            cbo_clasificar.SelectedIndex = 0;

            //Inicializar lista
            lsv_biblioteca.Clear();
            lsv_biblioteca.View = View.Details;

            ebook.Clear();

            lsv_biblioteca.Columns.Add("Libros", lsv_biblioteca.Width - 23);



            imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new Size(80, 100);

            //Cargar epubs
            String[] paths = { };

            try
            {
                paths = Directory.GetFiles(direccion_raiz, "*.epub");

                double porcentaje = 100 / paths.Length;
                progressBar.Visible = true;

                foreach (String path in paths)
                {

                    try
                    {
                        epub_general = EpubReader.ReadBook(path);

                        if (epub_general.CoverImage != null)
                        {
                            imgL.Images.Add(epub_general.CoverImage);
                        }
                        else
                        {
                            epub_general.CoverImage = image_default;
                            imgL.Images.Add(image_default);
                        }

                        ebook.Add(epub_general);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Esto no es un Epub");
                    }
                }


                progressBar.Value = 100;
                progressBar.Visible = false;

            }
            catch (Exception e)
            {

            }

            lsv_biblioteca.SmallImageList = imgL;

            //Ingresar titulo y autor
            int contador = 0;
            foreach (EpubBook epub in ebook)
            {
                try
                {
                    lsv_biblioteca.Items.Add("Titulo: " + epub.Title + "\nAutor: " + epub.Author, contador);

                }
                catch (Exception e)
                {

                }
                contador++;

            }
        }

        private void lsv_biblioteca_MouseClick(object sender, MouseEventArgs e)
        {
            epub_general = (EpubBook)ebook[lsv_biblioteca.SelectedIndices[0]];
            ptb_cover.Image = epub_general.CoverImage;
        }



        private void Inicio_SizeChanged(object sender, EventArgs e)
        {
            lsv_biblioteca.Clear();
            mostrar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag_carpeta = new FolderBrowserDialog();

            if (diag_carpeta.ShowDialog() == DialogResult.OK)
            {
                direccion_raiz = diag_carpeta.SelectedPath;
            }

            mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lector form_lector = new Lector(epub_general);
            form_lector.ShowDialog();
        }


    }
}
