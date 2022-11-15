using System;
using System.Collections.Generic;
using System.Net;
using AluraMusicAPIRest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AluraMusicAPIRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AluraMusicController : ControllerBase
    {
        private readonly IProductService _serviceProduct;
        public AluraMusicController(IProductService serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Get()
        {
            return Ok(_serviceProduct.GetProdutos());
            
        }
    }
}
