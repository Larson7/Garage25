using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
 
namespace Garage2.Models
{
   
    
    public class Vehicle
    {
        
        public int VehicleId { get; set; }
        public int MemberId { get; set; }

        [Required]
        public TypeVehicle TypeVehicle { get; set; }

        [StringLength(10,MinimumLength=4)]
        [Required]
        public string RegNr { get; set; }

       

        [Required]
        public string Color { get; set; }

       
      
        public DateTime? CheckInTime { get; set; }
 //       public int ParkSpace { get; set; }
    
        public int ParkNr { get; set; }

    }
}