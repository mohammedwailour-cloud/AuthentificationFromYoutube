using Microsoft.Data.SqlClient;
using System.Configuration;
using AuthentificationFromYoutube.Models;

namespace AuthentificationFromYoutube.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        IConfiguration conf;
        public UsersRepository(IConfiguration conf)
        {
            this.conf = conf;
        }
        public void AddUser(Users c)
        {
            SqlConnection cn = new SqlConnection(conf.GetConnectionString("ehei"));
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into Userss values('" + c.login + "','" + c.password + "','" + c.nom + "','" + c.prenom + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public bool loginAction(Users c)
        {
            SqlConnection cn = new SqlConnection(conf.GetConnectionString("ehei"));
            cn.Open();
            bool trouve = false;
            SqlCommand cmd = new SqlCommand("select * from Userss where login = '" + c.login + "' and password = '" + c.password + "' ", cn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                c.nom = rd[3].ToString();
                c.prenom = rd[4].ToString();
                trouve = true;
            }
            cn.Close();

            return trouve;
        }




    }
}
