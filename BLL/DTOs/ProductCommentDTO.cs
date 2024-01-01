using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductCommentDTO : ProductDTO
    {
        public List<BuyerCommentDTO> BuyersComments { get; set; }
        public ProductCommentDTO()
        {
            BuyersComments = new List<BuyerCommentDTO>();
        }
    }
}
