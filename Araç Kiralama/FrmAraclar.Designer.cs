namespace Araç_Kiralama
{
    partial class FrmAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAraclar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKasa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatısYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnMusterıler = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbYakıt = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnSatısYap);
            this.panel1.Controls.Add(this.button1);
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
            this.btnKasa.ImageIndex = 4;
            this.btnKasa.ImageList = this.ımageList1;
            this.btnKasa.Location = new System.Drawing.Point(26, 455);
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
            this.ımageList1.Images.SetKeyName(0, "plus.png");
            this.ımageList1.Images.SetKeyName(1, "customer.png");
            this.ımageList1.Images.SetKeyName(2, "sport-car.png");
            this.ımageList1.Images.SetKeyName(3, "debit-card.png");
            this.ımageList1.Images.SetKeyName(4, "dollar.png");
            this.ımageList1.Images.SetKeyName(5, "car.png");
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSatısYap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSatısYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatısYap.ImageIndex = 3;
            this.btnSatısYap.ImageList = this.ımageList1;
            this.btnSatısYap.Location = new System.Drawing.Point(26, 342);
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(124, 107);
            this.btnSatısYap.TabIndex = 2;
            this.btnSatısYap.Text = "SATIŞ YAP";
            this.btnSatısYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatısYap.UseVisualStyleBackColor = false;
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(26, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "ARAÇ EKLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAraclar
            // 
            this.btnAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAraclar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAraclar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAraclar.ImageIndex = 2;
            this.btnAraclar.ImageList = this.ımageList1;
            this.btnAraclar.Location = new System.Drawing.Point(26, 237);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(124, 99);
            this.btnAraclar.TabIndex = 1;
            this.btnAraclar.Text = "ARAÇLAR";
            this.btnAraclar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAraclar.UseVisualStyleBackColor = false;
            // 
            // btnMusterıler
            // 
            this.btnMusterıler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMusterıler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMusterıler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMusterıler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusterıler.ImageIndex = 1;
            this.btnMusterıler.ImageList = this.ımageList1;
            this.btnMusterıler.Location = new System.Drawing.Point(26, 122);
            this.btnMusterıler.Name = "btnMusterıler";
            this.btnMusterıler.Size = new System.Drawing.Size(124, 109);
            this.btnMusterıler.TabIndex = 0;
            this.btnMusterıler.Text = "MÜŞTERİLER";
            this.btnMusterıler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusterıler.UseVisualStyleBackColor = false;
            this.btnMusterıler.Click += new System.EventHandler(this.btnMusterıler_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(184, 94);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(158, 27);
            this.txtPlaka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(187, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Renk";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(363, 181);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(158, 27);
            this.txtKm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(363, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(363, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "KM";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(724, 180);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(158, 27);
            this.txtFiyat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(543, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Seri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(543, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yakıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(724, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Model";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(184, 181);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(158, 27);
            this.txtRenk.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(724, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fiyat";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(724, 92);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(158, 27);
            this.txtModel.TabIndex = 3;
            // 
            // cmbYakıt
            // 
            this.cmbYakıt.FormattingEnabled = true;
            this.cmbYakıt.Location = new System.Drawing.Point(543, 180);
            this.cmbYakıt.Name = "cmbYakıt";
            this.cmbYakıt.Size = new System.Drawing.Size(158, 28);
            this.cmbYakıt.TabIndex = 4;
            // 
            // cmbSeri
            // 
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(543, 92);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(158, 28);
            this.cmbSeri.TabIndex = 4;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(363, 92);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(158, 28);
            this.cmbMarka.TabIndex = 4;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(184, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "ARAÇ BİLGİLERİNİ GÜNCELLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(915, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResimSec.Location = new System.Drawing.Point(959, 214);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(94, 36);
            this.btnResimSec.TabIndex = 9;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Green;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGüncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGüncelle.Location = new System.Drawing.Point(1127, 69);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(90, 181);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(184, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 354);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.Color.Red;
            this.btnAracSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAracSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAracSil.Location = new System.Drawing.Point(184, 647);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(100, 46);
            this.btnAracSil.TabIndex = 12;
            this.btnAracSil.Text = "Aracı Sil";
            this.btnAracSil.UseVisualStyleBackColor = false;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(184, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Filtrele";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Müsait Araçlar",
            "Dolu Araçlar"});
            this.comboBox1.Location = new System.Drawing.Point(244, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 715);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.cmbSeri);
            this.Controls.Add(this.cmbYakıt);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label1);
            this.Name = "FrmAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.FrmAraclar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaSayfa = new();
            anaSayfa.Show();
            this.Hide();
        }



        #endregion

        private Panel panel1;
        private Button btnMusterıler;
        private Button btnKasa;
        private Button btnSatısYap;
        private Button btnAraclar;
        private Button btnGeri;
        private ImageList ımageList1;
        private Button button1;
        private Label label1;
        private TextBox txtPlaka;
        private Label label2;
        private TextBox txtKm;
        private Label label3;
        private Label label4;
        private TextBox txtFiyat;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRenk;
        private Label label8;
        private TextBox txtModel;
        private ComboBox cmbYakıt;
        private ComboBox cmbSeri;
        private ComboBox cmbMarka;
        private Label label9;
        private PictureBox pictureBox1;
        private Button btnResimSec;
        private Button btnGüncelle;
        private DataGridView dataGridView1;
        private Button btnAracSil;
        private Label label10;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
    }
}