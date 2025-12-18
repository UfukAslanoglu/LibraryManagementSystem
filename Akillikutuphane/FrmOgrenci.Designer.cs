namespace Akillikutuphane
{
    partial class FrmOgrenci
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
            this.btnOdunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnKitaplarim = new System.Windows.Forms.Button();
            this.btnAramaDon = new System.Windows.Forms.Button();
            this.lblListeBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdunc
            // 
            this.btnOdunc.Location = new System.Drawing.Point(296, 41);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(109, 23);
            this.btnOdunc.TabIndex = 0;
            this.btnOdunc.Text = "ÖDÜNÇ İSTE";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı Arama:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(158, 44);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(100, 22);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(61, 380);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(44, 16);
            this.lblBilgi.TabIndex = 4;
            this.lblBilgi.Text = "label2";
            // 
            // btnKitaplarim
            // 
            this.btnKitaplarim.Location = new System.Drawing.Point(625, 41);
            this.btnKitaplarim.Name = "btnKitaplarim";
            this.btnKitaplarim.Size = new System.Drawing.Size(151, 53);
            this.btnKitaplarim.TabIndex = 5;
            this.btnKitaplarim.Text = "KİTAPLARIM / DURUM";
            this.btnKitaplarim.UseVisualStyleBackColor = true;
            this.btnKitaplarim.Click += new System.EventHandler(this.btnKitaplarim_Click);
            // 
            // btnAramaDon
            // 
            this.btnAramaDon.Location = new System.Drawing.Point(441, 41);
            this.btnAramaDon.Name = "btnAramaDon";
            this.btnAramaDon.Size = new System.Drawing.Size(165, 53);
            this.btnAramaDon.TabIndex = 6;
            this.btnAramaDon.Text = "TÜM KİTAPLARI LİSTELE (GERİ DÖN)";
            this.btnAramaDon.UseVisualStyleBackColor = true;
            this.btnAramaDon.Click += new System.EventHandler(this.btnAramaDon_Click);
            // 
            // lblListeBaslik
            // 
            this.lblListeBaslik.AutoSize = true;
            this.lblListeBaslik.Location = new System.Drawing.Point(104, 106);
            this.lblListeBaslik.Name = "lblListeBaslik";
            this.lblListeBaslik.Size = new System.Drawing.Size(78, 16);
            this.lblListeBaslik.TabIndex = 7;
            this.lblListeBaslik.Text = "Kitap Listesi";
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListeBaslik);
            this.Controls.Add(this.btnAramaDon);
            this.Controls.Add(this.btnKitaplarim);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdunc);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnKitaplarim;
        private System.Windows.Forms.Button btnAramaDon;
        private System.Windows.Forms.Label lblListeBaslik;
    }
}