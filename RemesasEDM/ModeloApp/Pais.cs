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
    
    public partial class Pais
    {
        public Pais()
        {
            this.ClienteEmisor = new HashSet<ClienteEmisor>();
            this.ClienteReceptor = new HashSet<ClienteReceptor>();
        }
    
        public int Id { get; set; }
        public string CodigoPais { get; set; }
        public string NombrePais { get; set; }
    
        public virtual ICollection<ClienteEmisor> ClienteEmisor { get; set; }
        public virtual ICollection<ClienteReceptor> ClienteReceptor { get; set; }
    }
}