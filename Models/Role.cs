using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizarreStatusServer.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int HitPoints { get; set; }
        public int MagicPoints { get; set; }
    }
}
