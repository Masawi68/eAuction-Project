using eAuction.Data.Enum;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace eAuction.Models
{
    public class Services
    {
        [Key]
        public int LotNumber { get; set; }
        public string ProductPicURL { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public string Discription { get; set; }
        public DateFormat YearsOfExpirience { get; set; }
        public double StartBidPrice { get; set; }
    }
}
