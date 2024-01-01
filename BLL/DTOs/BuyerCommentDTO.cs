using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BuyerCommentDTO
    {
        public int id { get; set; }
        [Required]
        public string BuyerReview { get; set; }
        public DateTime Time { get; set; }
        public string ReviewedBy { get; set; }
        public int PId { get; set; }
        
    }
}
