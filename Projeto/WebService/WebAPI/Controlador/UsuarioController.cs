using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebServiceOlog
{
    public class UsuarioController
    {

        private banco db = new banco();

        public List<Usuario> BuscarLogin()
        {
           List< Usuario> result = new List<Usuario>();
            Usuario u;
            string SQL = "select id,login,senha,descricao,email from usuario order by id asc";

            NpgsqlDataReader reader = db.Buscardados(SQL);
            
            while (reader.Read())
            {
                u = new Usuario();
                u.id = reader.GetInt32(0);
                u.login = reader.GetValue(1).ToString();
                u.senha = reader.GetValue(2).ToString();
                u.descricao = reader.GetValue(3).ToString();
                u.email = reader.GetValue(4).ToString();

                result.Add(u);
            }

           return  result;
        }
    }
}