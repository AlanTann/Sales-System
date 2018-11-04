using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class TotalProductSale :TopFood
    {
        public int productQuantityLeft { get; set; }
        public decimal totalQuantitySale { get; set; }
        public decimal totalPriceOriginal { get; set; }
        public decimal totalPriceSale { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal totalGstCollect { get; set; }
        public decimal totalProfit{ get; set; }

        public TotalProductSale(string name) :base(name)
        {
            totalQuantitySale = 0;
        }

        public TotalProductSale(string name, int tQuantitySale) : base(name)
        {
            productName = name;
            totalQuantitySale = tQuantitySale;
        }

        public TotalProductSale(string name, string type, int quantityleft, int tQuantitySale,
                decimal tPriceSale, decimal tGstCollect)  :base(name,type)
        {
            productName = name;
            productType = type;
            productQuantityLeft = quantityleft;
            totalQuantitySale = tQuantitySale;
            totalGstCollect = tGstCollect;
        }

        public TotalProductSale(string name, string type, int quantity, double discount, decimal originalPrice
        , decimal gstCharge, decimal salePrice) : base(name, type, discount, originalPrice
                , gstCharge, salePrice)
        {
            productQuantityLeft = quantity;
        }

    }
}
