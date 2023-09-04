using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemesasEDM.ModeloSeguridad;

namespace RemesasDAO.GestionUsuarios
{
    public class UsuarioDAO
    {
        Model1Container1 db = new Model1Container1();

        public bool CrearUsuario(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public Usuario Buscar(string nom)
        {
            Usuario usuario;
            usuario = db.Usuario.DefaultIfEmpty(null).FirstOrDefault(u => u.NombreUsuario == nom);
            return usuario;
        }

        public bool Eliminar(Usuario usuario)
        {
            db.Usuario.Remove(usuario);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public List<Usuario> Listar()
        {
            return db.Usuario.ToList();
        }

        public bool VerificarPermiso(int idusuario,int idfuncion)
        {
            var q = (from f in db.FuncionDeAcceso
                     join fu in db.FuncionAsignada on f.Id equals fu.FuncionDeAccesoId
                     where fu.UsuarioId == idusuario && fu.FuncionDeAccesoId == idfuncion && fu.FechaVencimiento >= DateTime.Now
                     select f).ToList();
            return q.Count > 0 ? true : false;
        }
    }
}
