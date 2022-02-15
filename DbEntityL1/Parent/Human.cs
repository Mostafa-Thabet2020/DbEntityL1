using DbEntityL1.Base;
using DbEntityL1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Parent
{
    //[NotMapped]
    public class Human:Audit
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
       
    }

}
