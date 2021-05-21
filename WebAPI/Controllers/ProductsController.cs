using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //bu isteği yaparken link api/controlleradi şeklinde olsun örn api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled gevşek bağlılık
        //IoC Containe --Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //return new List<Product>
            //{
            //    new Product { ProductId=1,ProductName="Elma"},
            //    new Product { ProductId=2,ProductName="Armut"}
            //};
            
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
