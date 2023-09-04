using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class PaisDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Pais pais)
        {
            db.Pais.Add(pais);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(Pais pais)
        {
            db.Pais.Remove(pais);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Pais pais)
        {
            db.Entry(pais).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public Pais Buscar(string codigo)
        {
            Pais pais;
           pais = db.Pais.DefaultIfEmpty(null).FirstOrDefault(p => p.CodigoPais == codigo);
            return (pais);
        }

        public List<Pais> Listar()
        {
            return (db.Pais.ToList());
        }
    }
}
