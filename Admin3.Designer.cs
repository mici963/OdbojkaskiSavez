namespace OdbojkaskiSavez
{
    partial class Admin3
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
            this.gridutakmice = new System.Windows.Forms.DataGridView();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonnazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridutakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridutakmice
            // 
            this.gridutakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridutakmice.Location = new System.Drawing.Point(22, 48);
            this.gridutakmice.Name = "gridutakmice";
            this.gridutakmice.Size = new System.Drawing.Size(730, 167);
            this.gridutakmice.TabIndex = 0;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(269, 221);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(233, 61);
            this.buttonObrisi.TabIndex = 1;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdbojkaskiSavez.Properties.Resources.vbgrb;
            this.pictureBox1.Location = new System.Drawing.Point(25, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonnazad
            // 
            this.buttonnazad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonnazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnazad.Location = new System.Drawing.Point(639, 12);
            this.buttonnazad.Name = "buttonnazad";
            this.buttonnazad.Size = new System.Drawing.Size(113, 30);
            this.buttonnazad.TabIndex = 5;
            this.buttonnazad.Text = "Nazad";
            this.buttonnazad.UseVisualStyleBackColor = false;
            this.buttonnazad.Click += new System.EventHandler(this.buttonnazad_Click);
            // 
            // Admin3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(764, 375);
            this.Controls.Add(this.buttonnazad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.gridutakmice);
            this.Name = "Admin3";
            this.Text = "Admin3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin3_FormClosed);
            this.Load += new System.EventHandler(this.Admin3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridutakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridutakmice;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonnazad;
    }
}