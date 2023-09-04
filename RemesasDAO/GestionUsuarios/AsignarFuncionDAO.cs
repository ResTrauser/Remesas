using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemesasEDM.ModeloSeguridad;

namespace RemesasDAO.GestionUsuarios
{
    public class AsignarFuncionDAO
    {
        Model1Container1 db = new Model1Container1();
        public bool Agregar(FuncionAsignada asignada)
        {
            db.FuncionAsignada.Add(asignada);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(FuncionAsignada asignada)
        {
            db.FuncionAsignada.Remove(asignada);
            return (db.SaveChanges() > 0 ? true : false);
        }
    }
}
