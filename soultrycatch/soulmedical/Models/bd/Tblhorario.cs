using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Tblhorario
    {
        public int HorUserid { get; set; }
        public int TraDocumento4 { get; set; }
        public string HorNombre { get; set; } = null!;
        public string HorApellido { get; set; } = null!;
        public DateTime HorLlegada { get; set; }
        public DateTime HorSalida { get; set; }

        public virtual Tbltrabajadore TraDocumento4Navigation { get; set; } = null!;
    }
}
