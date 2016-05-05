using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOlog.Model
{
    public class Usuario
    {
        public string email { get; set; }
        public string senha { get; set; }

        public Usuario(String email, String senha)
        {
            this.email = email;
            this.senha = senha;
            

        }
        public Usuario()
        {

        }

    }
}
