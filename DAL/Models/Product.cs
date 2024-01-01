using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Prize { get; set; }
        [ForeignKey("Seller")]
        public string PostedBy { get; set; }

        public DateTime Date { get; set; }
        public virtual Seller Seller { get; set; }

        public virtual ICollection<BuyerComment> BuyersComments { get; set; }
        public Product()
        {
            BuyersComments = new List<BuyerComment>();
        }

        
    }
}
