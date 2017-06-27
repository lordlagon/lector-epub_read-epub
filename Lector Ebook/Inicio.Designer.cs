namespace Lector_Ebook
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.tblFlow = new System.Windows.Forms.TableLayoutPanel();
            this.pn_cover = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ptb_cover = new System.Windows.Forms.PictureBox();
            this.grb_controles = new System.Windows.Forms.GroupBox();
            this.lsv_biblioteca = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.cbo_clasificar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.tblFlow.SuspendLayout();
            this.pn_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cover)).BeginInit();
            this.grb_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFlow
            // 
            this.tblFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tblFlow.ColumnCount = 3;
            this.tblFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFlow.Controls.Add(this.pn_cover, 1, 0);
            this.tblFlow.Controls.Add(this.grb_controles, 0, 0);
            this.tblFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFlow.Location = new System.Drawing.Point(0, 0);
            this.tblFlow.Name = "tblFlow";
            this.tblFlow.Padding = new System.Windows.Forms.Padding(10);
            this.tblFlow.RowCount = 3;
            this.tblFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblFlow.Size = new System.Drawing.Size(897, 571);
            this.tblFlow.TabIndex = 0;
            // 
            // pn_cover
            // 
            this.pn_cover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tblFlow.SetColumnSpan(this.pn_cover, 2);
            this.pn_cover.Controls.Add(this.button3);
            this.pn_cover.Controls.Add(this.ptb_cover);
            this.pn_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cover.Location = new System.Drawing.Point(370, 15);
            this.pn_cover.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pn_cover.Name = "pn_cover";
            this.pn_cover.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tblFlow.SetRowSpan(this.pn_cover, 3);
            this.pn_cover.Size = new System.Drawing.Size(507, 541);
            this.pn_cover.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sansation", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(194, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Leer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ptb_cover
            // 
            this.ptb_cover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_cover.BackColor = System.Drawing.Color.Transparent;
            this.ptb_cover.Location = new System.Drawing.Point(0, 10);
            this.ptb_cover.Name = "ptb_cover";
            this.ptb_cover.Size = new System.Drawing.Size(507, 427);
            this.ptb_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_cover.TabIndex = 0;
            this.ptb_cover.TabStop = false;
            // 
            // grb_controles
            // 
            this.grb_controles.Controls.Add(this.progressBar);
            this.grb_controles.Controls.Add(this.lsv_biblioteca);
            this.grb_controles.Controls.Add(this.button2);
            this.grb_controles.Controls.Add(this.cbo_clasificar);
            this.grb_controles.Controls.Add(this.label1);
            this.grb_controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_controles.Location = new System.Drawing.Point(13, 13);
            this.grb_controles.Name = "grb_controles";
            this.tblFlow.SetRowSpan(this.grb_controles, 3);
            this.grb_controles.Size = new System.Drawing.Size(344, 545);
            this.grb_controles.TabIndex = 2;
            this.grb_controles.TabStop = false;
            // 
            // lsv_biblioteca
            // 
            this.lsv_biblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_biblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lsv_biblioteca.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lsv_biblioteca.Location = new System.Drawing.Point(9, 119);
            this.lsv_biblioteca.Name = "lsv_biblioteca";
            this.lsv_biblioteca.Size = new System.Drawing.Size(329, 420);
            this.lsv_biblioteca.TabIndex = 3;
            this.lsv_biblioteca.UseCompatibleStateImageBehavior = false;
            this.lsv_biblioteca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsv_biblioteca_MouseClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sansation", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Lector_Ebook.Properties.Resources.ebook;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Seleccionar Carpeta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbo_clasificar
            // 
            this.cbo_clasificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_clasificar.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_clasificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_clasificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_clasificar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_clasificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.cbo_clasificar.FormattingEnabled = true;
            this.cbo_clasificar.Items.AddRange(new object[] {
            "Sin Clasificar",
            "Por Fecha",
            "Por Autor",
            "Por Genero "});
            this.cbo_clasificar.Location = new System.Drawing.Point(113, 65);
            this.cbo_clasificar.Name = "cbo_clasificar";
            this.cbo_clasificar.Size = new System.Drawing.Size(210, 25);
            this.cbo_clasificar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clasificar Ebook";
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("progressBar.AnimationFunction")));
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.progressBar.Font = new System.Drawing.Font("Sansation", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar.InnerMargin = 0;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(113, 255);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.Gray;
            this.progressBar.OuterMargin = -10;
            this.progressBar.OuterWidth = 10;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar.ProgressWidth = 10;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(120, 112);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 4;
            this.progressBar.Text = "Cargando Ebooks";
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.progressBar.Value = 68;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 571);
            this.Controls.Add(this.tblFlow);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(792, 610);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector Ebook";
            this.SizeChanged += new System.EventHandler(this.Inicio_SizeChanged);
            this.tblFlow.ResumeLayout(false);
            this.pn_cover.ResumeLayout(false);
            this.pn_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cover)).EndInit();
            this.grb_controles.ResumeLayout(false);
            this.grb_controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblFlow;
        private System.Windows.Forms.Panel pn_cover;
        private System.Windows.Forms.PictureBox ptb_cover;
        private System.Windows.Forms.GroupBox grb_controles;
        private System.Windows.Forms.ComboBox cbo_clasificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lsv_biblioteca;
        private CircularProgressBar.CircularProgressBar progressBar;
    }
}

