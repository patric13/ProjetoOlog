using ProjetoOlog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ProjetoOlog.Controller
{
   public  class ControladorLogin
    {
        Usuario user = new Usuario();
        Conexao conec = new Conexao();
        public bool RealizarLogin(string usuario, string senha) {
            return true;

        }
    }
}
