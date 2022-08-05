using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Rol
    {
        public Rol()
        {
            Tblusuarios = new HashSet<Tblusuario>();
        }

        public int Idrol { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Tblusuario> Tblusuarios { get; set; }
    }
}
