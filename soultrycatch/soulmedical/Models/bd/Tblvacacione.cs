using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Tblvacacione
    {
        public int Vacid { get; set; }
        public int TraDocumento5 { get; set; }
        public string VacNombre { get; set; } = null!;
        public string VacApellido { get; set; } = null!;
        public int VacDiasnormales { get; set; }
        public int VacDiasadicionales { get; set; }
        public int VacDiastotales { get; set; }
        public DateTime VacInicio { get; set; }
        public DateTime VacFin { get; set; }

        public virtual Tbltrabajadore TraDocumento5Navigation { get; set; } = null!;
    }
}
