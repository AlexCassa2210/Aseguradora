//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDAseguradora.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblDetallePersona
    {
        public TblDetallePersona()
        {
            this.TblAdiccionesClientes = new HashSet<TblAdiccionesClientes>();
            this.TblPolizas = new HashSet<TblPolizas>();
            this.TblSeguridad = new HashSet<TblSeguridad>();
            this.TblSeguros = new HashSet<TblSeguros>();
        }
    
        public int ID_DPersona_Dp { get; set; }
        public int Cedula_Dp { get; set; }
        public string Genero_DP { get; set; }
        public System.DateTime Fecha_nacimiento_Dp { get; set; }
        public string Nombre_Dp { get; set; }
        public string Primer_Apellido_Dp { get; set; }
        public string Segundo_Apellido_Dp { get; set; }
        public string Dirección_Física_Dp { get; set; }
        public string Telefono_Principal_Dp { get; set; }
        public string Telefono_Secundario_Dp { get; set; }
        public string Correo_Electrónico_Dp { get; set; }
        public int ID_TipoPersona_Dp { get; set; }
        public Nullable<int> ID_Provincia_Dp { get; set; }
    
        public virtual ICollection<TblAdiccionesClientes> TblAdiccionesClientes { get; set; }
        public virtual TblTipoPersonas TblTipoPersonas { get; set; }
        public virtual ICollection<TblPolizas> TblPolizas { get; set; }
        public virtual ICollection<TblSeguridad> TblSeguridad { get; set; }
        public virtual ICollection<TblSeguros> TblSeguros { get; set; }
        public virtual TblProvincia TblProvincia { get; set; }
    }
}