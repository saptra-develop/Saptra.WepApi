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
    
    public partial class mNotificaciones
    {
        public int NotificacionId { get; set; }
        public int EstatusId { get; set; }
        public int TipoNotificacionId { get; set; }
        public int PlanSemanalId { get; set; }
        public int UsuarioId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual cEstatus cEstatus { get; set; }
        public virtual cTipoNotificaciones cTipoNotificaciones { get; set; }
        public virtual mPlanSemanal mPlanSemanal { get; set; }
        public virtual mUsuarios mUsuarios { get; set; }
    }
}
