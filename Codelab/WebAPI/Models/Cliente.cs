using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NomeCLiente { get; set; }
        public string RgCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string BairroCliente { get; set; }
        public string EstadoCliente { get; set; }
        public string CEPCliente { get; set; }
        public DateTime NascimentoCliente { get; set; }
    }
}
