using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Hospedagem
    {
        public int CodHospedagem { get; set; }
        public int CodChale { get; set; }
        public string Estado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int QtdPessoas { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
