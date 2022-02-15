using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Base
{
    public class Audit:Base
    {
        public Audit()//constractor , function that called automaticly after class called
        {
            LastModified=DateTime.Now;
        }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
