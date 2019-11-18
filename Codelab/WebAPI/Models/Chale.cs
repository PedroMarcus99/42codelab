using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Chale
    {
        public int CodChale { get; set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; set; }
        public  decimal ValorAltaEstacao { get; set; }
        public decimal ValorBaixaEstacao { get; set; }
    }
}
