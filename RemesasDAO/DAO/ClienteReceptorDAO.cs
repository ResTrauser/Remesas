using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class ClienteReceptorDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(ClienteReceptor clr)
        {
            db.ClienteReceptor.Add(clr);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(ClienteReceptor clr)
        {
            db.ClienteReceptor.Remove(clr);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(ClienteReceptor clr)
        {
            db.Entry(clr).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public ClienteReceptor Buscar(string codigo)
        {
            ClienteReceptor clr;
            clr = db.ClienteReceptor.DefaultIfEmpty(null).FirstOrDefault(c => c.CodigoReceptor == codigo);
            return (clr);
        }

        public List<usp_BuscarClienteReceptor_Result> ProcBuscarReceptor(string nom, string ape)
        {
            return db.usp_BuscarClienteReceptor2(nom, ape).ToList();
        }

        public List<usp_CargarReceptor_Result> ProcCargarReceptor(string nom)
        {
            return db.usp_CargarReceptor2(nom).ToList();
        }
    }
}
