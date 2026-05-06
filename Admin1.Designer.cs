namespace OdbojkaskiSavez
{
    partial class Admin1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUtakmicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonnazad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.dodajTimToolStripMenuItem,
            this.izmeniUtakmicuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // dodajTimToolStripMenuItem
            // 
            this.dodajTimToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dodajTimToolStripMenuItem.Name = "dodajTimToolStripMenuItem";
            this.dodajTimToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.dodajTimToolStripMenuItem.Text = "Dodaj tim";
            this.dodajTimToolStripMenuItem.Click += new System.EventHandler(this.dodajTimToolStripMenuItem_Click);
            // 
            // izmeniUtakmicuToolStripMenuItem
            // 
            this.izmeniUtakmicuToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.izmeniUtakmicuToolStripMenuItem.Name = "izmeniUtakmicuToolStripMenuItem";
            this.izmeniUtakmicuToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.izmeniUtakmicuToolStripMenuItem.Text = "Obrisi utakmicu";
            this.izmeniUtakmicuToolStripMenuItem.Click += new System.EventHandler(this.izmeniUtakmicuToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdbojkaskiSavez.Properties.Resources.vbgrb;
            this.pictureBox1.Location = new System.Drawing.Point(578, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonnazad
            // 
            this.buttonnazad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonnazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnazad.Location = new System.Drawing.Point(675, 12);
            this.buttonnazad.Name = "buttonnazad";
            this.buttonnazad.Size = new System.Drawing.Size(113, 30);
            this.buttonnazad.TabIndex = 4;
            this.buttonnazad.Text = "Nazad";
            this.buttonnazad.UseVisualStyleBackColor = false;
            this.buttonnazad.Click += new System.EventHandler(this.buttonnazad_Click);
            // 
            // Admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 179);
            this.Controls.Add(this.buttonnazad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin1";
            this.Text = "Admin1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin1_FormClosed);
            this.Load += new System.EventHandler(this.Admin1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUtakmicuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonnazad;
    }
}