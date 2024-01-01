using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Product, int, bool> ProductData()
        {
            return new ProductRepo();
        }
        public static IRepo<BuyerComment, int, bool> BuyerCommentData()
        {
            return new BuyerCommentRepo();
        }
        public static IRepo<Seller,string,Seller> SellerData()
        {
            return new SellerRepo();
        }
    }
}
