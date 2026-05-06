namespace OdbojkaskiSavez
{
    partial class Sudija
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
            this.buttoinDodajUtakmicu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDomaci = new System.Windows.Forms.ComboBox();
            this.comboBoxGosti = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxVreme = new System.Windows.Forms.TextBox();
            this.textBoxLokacija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonnazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridutakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridutakmice
            // 
            this.gridutakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridutakmice.Location = new System.Drawing.Point(161, 46);
            this.gridutakmice.Name = "gridutakmice";
            this.gridutakmice.Size = new System.Drawing.Size(567, 154);
            this.gridutakmice.TabIndex = 0;
            // 
            // buttoinDodajUtakmicu
            // 
            this.buttoinDodajUtakmicu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttoinDodajUtakmicu.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoinDodajUtakmicu.Location = new System.Drawing.Point(514, 271);
            this.buttoinDodajUtakmicu.Name = "buttoinDodajUtakmicu";
            this.buttoinDodajUtakmicu.Size = new System.Drawing.Size(199, 51);
            this.buttoinDodajUtakmicu.TabIndex = 1;
            this.buttoinDodajUtakmicu.Text = "Dodaj:";
            this.buttoinDodajUtakmicu.UseVisualStyleBackColor = false;
            this.buttoinDodajUtakmicu.Click += new System.EventHandler(this.buttoinDodajUtakmicu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdbojkaskiSavez.Properties.Resources.vbgrb;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDomaci
            // 
            this.comboBoxDomaci.FormattingEnabled = true;
            this.comboBoxDomaci.Location = new System.Drawing.Point(161, 234);
            this.comboBoxDomaci.Name = "comboBoxDomaci";
            this.comboBoxDomaci.Size = new System.Drawing.Size(165, 21);
            this.comboBoxDomaci.TabIndex = 6;
            // 
            // comboBoxGosti
            // 
            this.comboBoxGosti.FormattingEnabled = true;
            this.comboBoxGosti.Location = new System.Drawing.Point(332, 234);
            this.comboBoxGosti.Name = "comboBoxGosti";
            this.comboBoxGosti.Size = new System.Drawing.Size(165, 21);
            this.comboBoxGosti.TabIndex = 7;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(503, 235);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(197, 20);
            this.dateTimePickerDatum.TabIndex = 8;
            // 
            // textBoxVreme
            // 
            this.textBoxVreme.Location = new System.Drawing.Point(161, 302);
            this.textBoxVreme.Name = "textBoxVreme";
            this.textBoxVreme.Size = new System.Drawing.Size(165, 20);
            this.textBoxVreme.TabIndex = 9;
            // 
            // textBoxLokacija
            // 
            this.textBoxLokacija.Location = new System.Drawing.Point(332, 302);
            this.textBoxLokacija.Name = "textBoxLokacija";
            this.textBoxLokacija.Size = new System.Drawing.Size(165, 20);
            this.textBoxLokacija.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Domaci tim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gostujuci tim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vreme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lokacija:";
            // 
            // buttonnazad
            // 
            this.buttonnazad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonnazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnazad.Location = new System.Drawing.Point(657, 10);
            this.buttonnazad.Name = "buttonnazad";
            this.buttonnazad.Size = new System.Drawing.Size(113, 30);
            this.buttonnazad.TabIndex = 16;
            this.buttonnazad.Text = "Nazad";
            this.buttonnazad.UseVisualStyleBackColor = false;
            this.buttonnazad.Click += new System.EventHandler(this.buttonnazad_Click);
            // 
            // Sudija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(782, 369);
            this.Controls.Add(this.buttonnazad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLokacija);
            this.Controls.Add(this.textBoxVreme);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.comboBoxGosti);
            this.Controls.Add(this.comboBoxDomaci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttoinDodajUtakmicu);
            this.Controls.Add(this.gridutakmice);
            this.Name = "Sudija";
            this.Text = "Sudija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sudija_FormClosed);
            this.Load += new System.EventHandler(this.Sudija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridutakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridutakmice;
        private System.Windows.Forms.Button buttoinDodajUtakmicu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDomaci;
        private System.Windows.Forms.ComboBox comboBoxGosti;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxVreme;
        private System.Windows.Forms.TextBox textBoxLokacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonnazad;
    }
}