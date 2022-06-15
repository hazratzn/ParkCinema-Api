using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Navbar> Navbars { get; set; }
        public ICollection<Footer> Footers { get; set; }
        public ICollection<Hall> Halls { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
