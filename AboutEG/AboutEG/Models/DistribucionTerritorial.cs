

using System;
using System.ComponentModel;

namespace AboutEG.Models
{
    public class DistribucionTerritorial
    {

        [DisplayName("Distribucion")]
        public long Id { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Distintivo")]
        public string Distintivo { get; set; }
        public long Nivel { get; set; }
        public long PadreId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

    }
}