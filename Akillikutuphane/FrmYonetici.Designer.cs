namespace Akillikutuphane
{
    partial class FrmYonetici
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUyeleriListele = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.lblListeDurumu = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEnCokOkunan = new System.Windows.Forms.Button();
            this.lblGizliID = new System.Windows.Forms.Label();
            this.btnPersonelYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raf Bilgisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(134, 53);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(100, 22);
            this.txtKitapAd.TabIndex = 5;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(134, 81);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 22);
            this.txtYazar.TabIndex = 6;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(134, 116);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 22);
            this.txtKategori.TabIndex = 7;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(134, 147);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(100, 22);
            this.txtSayfa.TabIndex = 8;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(134, 180);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 225);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEkle.Location = new System.Drawing.Point(21, 237);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(122, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(165, 237);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Seçileni Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUyeleriListele
            // 
            this.btnUyeleriListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUyeleriListele.Location = new System.Drawing.Point(286, 306);
            this.btnUyeleriListele.Name = "btnUyeleriListele";
            this.btnUyeleriListele.Size = new System.Drawing.Size(167, 23);
            this.btnUyeleriListele.TabIndex = 13;
            this.btnUyeleriListele.Text = "Üyeleri Listele";
            this.btnUyeleriListele.UseVisualStyleBackColor = false;
            this.btnUyeleriListele.Click += new System.EventHandler(this.btnUyeleriListele_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUyeSil.Location = new System.Drawing.Point(488, 306);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(167, 23);
            this.btnUyeSil.TabIndex = 14;
            this.btnUyeSil.Text = "Seçili Üyeyi Sil";
            this.btnUyeSil.UseVisualStyleBackColor = false;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // lblListeDurumu
            // 
            this.lblListeDurumu.AutoSize = true;
            this.lblListeDurumu.Location = new System.Drawing.Point(283, 25);
            this.lblListeDurumu.Name = "lblListeDurumu";
            this.lblListeDurumu.Size = new System.Drawing.Size(156, 16);
            this.lblListeDurumu.TabIndex = 15;
            this.lblListeDurumu.Text = "Görüntülenen: KİTAPLAR";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 277);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(178, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "KİTAP GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEnCokOkunan
            // 
            this.btnEnCokOkunan.BackColor = System.Drawing.Color.Lime;
            this.btnEnCokOkunan.Location = new System.Drawing.Point(12, 306);
            this.btnEnCokOkunan.Name = "btnEnCokOkunan";
            this.btnEnCokOkunan.Size = new System.Drawing.Size(178, 23);
            this.btnEnCokOkunan.TabIndex = 17;
            this.btnEnCokOkunan.Text = "EN ÇOK OKUNANLAR";
            this.btnEnCokOkunan.UseVisualStyleBackColor = false;
            this.btnEnCokOkunan.Click += new System.EventHandler(this.btnEnCokOkunan_Click);
            // 
            // lblGizliID
            // 
            this.lblGizliID.AutoSize = true;
            this.lblGizliID.Location = new System.Drawing.Point(33, 395);
            this.lblGizliID.Name = "lblGizliID";
            this.lblGizliID.Size = new System.Drawing.Size(11, 16);
            this.lblGizliID.TabIndex = 18;
            this.lblGizliID.Text = "-";
            // 
            // btnPersonelYap
            // 
            this.btnPersonelYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelYap.Location = new System.Drawing.Point(676, 306);
            this.btnPersonelYap.Name = "btnPersonelYap";
            this.btnPersonelYap.Size = new System.Drawing.Size(239, 23);
            this.btnPersonelYap.TabIndex = 19;
            this.btnPersonelYap.Text = "SEÇİLİ ÜYEYİ PERSONEL YAP";
            this.btnPersonelYap.UseVisualStyleBackColor = false;
            this.btnPersonelYap.Click += new System.EventHandler(this.btnPersonelYap_Click);
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 510);
            this.Controls.Add(this.btnPersonelYap);
            this.Controls.Add(this.lblGizliID);
            this.Controls.Add(this.btnEnCokOkunan);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblListeDurumu);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.btnUyeleriListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUyeleriListele;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Label lblListeDurumu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEnCokOkunan;
        private System.Windows.Forms.Label lblGizliID;
        private System.Windows.Forms.Button btnPersonelYap;
    }
}