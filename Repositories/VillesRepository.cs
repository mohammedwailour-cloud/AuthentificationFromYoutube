using AuthentificationFromYoutube.Models;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace AuthentificationFromYoutube.Repositories
{
    public class VillesRepository : IVillesRepository
    {
        IConfiguration conf;
        public VillesRepository(IConfiguration conf) 
        {
            this.conf = conf;
        }
        public void Add(Villes ville)
        {
            SqlConnection cn = new SqlConnection(conf.GetConnectionString("ehei"));
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Villes values('" + ville.Libelle + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
