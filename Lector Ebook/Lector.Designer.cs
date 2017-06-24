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
            this.pn_lector = new System.Windows.Forms.Panel();
            this.htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            this.pn_lector.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_controles
            // 
            this.pn_controles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_controles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_controles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_controles.Location = new System.Drawing.Point(0, 535);
            this.pn_controles.Name = "pn_controles";
            this.pn_controles.Size = new System.Drawing.Size(1034, 56);
            this.pn_controles.TabIndex = 1;
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
            this.htmlPanel.AutoScroll = true;
            this.htmlPanel.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel.BaseStylesheet = "h1{\r\nfont-family:  Sansation,Arial, Calibri;\r\nfont-size:30px;\r\n}\r\nbody{\r\nfont-fam" +
    "ily:  Sansation,Arial, Calibri;\r\nfont-size:30px;\r\n}";
            this.htmlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlPanel.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(1034, 533);
            this.htmlPanel.TabIndex = 0;
            this.htmlPanel.Text = null;
            this.htmlPanel.StylesheetLoad += new System.EventHandler<TheArtOfDev.HtmlRenderer.Core.Entities.HtmlStylesheetLoadEventArgs>(this.htmlPanel_StylesheetLoad);
            this.htmlPanel.ImageLoad += new System.EventHandler<TheArtOfDev.HtmlRenderer.Core.Entities.HtmlImageLoadEventArgs>(this.htmlPanel_ImageLoad);
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
            this.pn_lector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_controles;
        private System.Windows.Forms.Panel pn_lector;
        private HtmlPanel htmlPanel;
    }
}