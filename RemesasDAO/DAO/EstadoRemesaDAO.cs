using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class EstadoRemesaDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(EstadoRemesa erm)
        {
            db.EstadoRemesa.Add(erm);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(EstadoRemesa erm)
        {
            db.EstadoRemesa.Remove(erm);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(EstadoRemesa erm)
        {
            db.Entry(erm).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public EstadoRemesa Buscar(string codigo)
        {
            EstadoRemesa erm;
            erm = db.EstadoRemesa.DefaultIfEmpty(null).FirstOrDefault(e => e.CodigoEstadoRemesa == codigo);
            return (erm);
        }

        public List<EstadoRemesa> Listar()
        {
            return (db.EstadoRemesa.ToList());
        }
    }
}
