using Microsoft.Data.SqlClient;

namespace AuthentificationFromYoutube.Models
{
    public class Villes
    {
        public int id { get; set; } 
        public string Libelle { get; set; }

        public void Add()
        {
            SqlConnection cn = new SqlConnection("Data source=.\\SQLEXPRESS ; initial catalog = Villes ; integrated security = true; Encrypt=false");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Villes values('" + this.Libelle + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
