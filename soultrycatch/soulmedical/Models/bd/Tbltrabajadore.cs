using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Tbltrabajadore
    {
        public Tbltrabajadore()
        {
            Tblhorarios = new HashSet<Tblhorario>();
            Tblnominas = new HashSet<Tblnomina>();
            Tblusuarios = new HashSet<Tblusuario>();
            Tblvacaciones = new HashSet<Tblvacacione>();
        }

        public int TraDocumento { get; set; }
        public int Id { get; set; }
        public string TraNombre { get; set; } = null!;
        public string TraApellido { get; set; } = null!;
        public string TraDireccion { get; set; } = null!;
        public string TraCelular { get; set; } = null!;
        public string TraEmail { get; set; } = null!;
        public DateTime TraFechaNacimiento { get; set; }
        public string TraCodigocuenta { get; set; } = null!;
        public int TraEdad { get; set; } 

        public virtual ICollection<Tblhorario> Tblhorarios { get; set; }
        public virtual ICollection<Tblnomina> Tblnominas { get; set; }
        public virtual ICollection<Tblusuario> Tblusuarios { get; set; }
        public virtual ICollection<Tblvacacione> Tblvacaciones { get; set; }
    }
}
