using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment
{
    public class Receipt :TopReceipt
    {
        public decimal SubTotal { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal GstCharge { get; set; }
        public decimal discount { get; set; }
        public decimal TotalCost { get; set; }
        public string dateString { get; set; }

        public Receipt(int RId, decimal sTotal, decimal sTax, decimal gCharge, decimal disc,decimal totalCost, string dString)
            :base(RId)
        {
            SubTotal = sTotal;
            ServiceTax = sTax;
            GstCharge = gCharge;
            discount = disc;
            TotalCost = totalCost;
            dateString = dString;
        }

    }
}
