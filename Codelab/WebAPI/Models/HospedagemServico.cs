using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class HospedagemServico
    {
        public int CodHospedagem { get; set; }
        public DateTime DataServico { get; set; }
        public int CodServico { get; set; }
    }
}
