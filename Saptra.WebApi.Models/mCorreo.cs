//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Saptra.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mCorreo
    {
        public int CorreoId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int EstatusId { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Puerto { get; set; }
        public string Host { get; set; }
        public Nullable<int> TipoCorreoId { get; set; }
    
        public virtual cEstatus cEstatus { get; set; }
        public virtual cTipoCorreo cTipoCorreo { get; set; }
    }
}
