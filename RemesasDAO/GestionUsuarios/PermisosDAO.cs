using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemesasEDM.ModeloSeguridad;

namespace RemesasDAO.GestionUsuarios
{
    public class PermisosDAO
    {
        Model1Container1 db = new Model1Container1();
        public bool Agregar(FuncionDeAcceso permiso)
        {
            db.FuncionDeAcceso.Add(permiso);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public FuncionDeAcceso Buscar(string cod)
        {
            FuncionDeAcceso acceso;
            acceso = db.FuncionDeAcceso.DefaultIfEmpty(null).FirstOrDefault(a => a.Codigo == cod);
            return acceso;
        }

        public List<FuncionDeAcceso> Listar()
        {
            return (db.FuncionDeAcceso.ToList());
        }
    }
}
