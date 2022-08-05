using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Tblnomina
    {
        public int Nomid { get; set; }
        public int TraDocumento3 { get; set; }
        public string NomNombre { get; set; } = null!;
        public string NomApellido { get; set; } = null!;
        public double NomSalarioestipulado { get; set; }
        public double NomDeduccionsalario { get; set; }
        public double NomSaludpension { get; set; }
        public double NomCesantias { get; set; }
        public double NomParafiscales { get; set; }
        public DateTime NomInicio { get; set; }
        public DateTime NomFin { get; set; }

        public virtual Tbltrabajadore TraDocumento3Navigation { get; set; } = null!;
    }
}
