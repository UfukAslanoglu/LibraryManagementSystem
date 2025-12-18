using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akillikutuphane
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void KitaplariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Kitaplar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            lblListeDurumu.Text = "Görüntülenen: KİTAPLAR";
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            KitaplariGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Kitaplar (KitapAdi,Yazar,Kategori,RafBilgisi,StokAdeti) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
                komut.Parameters.AddWithValue("@p2", txtYazar.Text);
                komut.Parameters.AddWithValue("@p3", txtKategori.Text);
                komut.Parameters.AddWithValue("@p4", txtSayfa.Text); // Raf bilgisi veya Sayfa olarak kullandık
                komut.Parameters.AddWithValue("@p5", txtStok.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kitap Sisteme Eklendi!");
                KitaplariGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullanıcıya soralım, yanlışlıkla basmasın
                DialogResult cevap = MessageBox.Show("Bu kitabı silerseniz, bu kitaba ait tüm ÖDÜNÇ GEÇMİŞİ de silinecektir. Devam edilsin mi?", "Kritik Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        string id = dataGridView1.SelectedRows[0].Cells["KitapID"].Value.ToString();

                        // 1. ADIM: Önce 'OduncIslemleri' tablosundaki kayıtları siliyoruz (Engeli kaldırıyoruz)
                        SqlCommand komutGecmis = new SqlCommand("Delete From OduncIslemleri where KitapID=@p1", bgl.baglanti());
                        komutGecmis.Parameters.AddWithValue("@p1", id);
                        komutGecmis.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        // 2. ADIM: Artık kitabı 'Kitaplar' tablosundan silebiliriz
                        SqlCommand komutKitap = new SqlCommand("Delete From Kitaplar where KitapID=@p1", bgl.baglanti());
                        komutKitap.Parameters.AddWithValue("@p1", id);
                        komutKitap.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        MessageBox.Show("Kitap ve geçmişi başarıyla silindi.");
                        KitaplariGetir(); // Listeyi yenile
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silinecek bir kitap seçiniz.");
            }
        }

        // Mevcut kodlarının altına, en alttaki parantezden önce ekle:

        // 1. ÜYELERİ LİSTELEME BUTONU
        private void btnUyeleriListele_Click(object sender, EventArgs e)
        {
            // Kullanıcıları (Şifreleri hariç) çekelim
            SqlDataAdapter da = new SqlDataAdapter("Select KullaniciID, AdSoyad, Email, Telefon, Rol, OkulNo From Kullanicilar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            lblListeDurumu.Text = "Görüntülenen: ÜYELER"; // Hangi listedeyiz bilelim
        }

        // 2. ÜYE SİLME BUTONU
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            // Eğer listede şu an kitaplar varsa, üye silmeye çalışmasın
            if (lblListeDurumu.Text != "Görüntülenen: ÜYELER")
            {
                MessageBox.Show("Lütfen önce Üyeleri Listeleyiniz!");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırdan ID'yi al
                string id = dataGridView1.SelectedRows[0].Cells["KullaniciID"].Value.ToString();
                string rol = dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString();

                // Admin kendini silemesin :)
                if (rol == "Yonetici")
                {
                    MessageBox.Show("Yönetici hesabı silinemez!");
                    return;
                }

                DialogResult cevap = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);

                if (cevap == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete From Kullanicilar where KullaniciID=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kullanıcı Silindi.");

                    // Listeyi yenile (Butona sanal tıklama yapıyoruz)
                    btnUyeleriListele_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçiniz.");
            }
        }
        // Tablodan bir satıra tıklayınca bilgileri kutulara taşı
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sadece Kitaplar listesi açıkken çalışsın
            if (lblListeDurumu.Text == "Görüntülenen: KİTAPLAR")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                lblGizliID.Text = dataGridView1.Rows[secilen].Cells["KitapID"].Value.ToString();
                txtKitapAd.Text = dataGridView1.Rows[secilen].Cells["KitapAdi"].Value.ToString();
                txtYazar.Text = dataGridView1.Rows[secilen].Cells["Yazar"].Value.ToString();
                txtKategori.Text = dataGridView1.Rows[secilen].Cells["Kategori"].Value.ToString();
                txtSayfa.Text = dataGridView1.Rows[secilen].Cells["RafBilgisi"].Value.ToString(); // Senin tasarımda Sayfa/Raf hangisiyse
                txtStok.Text = dataGridView1.Rows[secilen].Cells["StokAdeti"].Value.ToString();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lblGizliID.Text == "-" || lblGizliID.Text == "")
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir kitap seçin.");
                return;
            }

            try
            {
                SqlCommand komut = new SqlCommand("Update Kitaplar Set KitapAdi=@p1, Yazar=@p2, Kategori=@p3, RafBilgisi=@p4, StokAdeti=@p5 where KitapID=@p6", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
                komut.Parameters.AddWithValue("@p2", txtYazar.Text);
                komut.Parameters.AddWithValue("@p3", txtKategori.Text);
                komut.Parameters.AddWithValue("@p4", txtSayfa.Text); // Raf Bilgisi
                komut.Parameters.AddWithValue("@p5", txtStok.Text);
                komut.Parameters.AddWithValue("@p6", lblGizliID.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kitap Bilgileri Güncellendi!");
                KitaplariGetir(); // Listeyi yenile

                // Temizlik
                lblGizliID.Text = "-";
                txtKitapAd.Text = "";
                // Diğerlerini de temizleyebilirsin...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnEnCokOkunan_Click(object sender, EventArgs e)
        {
            // Bu SQL sorgusu, en çok ödünç alınan kitapları sayar ve sıralar
            string sorgu = "SELECT TOP 5 KitapAdi, Yazar, Count(*) as OkunmaSayisi " +
                           "FROM OduncIslemleri " +
                           "INNER JOIN Kitaplar ON OduncIslemleri.KitapID = Kitaplar.KitapID " +
                           "GROUP BY KitapAdi, Yazar " +
                           "ORDER BY OkunmaSayisi DESC";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            lblListeDurumu.Text = "RAPOR: EN ÇOK OKUNANLAR";
        }
        // SEÇİLEN ÜYEYİ PERSONEL YAPMA BUTONU (Rol Değiştirme)
        private void btnPersonelYap_Click(object sender, EventArgs e)
        {
            // Önce listede üyelerin açık olduğundan emin olalım
            if (lblListeDurumu.Text != "Görüntülenen: ÜYELER")
            {
                MessageBox.Show("Lütfen önce Üyeleri Listeleyiniz!");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["KullaniciID"].Value.ToString();
                string ad = dataGridView1.SelectedRows[0].Cells["AdSoyad"].Value.ToString();

                DialogResult cevap = MessageBox.Show(ad + " isimli üyeyi 'PERSONEL' yetkisine yükseltmek istiyor musunuz?", "Rol Değişikliği", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        // Rolü 'Personel' olarak güncelle
                        SqlCommand komut = new SqlCommand("Update Kullanicilar Set Rol='Personel' Where KullaniciID=@p1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", id);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();

                        MessageBox.Show(ad + " artık bir Kütüphane Personeli.");
                        btnUyeleriListele_Click(null, null); // Listeyi yenile
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir üye seçiniz.");
            }
        }
    }
}