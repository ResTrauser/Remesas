using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;
using RemesasDAO.Plantillas;

namespace RemesasDAO.DAO
{
    public class MonedaDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Moneda mon)
        {
            db.Moneda.Add(mon);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(Moneda mon)
        {
            db.Moneda.Remove(mon);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Moneda mon)
        {
            db.Entry(mon).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public Moneda Buscar(int codigo)
        {
            Moneda mon;
            mon = db.Moneda.DefaultIfEmpty(null).FirstOrDefault(m => m.Id == codigo);
            return (mon);
        }

        public List<Moneda> Listar()
        {
            return (db.Moneda.ToList());
        }

        public List<Monedas> Reporte()
        {
            List<Monedas> q;
            q = (from t in db.TipoDeCambio
                 join m in db.Moneda on t.MonedaId equals m.Id
                 where (t.MonedaId == m.Id)
                 select new Monedas
                 {
                     TipoMoneda= m.TipoMoneda,
                     Cambio= t.CambioDia,
                     Fecha = t.FechaTipoCambio
                 }).ToList();
            return q;
        }
    }
}
