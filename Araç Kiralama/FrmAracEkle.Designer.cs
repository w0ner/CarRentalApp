namespace Araç_Kiralama
{
    partial class FrmAracEkle
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
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.cmbYakıt = new System.Windows.Forms.ComboBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(119, 59);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(193, 27);
            this.txtPlaka.TabIndex = 1;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Bmw",
            "Mercedes",
            "Fiat",
            "Renault"});
            this.cmbMarka.Location = new System.Drawing.Point(119, 92);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(193, 28);
            this.cmbMarka.TabIndex = 2;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbSeri
            // 
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(119, 126);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(193, 28);
            this.cmbSeri.TabIndex = 3;
            this.cmbSeri.SelectedIndexChanged += new System.EventHandler(this.cmbSeri_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(119, 160);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(193, 27);
            this.txtModel.TabIndex = 4;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(119, 193);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(193, 27);
            this.txtRenk.TabIndex = 5;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(119, 226);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(193, 27);
            this.txtKm.TabIndex = 6;
            // 
            // cmbYakıt
            // 
            this.cmbYakıt.FormattingEnabled = true;
            this.cmbYakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.cmbYakıt.Location = new System.Drawing.Point(119, 259);
            this.cmbYakıt.Name = "cmbYakıt";
            this.cmbYakıt.Size = new System.Drawing.Size(193, 28);
            this.cmbYakıt.TabIndex = 7;
            this.cmbYakıt.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(119, 293);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(193, 27);
            this.txtKiraÜcreti.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(82, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kira Ücreti";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(345, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResimEkle.Location = new System.Drawing.Point(397, 250);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(99, 37);
            this.btnResimEkle.TabIndex = 11;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayıt.Location = new System.Drawing.Point(119, 347);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(94, 39);
            this.btnKayıt.TabIndex = 9;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİptal.Location = new System.Drawing.Point(218, 347);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(94, 39);
            this.btnİptal.TabIndex = 10;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(598, 436);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYakıt);
            this.Controls.Add(this.cmbSeri);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtKiraÜcreti);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmAracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.Load += new System.EventHandler(this.FrmAracEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPlaka;
        private ComboBox cmbMarka;
        private ComboBox cmbSeri;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtKm;
        private ComboBox cmbYakıt;
        private TextBox txtKiraÜcreti;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnResimEkle;
        private Button btnKayıt;
        private Button btnİptal;
        private OpenFileDialog openFileDialog1;
    }
}