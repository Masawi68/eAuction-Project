using eAuction.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace eAuction.Models
{
    public class Products
    {
        [Key]
        public int LotNumber { get; set; }
        public string ProductPicURL { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string Brand { get; set; }
        public string Discription { get; set; }
        public string Condition { get; set; }
        public double StartBidPrice { get; set; }
    }
}
