using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceOlog
{
    /// <summary>
    /// Summary description for WebServiceLogin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLogin : System.Web.Services.WebService
    {
        LoginController lgController = new LoginController();

        [WebMethod]
        public Boolean realizarLogin(String usuario, String senha,ref string chave)
           {

            return lgController.BuscarLogin(usuario,senha); 
                
        }
    }
}
