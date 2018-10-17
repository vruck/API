using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class ProdutosModel
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public Nullable<decimal> valor { get; set; }
    }
}