namespace Akillikutuphane
{
    partial class FrmPersonel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.btnGecikmis = new System.Windows.Forms.Button();
            this.lblVerilen = new System.Windows.Forms.Label();
            this.lblIade = new System.Windows.Forms.Label();
            this.btnGecikenleriGoster = new System.Windows.Forms.Button();
            this.btnTumunuGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(901, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOnayla.Location = new System.Drawing.Point(39, 285);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(122, 23);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Talebi Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.Peru;
            this.btnTeslim.Location = new System.Drawing.Point(176, 285);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(171, 23);
            this.btnTeslim.TabIndex = 3;
            this.btnTeslim.Text = "Kitabı Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // btnIade
            // 
            this.btnIade.BackColor = System.Drawing.Color.Orange;
            this.btnIade.Location = new System.Drawing.Point(366, 285);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(75, 23);
            this.btnIade.TabIndex = 4;
            this.btnIade.Text = "Iade Al";
            this.btnIade.UseVisualStyleBackColor = false;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // btnGecikmis
            // 
            this.btnGecikmis.BackColor = System.Drawing.Color.Red;
            this.btnGecikmis.Location = new System.Drawing.Point(457, 285);
            this.btnGecikmis.Name = "btnGecikmis";
            this.btnGecikmis.Size = new System.Drawing.Size(233, 23);
            this.btnGecikmis.TabIndex = 5;
            this.btnGecikmis.Text = "GECİKMİŞ OLARAK İŞARETLE";
            this.btnGecikmis.UseVisualStyleBackColor = false;
            this.btnGecikmis.Click += new System.EventHandler(this.btnGecikmis_Click);
            // 
            // lblVerilen
            // 
            this.lblVerilen.AutoSize = true;
            this.lblVerilen.Location = new System.Drawing.Point(36, 60);
            this.lblVerilen.Name = "lblVerilen";
            this.lblVerilen.Size = new System.Drawing.Size(129, 16);
            this.lblVerilen.TabIndex = 6;
            this.lblVerilen.Text = "BUGÜN VERİLEN: 0";
            // 
            // lblIade
            // 
            this.lblIade.AutoSize = true;
            this.lblIade.Location = new System.Drawing.Point(204, 60);
            this.lblIade.Name = "lblIade";
            this.lblIade.Size = new System.Drawing.Size(103, 16);
            this.lblIade.TabIndex = 7;
            this.lblIade.Text = "BÜGÜN IADE: 0";
            // 
            // btnGecikenleriGoster
            // 
            this.btnGecikenleriGoster.Location = new System.Drawing.Point(339, 57);
            this.btnGecikenleriGoster.Name = "btnGecikenleriGoster";
            this.btnGecikenleriGoster.Size = new System.Drawing.Size(222, 23);
            this.btnGecikenleriGoster.TabIndex = 8;
            this.btnGecikenleriGoster.Text = "GECİKENLERİ GÖSTER:";
            this.btnGecikenleriGoster.UseVisualStyleBackColor = true;
            this.btnGecikenleriGoster.Click += new System.EventHandler(this.btnGecikenleriGoster_Click);
            // 
            // btnTumunuGoster
            // 
            this.btnTumunuGoster.Location = new System.Drawing.Point(617, 57);
            this.btnTumunuGoster.Name = "btnTumunuGoster";
            this.btnTumunuGoster.Size = new System.Drawing.Size(193, 23);
            this.btnTumunuGoster.TabIndex = 9;
            this.btnTumunuGoster.Text = "TÜM TALEPLERİ GÖSTER";
            this.btnTumunuGoster.UseVisualStyleBackColor = true;
            this.btnTumunuGoster.Click += new System.EventHandler(this.btnTumunuGoster_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 575);
            this.Controls.Add(this.btnTumunuGoster);
            this.Controls.Add(this.btnGecikenleriGoster);
            this.Controls.Add(this.lblIade);
            this.Controls.Add(this.lblVerilen);
            this.Controls.Add(this.btnGecikmis);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPersonel";
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Button btnGecikmis;
        private System.Windows.Forms.Label lblVerilen;
        private System.Windows.Forms.Label lblIade;
        private System.Windows.Forms.Button btnGecikenleriGoster;
        private System.Windows.Forms.Button btnTumunuGoster;
    }
}