using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BuyerComment
    {
        public int id { get; set; }
        [Required]
        public string BuyerReview{get; set;}
        public DateTime Time { get; set; }
        [ForeignKey("Seller")]
        public string ReviewedBy { get; set; }
        [ForeignKey("Product")]
        public int PId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
