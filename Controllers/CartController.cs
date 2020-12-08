using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Models;
using CartService.Repositiories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICart _cartRepo;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CartController));
        public CartController(ICart cartRepository)
        {
            _cartRepo = cartRepository;
        }
        // GET: api/Cart
        [HttpGet]
        public IActionResult Get()
        {
            try {
                var u = _cartRepo.GetCart();
                if(u!=null)
                {
                    _log4net.Info("Cart has been accessed");
                    return new OkObjectResult(u);
                }
                else
                {
                    _log4net.Info("Cart is empty");
                    return new OkObjectResult("Cart is empty");
                }

            }
            catch
            {
                _log4net.Error("Error has occurred in getting details");
                return new NoContentResult();
            }
            
        }
        // POST: api/Cart
        [HttpPost]
        public void Post([FromBody] MenuItem value)
        {
            var i = _cartRepo.AddToCart(value);
        }
        
    }
}
