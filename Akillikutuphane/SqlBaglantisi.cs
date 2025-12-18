using System.Data.SqlClient;

namespace Akillikutuphane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            // Senin bilgisayarının adı ASUS olduğu için bunu kullanmalısın.
            // Nokta (.) koyunca senin bilgisayarın anlamıyor.
            SqlConnection baglan = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=AkilliKutuphaneDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}