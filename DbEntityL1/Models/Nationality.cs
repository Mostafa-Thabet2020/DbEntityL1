using DbEntityL1.Base;
using DbEntityL1.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Models
{
    public class Nationality:Audit
    {
        public string Name { get; set; }
        public List<Teachers> teachers { get; set; }
        public List<Student> students { get; set; }
    }
}
