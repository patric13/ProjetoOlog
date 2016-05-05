using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string login{ get; set; }
        public string senha { get; set; }
        public string descricao { get; set; }
        public string email { get; set; }


        }
}