using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Servico
    {
        public int CodServico { get; set; }
        public string NomeServico { get; set; }
        public decimal ValorServico { get; set; }
    }
}
