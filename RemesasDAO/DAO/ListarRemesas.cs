using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemesasDAO.DAO
{
    public class ListarRemesas
    {
        public string Codigo { get; set; }
        public int CodigoRetiro { get; set; }
        public int Estado { get; set; }
        public string DescEstado { get; set; }
    }
}
