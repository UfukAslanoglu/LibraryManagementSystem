using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akillikutuphane
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

       SqlBaglantisi bgl = new SqlBaglantisi();

        // Kitapları getiren özel fonksiyonumuz
        void KitapListele()
        {
            // Veritabanından kitapları çek
           SqlDataAdapter da = new SqlDataAdapter("Select KitapID, KitapAdi, Yazar, Kategori, StokAdeti, RafBilgisi From Kitaplar", bgl.baglanti());
            DataTable dt = new DataTable();
          da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            KitapListele();
            // Giriş yapan öğrencinin ID'sini ekrana yazalım
           lblBilgi.Text = "Öğrenci ID: " + FrmGiris.GirisYapanKullaniciID;
        }

        // Arama kutusuna her harf yazıldığında çalışır (GÜNCELLENDİ: Artık Yazar ve Kategori de aranıyor)
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            // Hem Kitap Adı, Hem Yazar, Hem de Kategori içinde arama yapan genişletilmiş sorgu
            string sorgu = "Select KitapID, KitapAdi, Yazar, Kategori, StokAdeti, RafBilgisi From Kitaplar " +
                           "where KitapAdi like '%" + txtArama.Text + "%' " +
                           "OR Yazar like '%" + txtArama.Text + "%' " +
                           "OR Kategori like '%" + txtArama.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // Ödünç İste Butonu
        private void btnOdunc_Click(object sender, EventArgs e)
        {
            // Listeden bir satır seçili mi?
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen kitabın ID'sini ve Stok durumunu al
                string secilenKitapID = dataGridView1.SelectedRows[0].Cells["KitapID"].Value.ToString();
                int stok = int.Parse(dataGridView1.SelectedRows[0].Cells["StokAdeti"].Value.ToString());
                // KURAL: Stok 0 ise verilmez (Ödevdeki özel mesaj uyarısı)
                if (stok <= 0)
                {
                    // Ödevin tam istediği cümleyi buraya yazdık:
                    MessageBox.Show("Bu kitap şu anda ödünç verilemez. Stokta bulunmamaktadır.", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlemi durdur
                }

                try
                {
                    // Talebi veritabanına kaydet (Durum: Beklemede)
                    SqlCommand komut = new SqlCommand("INSERT INTO OduncIslemleri (KullaniciID, KitapID, Durum) VALUES (@kID, @ktID, 'Beklemede')", bgl.baglanti());
                    komut.Parameters.AddWithValue("@kID", FrmGiris.GirisYapanKullaniciID);
                    komut.Parameters.AddWithValue("@ktID", secilenKitapID);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Ödünç talebiniz alındı! Personel onaylayınca alabilirsiniz.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz.");
            }
        }
        // MEVCUT KODLARININ ALTINA EKLE:

        // 1. ÖĞRENCİNİN KENDİ GEÇMİŞİNİ GETİREN FONKSİYON
        private void btnKitaplarim_Click(object sender, EventArgs e)
        {
            // Sadece giriş yapan öğrencinin (GirisYapanKullaniciID) verilerini çekiyoruz
            string sorgu = "Select KitapAdi, Yazar, Durum, TalepTarihi, IslemTarihi From OduncIslemleri " +
                           "INNER JOIN Kitaplar ON OduncIslemleri.KitapID = Kitaplar.KitapID " +
                           "WHERE KullaniciID = @p1";

            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", FrmGiris.GirisYapanKullaniciID); // Global ID'yi kullanıyoruz

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            lblListeBaslik.Text = "KİTAPLARIM VE DURUMLARI";

            // Kitaplarım ekranındayken "Ödünç İste" butonunu gizleyelim ki hata olmasın
            btnOdunc.Visible = false;
            // Arama kutusunu da gizleyelim
            txtArama.Visible = false;
        }

        // 2. TEKRAR KİTAP ARAMA EKRANINA DÖNME BUTONU
        private void btnAramaDon_Click(object sender, EventArgs e)
        {
            KitapListele(); // Eski fonksiyonu çağırıp kitapları listele
            lblListeBaslik.Text = "KİTAP LİSTESİ";

            // Gizlediklerimizi geri açalım
            btnOdunc.Visible = true;
            txtArama.Visible = true;
        }
    }
}