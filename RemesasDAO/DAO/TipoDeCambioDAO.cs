using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class TipoDeCambioDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(TipoDeCambio tp)
        {
            db.TipoDeCambio.Add(tp);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TipoDeCambio tp)
        {
            db.TipoDeCambio.Remove(tp);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TipoDeCambio tp)
        {
            db.Entry(tp).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TipoDeCambio Buscar(string codigo)
        {
            TipoDeCambio tp;
           tp = db.TipoDeCambio.DefaultIfEmpty(null).FirstOrDefault(t => t.CodigoTipoCambio == codigo);
            return (tp);
        }

        public List<usp_BuscarMoneda_Result> ProcBuscarMoneda(string nom)
        {
            return db.usp_BuscarMoneda2(nom).ToList();
        }
    }
}
