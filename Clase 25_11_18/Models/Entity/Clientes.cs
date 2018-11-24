namespace Clase_25_11_18.Models.Intity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [Key]
        public int IClienteId { get; set; }

        [StringLength(25)]
        [Display(Name ="Nombre")]
        public string VNombre { get; set; }

        [StringLength(50)]
        [Display(Name = "Direccion")]
        public string VDireccion { get; set; }

        [StringLength(11)]
        [Display(Name = "RUC")]
        public string VRUC { get; set; }

        [StringLength(12)]
        [Display(Name = "Telefono")]
        public string VTelefono { get; set; }
    }
}
