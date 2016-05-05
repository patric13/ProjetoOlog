using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceOlog
{
    public class LoginController
    {

        private banco db = new banco();

        public bool BuscarLogin(string usuario, string senha)
        {
            string SQL = "select * from usuario where login = '" + usuario + "' and senha = '" + senha + "'";

           return  db.Buscardados(SQL).HasRows;
        }
    }
}