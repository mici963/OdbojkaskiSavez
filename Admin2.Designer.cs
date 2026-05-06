namespace OdbojkaskiSavez
{
    partial class Admin2
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
            this.gridtimovi = new System.Windows.Forms.DataGridView();
            this.textBoxnazivtima = new System.Windows.Forms.TextBox();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonobrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonnazad = new System.Windows.Forms.Button();
            this.comboBoxtrener = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridtimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridtimovi
            // 
            this.gridtimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtimovi.Location = new System.Drawing.Point(21, 12);
            this.gridtimovi.Name = "gridtimovi";
            this.gridtimovi.Size = new System.Drawing.Size(352, 200);
            this.gridtimovi.TabIndex = 0;
            // 
            // textBoxnazivtima
            // 
            this.textBoxnazivtima.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxnazivtima.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnazivtima.Location = new System.Drawing.Point(391, 93);
            this.textBoxnazivtima.Name = "textBoxnazivtima";
            this.textBoxnazivtima.Size = new System.Drawing.Size(186, 29);
            this.textBoxnazivtima.TabIndex = 1;
            // 
            // buttondodaj
            // 
            this.buttondodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttondodaj.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondodaj.Location = new System.Drawing.Point(430, 128);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(111, 36);
            this.buttondodaj.TabIndex = 2;
            this.buttondodaj.Text = "Dodaj";
            this.buttondodaj.UseVisualStyleBackColor = false;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonobrisi
            // 
            this.buttonobrisi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonobrisi.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonobrisi.Location = new System.Drawing.Point(430, 170);
            this.buttonobrisi.Name = "buttonobrisi";
            this.buttonobrisi.Size = new System.Drawing.Size(111, 36);
            this.buttonobrisi.TabIndex = 3;
            this.buttonobrisi.Text = "Obrisi:";
            this.buttonobrisi.UseVisualStyleBackColor = false;
            this.buttonobrisi.Click += new System.EventHandler(this.buttonobrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv tima:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdbojkaskiSavez.Properties.Resources.vbgrb;
            this.pictureBox1.Location = new System.Drawing.Point(465, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonnazad
            // 
            this.buttonnazad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonnazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnazad.Location = new System.Drawing.Point(579, 12);
            this.buttonnazad.Name = "buttonnazad";
            this.buttonnazad.Size = new System.Drawing.Size(113, 30);
            this.buttonnazad.TabIndex = 6;
            this.buttonnazad.Text = "Nazad";
            this.buttonnazad.UseVisualStyleBackColor = false;
            this.buttonnazad.Click += new System.EventHandler(this.buttonnazad_Click);
            // 
            // comboBoxtrener
            // 
            this.comboBoxtrener.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBoxtrener.FormattingEnabled = true;
            this.comboBoxtrener.Location = new System.Drawing.Point(583, 99);
            this.comboBoxtrener.Name = "comboBoxtrener";
            this.comboBoxtrener.Size = new System.Drawing.Size(113, 21);
            this.comboBoxtrener.TabIndex = 7;
            // 
            // Admin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(704, 250);
            this.Controls.Add(this.comboBoxtrener);
            this.Controls.Add(this.buttonnazad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonobrisi);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.textBoxnazivtima);
            this.Controls.Add(this.gridtimovi);
            this.Name = "Admin2";
            this.Text = "Admin2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin2_FormClosed);
            this.Load += new System.EventHandler(this.Admin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridtimovi;
        private System.Windows.Forms.TextBox textBoxnazivtima;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonobrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonnazad;
        private System.Windows.Forms.ComboBox comboBoxtrener;
    }
}