using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class tempProductRec :TopFood
    {
        public int productQuantity { get; set; }
        public decimal totalProductPrice;

        public tempProductRec(string name, int quantity) : base(name)
        {
            productQuantity = quantity;
        }

        public tempProductRec(string name, string type, int quantity, double discount, decimal originalPrice
        , decimal gstCharge, decimal salePrice) : base(name, type, discount, originalPrice
                , gstCharge, salePrice)
        {
            productQuantity = quantity;
        }

        public decimal TotalProductPrice
        {
            get { return totalProductPrice = productSalePrice*productQuantity; }
            set { totalProductPrice = value; }
        }

    }
}
