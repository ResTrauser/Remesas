using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;

namespace RemesasDAO.DAO
{
    public class NotificacionesDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Notificaciones noti)
        {
            db.Notificaciones.Add(noti);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(Notificaciones noti)
        {
            db.Notificaciones.Remove(noti);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Notificaciones noti)
        {
            db.Entry(noti).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public Notificaciones Buscar(string codigo)
        {
            Notificaciones noti;
            noti = db.Notificaciones.DefaultIfEmpty(null).FirstOrDefault(n => n.CodigoNotificacion == codigo);
            return (noti);
        }
    }
}
