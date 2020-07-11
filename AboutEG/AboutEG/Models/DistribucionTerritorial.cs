

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AboutEG.Models
{
    public class DistribucionTerritorial
    {
        public enum tipoGeografia
        {
            [Display(Name = "Pais")]
            Pais,
            [Display(Name = "Region")]
            Region,
            [Display(Name = "Provincia")]
            Provincia,
            [Display(Name = "Distrito")]
            Distrito,
            [Display(Name = "Municipio")]
            Municipio,
            [Display(Name = "Distrito Urbano")]
            DistritoUrbano,

            [Display(Name = "Consejo Poblado")]
            ConsejoPoblado,
            [Display(Name = "Comunidad Vecinos")]
            ComunidadVecinos,
        }

    

        [DisplayName("Distribucion")]
        public long Id { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Distintivo")]
        public string Distintivo { get; set; }
        [DisplayName("Tipo")]
        public tipoGeografia Tipo { get; set; }
        [DisplayName("Nivel")]
        public long? Nivel { get; set; }
        [DisplayName("Padre ID")]
        public long? PadreId { get; set; }
        [DisplayName("Fecha Ingreso")]
        public DateTime? FechaIngreso { get; set; }
        [DisplayName("Fecha Últ. Modif.")]
        public DateTime? FechaUltimaModificacion { get; set; }
        [DisplayName("Padre")]
        public virtual DistribucionTerritorial Parent { get; set; }


    }
}