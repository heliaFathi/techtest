﻿using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TechTest01.Services.Interfaces;
using TechTest01.WebApi.Exceptions;

namespace TechTest01.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [CustomExceptionFilter]
    public class ProductsController : ApiController
    {
        private IProductsService _productService;
        public ProductsController(IProductsService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("products")]
        public HttpResponseMessage GetAll()
        {
            var products = _productService.GetAll();

            if (products == null)
            {
                var message = string.Format("There is no product in the catalog");
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, products);
            }
        }

        [HttpGet]
        [Route("products/{slug}")]
        public HttpResponseMessage GetBySlug(string slug)
        {
            var product = _productService.GetBySlug(slug);

            if (product == null)
            {
                var message = string.Format("Product with slug = {0} not found", slug);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
        }

        [HttpGet]
        [Route("products/{id:int}")]
        public HttpResponseMessage GetById(int id)
        {
            var product = _productService.GetById(id);

            if (product == null)
            {
                var message = string.Format("Product with id = {0} not found", id);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
        }

        [HttpGet]
        [Route("~/")]
        public HttpResponseMessage GetRandom(int count = 2)
        {
            var randomProducts = _productService.GetRandom(count);

            if (randomProducts == null)
            {
                var message = string.Format("There is no product in the catalog.");
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, randomProducts);
            }
        }
    }
}