﻿using DbEntityL1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Models
{
    public class Book:Audit
    {
        public string Name { get; set; }
        public string Descriptation { get; set; }
    }
}
