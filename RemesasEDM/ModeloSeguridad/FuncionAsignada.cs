//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemesasEDM.ModeloSeguridad
{
    using System;
    using System.Collections.Generic;
    
    public partial class FuncionAsignada
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public int UsuarioId { get; set; }
        public int FuncionDeAccesoId { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual FuncionDeAcceso FuncionDeAcceso { get; set; }
    }
}