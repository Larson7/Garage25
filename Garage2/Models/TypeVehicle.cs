using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class TypeVehicle
    {
        public int TypeVehicleId { get; set; }
        public string VType { get; set; }
        public string Brand { get; set; }
        public string ProdName { get; set; }

        [Range(0, 9999)]
        public int Wheels { get; set; }
    }
}