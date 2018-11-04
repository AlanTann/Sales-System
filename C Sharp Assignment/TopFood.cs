using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class TopFood
    {
        public string productName { get; set; }
        public string productType { get; set; }
        public double productDiscount { get; set; }
        public decimal productOriginalPrice { get; set; }
        public decimal productGSTCharge { get; set; }
        public decimal productSalePrice { get; set; }

        public TopFood(string name)
        {
            productName = name;
        }

        public TopFood(string name,string type)
        {
            productName = name;
            productType = type;
        }

        public TopFood(string name, string type,double discount, decimal originalPrice
                , decimal gstCharge, decimal salePrice)
        {
            productName = name;
            productType = type;
            productDiscount = discount;
            productOriginalPrice = originalPrice;
            productGSTCharge = gstCharge;
            productSalePrice = salePrice; //Original Price + Profit
        }
    }
}
