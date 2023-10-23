using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public int IdUser { get; set; }
        public User Users { get; set; }
        public string Token { get; set; }
        public DateTime Expires {get; set;}

        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created {get; set;}
        public DateTime? Revoked {get; set;}

        public bool IsActive => Revoked == null && !IsExpired;
    }
}