using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akillikutuphane
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // 1. TALEPLERİ LİSTELEME FONKSİYONU
        void TalepleriListele()
        {
            // İade edilenleri listede görmeye gerek yok, sadece aktif işleri görelim
            string sorgu = "Select IslemID, AdSoyad, KitapAdi, Durum, TalepTarihi From OduncIslemleri " +
                           "INNER JOIN Kullanicilar ON OduncIslemleri.KullaniciID = Kullanicilar.KullaniciID " +
                           "INNER JOIN Kitaplar ON OduncIslemleri.KitapID = Kitaplar.KitapID " +
                           "WHERE Durum != 'IadeEdildi'";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        // 2. GÜNLÜK İSTATİSTİKLERİ HESAPLAYAN YENİ FONKSİYON 📊
        void IstatistikleriGetir()
        {
            // Bugün "Teslim Edildi" yapılanların sayısı
            SqlCommand komut1 = new SqlCommand("Select Count(*) From OduncIslemleri Where Durum='Teslim Edildi' And Convert(date, IslemTarihi) = Convert(date, GETDATE())", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblVerilen.Text = "Bugün Verilen: " + dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // Bugün "Iade Edildi" yapılanların sayısı
            SqlCommand komut2 = new SqlCommand("Select Count(*) From OduncIslemleri Where Durum='Iade Edildi' And Convert(date, IslemTarihi) = Convert(date, GETDATE())", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblIade.Text = "Bugün İade: " + dr2[0].ToString();
            }
            bgl.baglanti().Close();
        }

        // FORM YÜKLENİNCE
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            TalepleriListele();
            IstatistikleriGetir(); // Açılışta sayıları getir
        }

        // 3. DURUM GÜNCELLEME (ARTIK TARİHİ DE GÜNCELLİYOR) 📅
        void DurumGuncelle(string yeniDurum)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string islemID = dataGridView2.SelectedRows[0].Cells["IslemID"].Value.ToString();

                // Hem durumu değiştiriyoruz hem de 'IslemTarihi'ni şu an yapıyoruz (İstatistik için)
                SqlCommand komut = new SqlCommand("Update OduncIslemleri Set Durum=@d, IslemTarihi=@t where IslemID=@id", bgl.baglanti());
                komut.Parameters.AddWithValue("@d", yeniDurum);
                komut.Parameters.AddWithValue("@t", DateTime.Now); // Şu anki tarih/saat
                komut.Parameters.AddWithValue("@id", islemID);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İşlem Başarılı: " + yeniDurum);

                TalepleriListele();     // Listeyi yenile
                IstatistikleriGetir();  // Sayıları yenile
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir işlem seçiniz.");
            }
        }

        // --- BUTONLAR ---

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            DurumGuncelle("Onaylandı");
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            DurumGuncelle("Teslim Edildi");
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            DurumGuncelle("Iade Edildi");
        }

        // YENİ EKLENEN BUTON: GECİKMİŞ
        private void btnGecikmis_Click(object sender, EventArgs e)
        {
            DurumGuncelle("Gecikmiş");
        }
        // 1. GECİKEN KİTAPLARI LİSTELEME BUTONU
        private void btnGecikenleriGoster_Click(object sender, EventArgs e)
        {
            // Sadece Durumu 'Gecikmiş' olanları filtrele
            string sorgu = "Select IslemID, AdSoyad, KitapAdi, Durum, TalepTarihi From OduncIslemleri " +
                           "INNER JOIN Kullanicilar ON OduncIslemleri.KullaniciID = Kullanicilar.KullaniciID " +
                           "INNER JOIN Kitaplar ON OduncIslemleri.KitapID = Kitaplar.KitapID " +
                           "WHERE Durum = 'Gecikmiş'";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        // 2. TÜM LİSTEYE GERİ DÖNME BUTONU
        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            TalepleriListele(); // Zaten var olan fonksiyonumuzu çağırıp listeyi sıfırlıyoruz
        }
    }
}