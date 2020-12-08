using CartService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartService.Repositiories
{
    public class CartRepo : ICart
    {
        static List<MenuItem> _cart = new List<MenuItem>();

        public int AddToCart(MenuItem m)
        {
            try
            {
                _cart.Add(m);
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }
        public List<MenuItem> GetCart()
        {
            return _cart.ToList();
        }
    }
}
