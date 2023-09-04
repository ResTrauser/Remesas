using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RemesasEDM.ModeloApp;
using Remesas.Plantillas;


namespace RemesasDAO.DAO
{
    public class EnvioDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Envio env)
        {
            db.Envio.Add(env);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(Envio env)
        {
            db.Envio.Remove(env);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Envio env)
        {
            db.Entry(env).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public Envio Buscar(string codigo)
        {
            Envio env;
            env = db.Envio.DefaultIfEmpty(null).FirstOrDefault(e => e.CodigoEnvio == codigo);
            return (env);
        }

        public Envio ValidarRetiro(int codigo)
        {
            Envio env;
            env = db.Envio.DefaultIfEmpty(null).FirstOrDefault(e => e.CodigoRetiro == codigo);
            return env;
        }

        public List<usp_BuscarTransaccion_Result> ProcBuscarEnvio(string cod)
        {
            return db.usp_BuscarTransaccion2(cod).ToList();
        }

        public List<ListarRemesas> Listar(int cod)
        {
            List<ListarRemesas> q;
            q = (from e in db.Envio
                 join er in db.EstadoRemesa on e.EstadoRemesaId equals er.Id
                 where (e.CodigoRetiro == cod)
                 select new ListarRemesas
                 {
                     Codigo = e.CodigoEnvio,
                     CodigoRetiro = e.CodigoRetiro,
                     Estado = e.EstadoRemesaId,
                     DescEstado = er.Estado
                 }).ToList();
            return q;
        }

        public List<ListarEnvios> Report()
        {
            List<ListarEnvios> q;
            q = (from e in db.Envio
                 join ce in db.ClienteEmisor on e.ClienteEmisorId equals ce.Id
                 join cr in db.ClienteReceptor on e.ClienteReceptorId equals cr.Id
                 join p in db.Pais on cr.PaisId equals p.Id
                 join tc in db.TipoDeCambio on e.TipoDeCambioId equals tc.Id
                 join m in db.Moneda on tc.MonedaId equals m.Id
                 join er in db.EstadoRemesa on e.EstadoRemesaId equals er.Id
                 where (e.ClienteEmisorId == ce.Id)
                 select new ListarEnvios
                 {
                     CodigoEnvio = e.CodigoEnvio,
                     CodigoRetiro = e.CodigoRetiro,
                     Fecha = e.FechaPago,
                     MontoPagado = e.MontoPagado,
                     Estado = er.Estado,
                     NombreEmi = ce.NombresEmisor + " " + ce.Apellido1Emisor + " " + ce.Apellido2Emisor,
                     NombreRec = cr.NombresReceptor + " " + cr.Apellido1Receptor + " " + ce.Apellido2Emisor,
                     Moneda = m.TipoMoneda,
                     TipoDeCambio = tc.CambioDia,
                     Pais = p.NombrePais
                 }).ToList();
            return q;
        }

        public List<ListarEnvioEmi> ReportCliente(int code)
        {
            List<ListarEnvioEmi> q;
            q = (from e in db.Envio
                 join ce in db.ClienteEmisor on e.ClienteEmisorId equals ce.Id
                 join cr in db.ClienteReceptor on e.ClienteReceptorId equals cr.Id
                 join tc in db.TipoDeCambio on e.TipoDeCambioId equals tc.Id
                 join m in db.Moneda on tc.MonedaId equals m.Id
                 where (e.ClienteEmisorId == code)
                 select new ListarEnvioEmi
                 {
                     CodigoEnvio = e.CodigoEnvio,
                     CodigoRetiro = e.CodigoRetiro,
                     Fecha = e.FechaPago,
                     MontoPagado = e.MontoPagado,
                     Moneda = m.TipoMoneda,
                     NombreEmi = ce.NombresEmisor + " " + ce.Apellido1Emisor + " " + ce.Apellido2Emisor,
                     NombreRec = cr.NombresReceptor + " " + cr.Apellido1Receptor + " " + cr.Apellido2Receptor
                 }).ToList();
            return q;
        }
    }
}
