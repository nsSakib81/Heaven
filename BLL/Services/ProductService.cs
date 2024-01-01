using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c=> {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }
        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }
        public static BuyerCommentDTO GetWithReviews(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductCommentDTO>();
                c.CreateMap<BuyerComment, BuyerCommentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BuyerCommentDTO>(data);
            return mapped;
        }

        public static object Create(ProductDTO productDto)
        {
            throw new NotImplementedException();
        }
    }
}
