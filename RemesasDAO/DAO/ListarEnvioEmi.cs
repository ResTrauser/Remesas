using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasDAO.DAO
{
    public class ListarEnvioEmi
    {
        public string CodigoEnvio { get; set; }
        public int CodigoRetiro { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoPagado { get; set; }
        public string NombreEmi { get; set; }
        public string NombreRec { get; set; }
        public string Moneda { get; set; }
    }
}
