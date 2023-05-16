namespace Araç_Kiralama
{
    partial class FrmMüsteriler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüsteriler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKasa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatısYap = new System.Windows.Forms.Button();
            this.btnMüsEkle = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnMusterıler = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnSatısYap);
            this.panel1.Controls.Add(this.btnMüsEkle);
            this.panel1.Controls.Add(this.btnAraclar);
            this.panel1.Controls.Add(this.btnMusterıler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 715);
            this.panel1.TabIndex = 0;
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKasa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasa.ImageIndex = 3;
            this.btnKasa.ImageList = this.ımageList1;
            this.btnKasa.Location = new System.Drawing.Point(26, 445);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(124, 109);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.Text = "KASA";
            this.btnKasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sport-car.png");
            this.ımageList1.Images.SetKeyName(1, "customer.png");
            this.ımageList1.Images.SetKeyName(2, "debit-card.png");
            this.ımageList1.Images.SetKeyName(3, "dollar.png");
            this.ımageList1.Images.SetKeyName(4, "queue.png");
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSatısYap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSatısYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatısYap.ImageIndex = 2;
            this.btnSatısYap.ImageList = this.ımageList1;
            this.btnSatısYap.Location = new System.Drawing.Point(26, 332);
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(124, 107);
            this.btnSatısYap.TabIndex = 2;
            this.btnSatısYap.Text = "SATIŞ YAP";
            this.btnSatısYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatısYap.UseVisualStyleBackColor = false;
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // btnMüsEkle
            // 
            this.btnMüsEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMüsEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMüsEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMüsEkle.ImageIndex = 4;
            this.btnMüsEkle.ImageList = this.ımageList1;
            this.btnMüsEkle.Location = new System.Drawing.Point(26, 7);
            this.btnMüsEkle.Name = "btnMüsEkle";
            this.btnMüsEkle.Size = new System.Drawing.Size(124, 99);
            this.btnMüsEkle.TabIndex = 1;
            this.btnMüsEkle.Text = "MÜŞTERİ EKLE";
            this.btnMüsEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMüsEkle.UseVisualStyleBackColor = false;
            this.btnMüsEkle.Click += new System.EventHandler(this.btnMüsEkle_Click);
            // 
            // btnAraclar
            // 
            this.btnAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAraclar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAraclar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAraclar.ImageIndex = 0;
            this.btnAraclar.ImageList = this.ımageList1;
            this.btnAraclar.Location = new System.Drawing.Point(26, 227);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(124, 99);
            this.btnAraclar.TabIndex = 1;
            this.btnAraclar.Text = "ARAÇLAR";
            this.btnAraclar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAraclar.UseVisualStyleBackColor = false;
            this.btnAraclar.Click += new System.EventHandler(this.btnAraclar_Click);
            // 
            // btnMusterıler
            // 
            this.btnMusterıler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMusterıler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMusterıler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMusterıler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusterıler.ImageIndex = 1;
            this.btnMusterıler.ImageList = this.ımageList1;
            this.btnMusterıler.Location = new System.Drawing.Point(26, 112);
            this.btnMusterıler.Name = "btnMusterıler";
            this.btnMusterıler.Size = new System.Drawing.Size(124, 109);
            this.btnMusterıler.TabIndex = 0;
            this.btnMusterıler.Text = "MÜŞTERİLER";
            this.btnMusterıler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusterıler.UseVisualStyleBackColor = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(1309, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(51, 47);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 351);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(899, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÜŞTERİ BİLGİLERİNİ GÜNCELLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(899, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC Kimlik Numarası";
            // 
            // txtTC
            // 
            this.txtTC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTC.Location = new System.Drawing.Point(899, 135);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(178, 27);
            this.txtTC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1083, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(1083, 135);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(178, 27);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(899, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1083, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(1083, 217);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(178, 27);
            this.txtMail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(899, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdres.Location = new System.Drawing.Point(899, 299);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(362, 117);
            this.txtAdres.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(899, 433);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 41);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(185, 461);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 45);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Müşteriyi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(202, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "TC NO İLE ARA";
            // 
            // txtArama
            // 
            this.txtArama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtArama.Location = new System.Drawing.Point(343, 35);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(245, 27);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefon.Location = new System.Drawing.Point(899, 217);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(178, 27);
            this.txtTelefon.TabIndex = 3;
            // 
            // FrmMüsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 715);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMüsteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmMüsteriler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Panel panel1;
        private Button btnMusterıler;
        private Button btnKasa;
        private Button btnSatısYap;
        private Button btnAraclar;
        private Button btnGeri;
        private ImageList ımageList1;
        private Button btnMüsEkle;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtTC;
        private Label label3;
        private TextBox txtAdSoyad;
        private Label label4;
        private Label label5;
        private TextBox txtMail;
        private Label label6;
        private TextBox txtAdres;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label7;
        private TextBox txtArama;
        private TextBox txtTelefon;
    }
}