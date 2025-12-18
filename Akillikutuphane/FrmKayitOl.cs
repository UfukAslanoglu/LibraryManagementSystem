using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akillikutuphane
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // KAYIT OL BUTONU
        private void btnKayit_Click(object sender, EventArgs e)
        {
            // 1. ADIM: Boş alan kontrolü (Senin yazdığın kısım)
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Ad, E-posta ve Şifre alanları boş bırakılamaz.");
                return;
            }

            // 2. ADIM: ŞİFRE KONTROLÜ (Benim verdiğim yeni kısım burası)
            // Regex yerine bu manuel kontrolü koyduk, daha detaylı hata veriyor.

            string parola = txtSifre.Text;
            string hataMesaji = "";
            bool gecerliMi = true;

            if (parola.Length < 8)
            {
                hataMesaji += "- En az 8 karakter olmalı.\n";
                gecerliMi = false;
            }
            if (!ContainsUpperCase(parola))
            {
                hataMesaji += "- En az bir BÜYÜK harf içermeli.\n";
                gecerliMi = false;
            }
            if (!ContainsLowerCase(parola))
            {
                hataMesaji += "- En az bir küçük harf içermeli.\n";
                gecerliMi = false;
            }
            if (!ContainsDigit(parola))
            {
                hataMesaji += "- En az bir rakam (0-9) içermeli.\n";
                gecerliMi = false;
            }

            // Eğer şifre hatalıysa mesajı göster ve dur
            if (gecerliMi == false)
            {
                MessageBox.Show("Şifreniz şu kurallara uymuyor:\n" + hataMesaji, "Güvenlik Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. ADIM: VERİTABANINA KAYIT (Senin kodların aynen devam ediyor)
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Kullanicilar (AdSoyad, Email, Sifre, Telefon, OkulNo, Rol) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtEmail.Text);
                komut.Parameters.AddWithValue("@p3", txtSifre.Text);
                komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p5", txtOkulNo.Text);
                komut.Parameters.AddWithValue("@p6", "Ogrenci");

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Başarılı! Giriş yapabilirsiniz.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- YARDIMCI KODLAR (En alta, parantezlerin arasına ekledik) ---

        // Büyük harf kontrolü yapan yardımcı
        private bool ContainsUpperCase(string s)
        {
            foreach (char c in s)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        // Küçük harf kontrolü yapan yardımcı
        private bool ContainsLowerCase(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }

        // Rakam kontrolü yapan yardımcı
        private bool ContainsDigit(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

    }
}