using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRol
    {
        public int IdUser { get; set; }

        public UserRol Usuarios { get; set;}

        public int IdRol {get; set;}

        public Rol Rols {get; set;}
    }
}