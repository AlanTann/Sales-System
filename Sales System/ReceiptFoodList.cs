using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class ReceiptFoodList : TopReceipt
    {
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public decimal productTotalSalePrice { get; set; }

        public ReceiptFoodList(int RId,string name, int quantity, decimal totalSalePrice)
            :base(RId)
        {
            productName = name;
            productQuantity = quantity;
            productTotalSalePrice = totalSalePrice;
        }
    }
}
