﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelNr { get; set; } 
        public string Mail { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}