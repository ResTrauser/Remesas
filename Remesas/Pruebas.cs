using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemesasDAO.DAO;
using RemesasDAO.GestionUsuarios;
using RemesasEDM.ModeloApp;
using RemesasEDM.ModeloSeguridad;

namespace Remesas
{
    public class Pruebas
    {
        public ClienteEmisor EnviarEmisor()
        {
            ClienteEmisor emisor = new ClienteEmisor();
            emisor.NombresEmisor = "sandra";
            emisor.Apellido1Emisor = "reyes";
            emisor.DireccionEmisor = "bello amanecer";
            emisor.CodigoEmisor = "Emi345";
            emisor.TelefonoEmisor = 87567898;
            emisor.PaisId = 1;
            emisor.Cedula = "6767854345672Q";
            return emisor;
        }

        public string BuscarEmisor()
        {
            ClienteEmisor emisor = new ClienteEmisor();
            emisor.NombresEmisor = "sandra";
            emisor.Apellido1Emisor = "reyes";
            emisor.DireccionEmisor = "bello amanecer";
            emisor.CodigoEmisor = "Emi345";
            emisor.TelefonoEmisor = 87567898;
            emisor.PaisId = 1;
            emisor.Cedula = "6767854345672Q";
            return emisor.CodigoEmisor;
        }
    }
}
