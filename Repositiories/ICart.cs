using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Models;

namespace CartService.Repositiories
{
    public interface ICart
    {
        public List<MenuItem> GetCart();
        public int AddToCart(MenuItem m);
    }
}
