using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebibOpenDataIO
{
    class TbQualifier
    {
        public int Id { get; set; }
        public string DE { get; set; }
        public string Qualifier { get; set; }
        public double? Version { get; set; }
        public string Lbc1 { get; set; }
        public string Lbc2 { get; set; }
        public string Lbc3 { get; set; }
        public string Lbc4 { get; set; }
        // public DateTime Datcre { get; set; }
        // public DateTime? Datmod { get; set; }
        // public DateTime? Datdel { get; set; } 
    }
}
