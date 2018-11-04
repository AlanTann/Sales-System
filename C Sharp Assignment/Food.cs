using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class Food :TopFood
    {
        public int productQuantity { get; set; }

        public Food(string name, string type, int quantity, double discount, decimal originalPrice
                , decimal gstCharge, decimal salePrice) : base( name,  type,  discount,  originalPrice
                ,  gstCharge,  salePrice)
        {
            productQuantity = quantity;
        }
    }
}
