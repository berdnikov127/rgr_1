﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR.Models
{
    public class Grid
    {
        public Grid(string c1, string c2, string c3)
        {
            Column1 = c1;
            Column2 = c2;
            Column3 = c3;
        }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
 


    }
}
