﻿using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            direccion_raiz = "C:/Users/migue/Documents/Epub/Nuevos epub";
            image_default = Lector_Ebook.Properties.Resources.Bajo_la_misma_estrella_alta;

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

            //Cargar imagenes 
            String[] paths = { };
            paths = Directory.GetFiles(direccion_raiz);

            try
            {
                foreach (String path in paths)
                {
                    try
                    {
                        epub_general = EpubReader.ReadBook(path);
                        imgL.Images.Add(epub_general.CoverImage);
                        ebook.Add(epub_general);
                    }
                    catch (Exception e)
                    {
                        epub_general = EpubReader.ReadBook(path);
                        imgL.Images.Add(image_default);
                        epub_general.CoverImage = image_default;
                        ebook.Add(epub_general);
                    }
                }
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

                }catch(Exception e)
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