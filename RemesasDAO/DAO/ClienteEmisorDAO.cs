using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class ClienteEmisorDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(ClienteEmisor cle)
        {
            db.ClienteEmisor.Add(cle);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(ClienteEmisor cle)
        {
            db.ClienteEmisor.Remove(cle);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(ClienteEmisor cle)
        {
            db.Entry(cle).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public ClienteEmisor Buscar(string codigo)
        {
            ClienteEmisor cl;
            cl = db.ClienteEmisor.DefaultIfEmpty(null).FirstOrDefault(c => c.CodigoEmisor == codigo);
            return (cl);
        }

        public List<usp_BuscarCliente_Result> ProcBuscarEmisor(string nom, string ape)
        {
            return db.usp_BuscarCliente2(nom, ape).ToList();
        }

        public List<usp_CargarEmisor_Result> ProcCargarEmisor(string nom)
        {
            return db.usp_CargarEmisor2(nom).ToList();
        }

        public List<ClienteEmisor> Listar()
        {
            return (db.ClienteEmisor.ToList());
        }
    }
}
