using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Assignment
{
    public partial class TotalProductSaleForm : Form
    {
        MainForm mainForm;
        int adminOrUser;

        public TotalProductSaleForm(MainForm mainForm2, int adminOrUser2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            adminOrUser = adminOrUser2;

            decimal bTotalOriginalPrice = 0;
            decimal bTotalSalePrice = 0;
            decimal bTotalDiscount = 0;
            decimal bTotalGstCharge = 0;
            decimal bTotalProdit = 0;

            arrangeTotalProductSaleList();// arrange the data of TotalProductSaleList

            //loop through the product in TotalProductSaleList
            foreach (var item in mainForm.TotalProductSaleList)
            {
                //take the information about each  product from TotalProductSaleList and display it in the list view
                ListViewItem item1 = new ListViewItem(new string[] { item.productName,
                    item.productType,String.Format("{0:C}",item.productOriginalPrice),
                    String.Format("{0:C}",item.productSalePrice),String.Format("{0}",item.productDiscount),
                    String.Format("{0:C}",item.productGSTCharge), String.Format("{0}",item.productQuantityLeft),
                    String.Format("{0}",item.totalQuantitySale), String.Format("{0:C}",item.totalPriceOriginal),
                    String.Format("{0:C}",item.totalPriceSale), String.Format("{0:C}",item.totalDiscount),
                    String.Format("{0:C}",item.totalGstCollect), String.Format("{0:C}",item.totalProfit)});
                listView1.Items.Add(item1);
            }

            var bQuery =
                from value in mainForm.TotalProductSaleList
                select value;

            //loop through the product in TotalProductSaleList
            foreach (var item4 in bQuery)
            {
                //calculate the total product's information from the TotalProductSaleList
                bTotalOriginalPrice = bTotalOriginalPrice + item4.totalPriceOriginal;
                bTotalSalePrice = bTotalSalePrice + item4.totalPriceSale;
                bTotalDiscount = bTotalDiscount + item4.totalDiscount;
                bTotalGstCharge = bTotalGstCharge + item4.totalGstCollect;
                bTotalProdit = bTotalProdit + item4.totalProfit;
            }

            //put the calculated total product's information from the TotalProductSaleList to their respective richTextBox1
            richTextBox1.Text = String.Format("{0:C}", bTotalOriginalPrice);
            richTextBox2.Text = String.Format("{0:C}", bTotalSalePrice);
            richTextBox3.Text = String.Format("{0:C}", bTotalDiscount);
            richTextBox4.Text = String.Format("{0:C}", bTotalGstCharge);
            richTextBox5.Text = String.Format("{0:C}", bTotalProdit);

            //set the richTextBox to ReadOnly
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox3.ReadOnly = true;
            richTextBox4.ReadOnly = true;
            richTextBox5.ReadOnly = true;
        }

        //back to the End Day Form
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EndDay endDay = new EndDay(mainForm, adminOrUser);
            endDay.ShowDialog();
            this.Close();
        }

        private void arrangeTotalProductSaleList()
        {
            var query =
                from value in mainForm.FoodMenuList
                select value;

            var query2 =
                from value2 in mainForm.TotalProductSaleList
                select value2;

            foreach (var item in query)
            {
                foreach (var item2 in query2)
                {
                    //if product in FoodMenuList and TotalProductSaleList is the same
                    if (item.productName == item2.productName)
                    {
                        //take the information about the product from FoodMenuList to the TotalProductSaleList
                        item2.productType = item.productType;
                        item2.productQuantityLeft = item.productQuantity;
                        item2.productDiscount = item.productDiscount;
                        item2.productOriginalPrice = item.productOriginalPrice;
                        item2.productGSTCharge = item.productGSTCharge;
                        item2.productSalePrice = item.productSalePrice;
                    }
                }
            }

            //loop through the TotalProductSaleList
            foreach (var item3 in query2)
            {
                //calulate the total of the information of product from TotalProductSaleList
                item3.totalPriceOriginal = item3.productOriginalPrice * item3.totalQuantitySale;
                item3.totalPriceSale = item3.productSalePrice * item3.totalQuantitySale;
                item3.totalDiscount = item3.productSalePrice * item3.totalQuantitySale * Convert.ToDecimal(item3.productDiscount);
                item3.totalGstCollect = item3.productGSTCharge * item3.totalQuantitySale;
                item3.totalProfit = item3.totalPriceSale - item3.totalPriceOriginal - item3.totalDiscount;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
