namespace ForginKey_ve_Inner_Join_Örnek_Uygulam
{
    partial class forginKey_Join_Alistirma
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGrid_Bilgiler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.txt_AdiSoyadi = new System.Windows.Forms.TextBox();
            this.lbl_AdiSoyadi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.txt_Yil = new System.Windows.Forms.TextBox();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.lbl_Yil = new System.Windows.Forms.Label();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.lbl_Plaka = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Bilgiler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.dtGrid_Bilgiler);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 506);
            this.panel1.TabIndex = 0;
            // 
            // dtGrid_Bilgiler
            // 
            this.dtGrid_Bilgiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Bilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Bilgiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_Bilgiler.Location = new System.Drawing.Point(178, 0);
            this.dtGrid_Bilgiler.Name = "dtGrid_Bilgiler";
            this.dtGrid_Bilgiler.Size = new System.Drawing.Size(651, 506);
            this.dtGrid_Bilgiler.TabIndex = 1;
            this.dtGrid_Bilgiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Bilgiler_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Sil);
            this.groupBox4.Controls.Add(this.btn_Guncelle);
            this.groupBox4.Controls.Add(this.btn_Ekle);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(3, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sil.Location = new System.Drawing.Point(3, 86);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(166, 34);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Guncelle.Location = new System.Drawing.Point(3, 52);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(166, 34);
            this.btn_Guncelle.TabIndex = 1;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ekle.Location = new System.Drawing.Point(3, 18);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(166, 34);
            this.btn_Ekle.TabIndex = 0;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Telefon);
            this.groupBox3.Controls.Add(this.lbl_Telefon);
            this.groupBox3.Controls.Add(this.txt_AdiSoyadi);
            this.groupBox3.Controls.Add(this.lbl_AdiSoyadi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(3, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 122);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Bilgileri";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(14, 91);
            this.txt_Telefon.MaxLength = 11;
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(128, 22);
            this.txt_Telefon.TabIndex = 20;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(11, 72);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(55, 16);
            this.lbl_Telefon.TabIndex = 10;
            this.lbl_Telefon.Text = "Telefon";
            // 
            // txt_AdiSoyadi
            // 
            this.txt_AdiSoyadi.Location = new System.Drawing.Point(12, 42);
            this.txt_AdiSoyadi.Name = "txt_AdiSoyadi";
            this.txt_AdiSoyadi.Size = new System.Drawing.Size(128, 22);
            this.txt_AdiSoyadi.TabIndex = 9;
            // 
            // lbl_AdiSoyadi
            // 
            this.lbl_AdiSoyadi.AutoSize = true;
            this.lbl_AdiSoyadi.Location = new System.Drawing.Point(9, 23);
            this.lbl_AdiSoyadi.Name = "lbl_AdiSoyadi";
            this.lbl_AdiSoyadi.Size = new System.Drawing.Size(78, 16);
            this.lbl_AdiSoyadi.TabIndex = 8;
            this.lbl_AdiSoyadi.Text = "Adı Soyadı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.txt_Model);
            this.groupBox2.Controls.Add(this.lbl_Model);
            this.groupBox2.Controls.Add(this.txt_Yil);
            this.groupBox2.Controls.Add(this.txt_Marka);
            this.groupBox2.Controls.Add(this.lbl_Yil);
            this.groupBox2.Controls.Add(this.lbl_Marka);
            this.groupBox2.Controls.Add(this.txt_Plaka);
            this.groupBox2.Controls.Add(this.lbl_Plaka);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 223);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(133, 14);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 16);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(12, 142);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(128, 22);
            this.txt_Model.TabIndex = 5;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(9, 123);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(47, 16);
            this.lbl_Model.TabIndex = 4;
            this.lbl_Model.Text = "Model";
            // 
            // txt_Yil
            // 
            this.txt_Yil.Location = new System.Drawing.Point(14, 190);
            this.txt_Yil.MaxLength = 4;
            this.txt_Yil.Name = "txt_Yil";
            this.txt_Yil.Size = new System.Drawing.Size(128, 22);
            this.txt_Yil.TabIndex = 7;
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(12, 93);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(128, 22);
            this.txt_Marka.TabIndex = 3;
            // 
            // lbl_Yil
            // 
            this.lbl_Yil.AutoSize = true;
            this.lbl_Yil.Location = new System.Drawing.Point(11, 171);
            this.lbl_Yil.Name = "lbl_Yil";
            this.lbl_Yil.Size = new System.Drawing.Size(26, 16);
            this.lbl_Yil.TabIndex = 6;
            this.lbl_Yil.Text = "Yil";
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.Location = new System.Drawing.Point(9, 74);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(50, 16);
            this.lbl_Marka.TabIndex = 2;
            this.lbl_Marka.Text = "Marka";
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.Location = new System.Drawing.Point(12, 46);
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(128, 22);
            this.txt_Plaka.TabIndex = 1;
            //this.txt_Plaka.TextChanged += new System.EventHandler(this.txt_Plaka_TextChanged);
            // 
            // lbl_Plaka
            // 
            this.lbl_Plaka.AutoSize = true;
            this.lbl_Plaka.Location = new System.Drawing.Point(9, 27);
            this.lbl_Plaka.Name = "lbl_Plaka";
            this.lbl_Plaka.Size = new System.Drawing.Size(45, 16);
            this.lbl_Plaka.TabIndex = 0;
            this.lbl_Plaka.Text = "Plaka";
            // 
            // forginKey_Join_Alistirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 506);
            this.Controls.Add(this.panel1);
            this.Name = "forginKey_Join_Alistirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORIN KEY & INNER JOIN";
            this.Load += new System.EventHandler(this.forginKey_Join_Alistirma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Bilgiler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGrid_Bilgiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Plaka;
        private System.Windows.Forms.Label lbl_Plaka;
        private System.Windows.Forms.TextBox txt_AdiSoyadi;
        private System.Windows.Forms.Label lbl_AdiSoyadi;
        private System.Windows.Forms.TextBox txt_Yil;
        private System.Windows.Forms.Label lbl_Yil;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_id;
    }
}

