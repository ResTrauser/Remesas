//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemesasEDM.ModeloApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notificaciones
    {
        public int Id { get; set; }
        public string CodigoNotificacion { get; set; }
        public System.DateTime FechaNotificacion { get; set; }
        public int EnvioId { get; set; }
    
        public virtual Envio Envio { get; set; }
    }
}