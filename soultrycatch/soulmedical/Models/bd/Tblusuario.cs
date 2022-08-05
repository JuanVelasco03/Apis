using System;
using System.Collections.Generic;

namespace soulmedical.Models.bd
{
    public partial class Tblusuario
    {
        public int Userid { get; set; }
        public int TraDocumento2 { get; set; }
        public string Usernombre { get; set; } = null!;
        public string Userapellido { get; set; } = null!;
        public string Useremail { get; set; } = null!;
        public string Userclave { get; set; } = null!;
        public int Idrol { get; set; }

        public virtual Rol IdrolNavigation { get; set; } = null!;
        public virtual Tbltrabajadore TraDocumento2Navigation { get; set; } = null!;
    }
}
