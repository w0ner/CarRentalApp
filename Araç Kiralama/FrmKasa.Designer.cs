namespace Araç_Kiralama
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKasa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatısYap = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnMusterıler = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnSatısYap);
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
            this.btnKasa.Location = new System.Drawing.Point(27, 429);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(124, 109);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.Text = "KASA";
            this.btnKasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasa.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "customer.png");
            this.ımageList1.Images.SetKeyName(1, "sport-car.png");
            this.ımageList1.Images.SetKeyName(2, "debit-card.png");
            this.ımageList1.Images.SetKeyName(3, "dollar.png");
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSatısYap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSatısYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatısYap.ImageIndex = 2;
            this.btnSatısYap.ImageList = this.ımageList1;
            this.btnSatısYap.Location = new System.Drawing.Point(27, 316);
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(124, 107);
            this.btnSatısYap.TabIndex = 2;
            this.btnSatısYap.Text = "SATIŞ YAP";
            this.btnSatısYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatısYap.UseVisualStyleBackColor = false;
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // btnAraclar
            // 
            this.btnAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAraclar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAraclar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAraclar.ImageIndex = 1;
            this.btnAraclar.ImageList = this.ımageList1;
            this.btnAraclar.Location = new System.Drawing.Point(27, 211);
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
            this.btnMusterıler.ImageIndex = 0;
            this.btnMusterıler.ImageList = this.ımageList1;
            this.btnMusterıler.Location = new System.Drawing.Point(27, 96);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 442);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            this.panel1.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private Label label1;
    }
}