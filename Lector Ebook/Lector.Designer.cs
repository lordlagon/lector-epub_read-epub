using TheArtOfDev.HtmlRenderer.WinForms;

namespace Lector_Ebook
{
    partial class Lector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_controles = new System.Windows.Forms.Panel();
            this.cbo_pagina = new System.Windows.Forms.ComboBox();
            this.pn_lector = new System.Windows.Forms.Panel();
            this.htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_controles.SuspendLayout();
            this.pn_lector.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_controles
            // 
            this.pn_controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pn_controles.Controls.Add(this.label3);
            this.pn_controles.Controls.Add(this.cbo_pagina);
            this.pn_controles.Controls.Add(this.label2);
            this.pn_controles.Controls.Add(this.label1);
            this.pn_controles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_controles.Location = new System.Drawing.Point(0, 530);
            this.pn_controles.Name = "pn_controles";
            this.pn_controles.Size = new System.Drawing.Size(1034, 61);
            this.pn_controles.TabIndex = 1;
            // 
            // cbo_pagina
            // 
            this.cbo_pagina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_pagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_pagina.FormattingEnabled = true;
            this.cbo_pagina.Location = new System.Drawing.Point(132, 17);
            this.cbo_pagina.Name = "cbo_pagina";
            this.cbo_pagina.Size = new System.Drawing.Size(224, 21);
            this.cbo_pagina.TabIndex = 2;
            // 
            // pn_lector
            // 
            this.pn_lector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_lector.Controls.Add(this.htmlPanel);
            this.pn_lector.Location = new System.Drawing.Point(0, 0);
            this.pn_lector.Name = "pn_lector";
            this.pn_lector.Size = new System.Drawing.Size(1034, 533);
            this.pn_lector.TabIndex = 2;
            // 
            // htmlPanel
            // 
            this.htmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlPanel.AutoScroll = true;
            this.htmlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel.BaseStylesheet = "h1{\r\nfont-family:  Sansation,Arial, Calibri;\r\nfont-size:30px;\r\n}\r\nbody{\r\nfont-fam" +
    "ily:  Sansation,Arial, Calibri;\r\nfont-size:30px;\r\n}";
            this.htmlPanel.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(1034, 530);
            this.htmlPanel.TabIndex = 0;
            this.htmlPanel.Text = null;
            this.htmlPanel.StylesheetLoad += new System.EventHandler<TheArtOfDev.HtmlRenderer.Core.Entities.HtmlStylesheetLoadEventArgs>(this.htmlPanel_StylesheetLoad);
            this.htmlPanel.ImageLoad += new System.EventHandler<TheArtOfDev.HtmlRenderer.Core.Entities.HtmlImageLoadEventArgs>(this.htmlPanel_ImageLoad);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label3.Image = global::Lector_Ebook.Properties.Resources.search;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capitulos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label2.Image = global::Lector_Ebook.Properties.Resources.previous;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(383, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capitulo Anterior";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label1.Image = global::Lector_Ebook.Properties.Resources.skip;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(597, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capitulos Siguiente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.pn_controles);
            this.Controls.Add(this.pn_lector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Lector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector";
            this.pn_controles.ResumeLayout(false);
            this.pn_lector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_controles;
        private System.Windows.Forms.Panel pn_lector;
        private HtmlPanel htmlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_pagina;
        private System.Windows.Forms.Label label3;
    }
}