﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Course : Iinformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public string GetBasicInformation()
        {
            return $"{Code} {Name} {Credits}";
        }
    }
}
