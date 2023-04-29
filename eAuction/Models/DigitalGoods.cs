using eAuction.Data.Enum;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace eAuction.Models
{
    public class DigitalGoods
    {
        [Key]
        public int LotNumber { get; set; }
        public string ProductPicURL { get; set; }
        public DigitalCategory DigitalCategory { get; set; }
        public string Discription { get; set; }
        public string Condition { get; set; }
        public double StartBidPrice { get; set; }
    }
}

