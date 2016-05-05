using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceOlog
{
    public class banco
    {
        NpgsqlConnection con;

        private const  string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=roupa;";

        public banco()
        {
            con = new NpgsqlConnection(connstring);
        }

        ~banco()
        {
            FecharConexao();
        }

        private void AbrirConexao()
        {
            con.Open();
        }

        private void FecharConexao()
        {
            con.Close();
            
        }

        public NpgsqlDataReader Buscardados(string sql)
        {
            AbrirConexao();
            NpgsqlCommand reader = new NpgsqlCommand(sql, con);

            NpgsqlDataReader result = reader.ExecuteReader();
            
            return result;
        }

        public void ExecutarSQL(string sql)
        {
            AbrirConexao();
            NpgsqlCommand reader = new NpgsqlCommand(sql, con);
            reader.ExecuteNonQuery();
            FecharConexao();

        }

    }
}