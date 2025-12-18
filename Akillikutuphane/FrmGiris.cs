using Akillikutuphane;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akillikutuphane
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        // Bu değişken sisteme kimin girdiğini hafızada tutacak
        public static int GirisYapanKullaniciID;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kutular boş mu diye bakıyoruz
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurunuz.");
                return;
            }

            // Veritabanına soruyoruz: Böyle bir kullanıcı var mı?
            SqlCommand komut = new SqlCommand("Select * From Kullanicilar where Email=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtEmail.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) // Eğer kayıt bulunduysa
            {
                string rol = dr["Rol"].ToString();
                GirisYapanKullaniciID = int.Parse(dr["KullaniciID"].ToString());

                this.Hide(); // Giriş ekranını gizle

                // Rolüne göre sayfaya yönlendir
                if (rol == "Ogrenci")
                {
                    FrmOgrenci fr = new FrmOgrenci();
                    fr.Show();
                }
                else if (rol == "Personel")
                {
                    FrmPersonel fr = new FrmPersonel();
                    fr.Show();
                }
                else if (rol == "Yonetici")
                {
                    FrmYonetici fr = new FrmYonetici();
                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Hatalı E-Posta veya Şifre!");
            }
            bgl.baglanti().Close();
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayıt ekranını aç
            FrmKayitOl fr = new FrmKayitOl();
            fr.Show();
        }
    }
}