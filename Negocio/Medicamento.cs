using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Medicamento
    {
        public String Nome { get; set; }
        public String Tarja { get; set; }
        public String Via { get; set; }
        public String Efeitos { get; set; }
        public String Lote { get; set; }
        public String Frequencia { get; set; }
        public DateTime Fabricacao { get; set; }
        public DateTime Validade { get; set; }
        public Int64 Quantidade { get; set; }
        public Int64 Ml { get; set; }
    }
}
