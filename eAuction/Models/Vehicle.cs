using eAuction.Data.Enum;
using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace eAuction.Models
{
    public class Vehicle
    {
        [Key]
        public int LotNumber { get; set; }
        public string ProductPicURL { get; set; }
        public VehicleCategory VehicleCategory { get; set; }
        public string Discription { get; set; }
        public DateFormat Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double StartBidPrice { get; set; }
    }
}
