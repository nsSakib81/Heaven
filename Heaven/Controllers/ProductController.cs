using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Heaven.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/products")]

        public HttpResponseMessage Products()
        {
            try
            {
                var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new {Message= ex.Message });
            }
        }
        [HttpPost]
        [Route("api/products")]
        public HttpResponseMessage CreateProduct(ProductDTO productDto)
        {
            try
            {
                // Assuming ProductDTO is a data transfer object representing the product data
                // and you have a ProductService method for creating products
                var createdProduct = ProductService.Create(productDto);

                // Return the created product and a 201 Created status code
                return Request.CreateResponse(HttpStatusCode.Created, createdProduct);
            }
            catch (Exception ex)
            {
                // Return an Internal Server Error status code along with an error message
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage Product(int id)
        {
            try
            {
                var data = ProductService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/products/{id}/reviews")]
        public HttpResponseMessage ProductReviews(int id)
        {
            try
            {
                var data = ProductService.GetWithReviews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
