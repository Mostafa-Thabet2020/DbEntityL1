using DbEntityL1.Base;
using DbEntityL1.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Models
{
    public class Student:Human
    {
        public Nationality nationality { get; set; }
    }
}
