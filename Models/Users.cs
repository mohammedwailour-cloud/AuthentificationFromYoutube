using Microsoft.Data.SqlClient;
namespace AuthentificationFromYoutube.Models
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        public void AddUser()
        {
            SqlConnection cn = new SqlConnection("Data source=.\\SQLEXPRESS ; initial catalog = Villes ; integrated security = true; Encrypt=false");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Userss values('" + this.login+ "','"+this.password+"','"+this.nom+"','"+this.prenom+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public bool loginAction()
        {
            SqlConnection cn = new SqlConnection("Data source=.\\SQLEXPRESS ; initial catalog = Villes ; integrated security = true; Encrypt=false");
            cn.Open();
            bool trouve = false;
            SqlCommand cmd = new SqlCommand("select * from Userss where login = '" + this.login + "' and password = '" + this.password + "' ", cn );
            SqlDataReader rd =  cmd.ExecuteReader();
            
            while (rd.Read()) 
            {
                this.nom = rd[3].ToString();
                this.prenom = rd[4].ToString();
                 trouve = true;
            }
            cn.Close();

            return trouve;
        }
    }
}
