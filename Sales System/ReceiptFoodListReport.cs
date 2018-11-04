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
    public partial class ReceiptFoodListReport : Form
    {
        MainForm mainForm;
        int adminOrUser = 0;
        int previousReceiptId = 0;
        
        public ReceiptFoodListReport(MainForm mainForm2, int adminOrUser2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            adminOrUser = adminOrUser2;

            int groupCount = 0;
            int counter = 0;

            var query =
                from value in mainForm.ReceiptListFood
                select value;

            //display the products in each receipt in the list view
            //group the receiptId
            foreach (var item in mainForm.ReceiptListFood)
            {
                if (counter ==0)
                {
                    previousReceiptId = item.receiptId;
                }

                if (previousReceiptId == item.receiptId && groupCount == 0)
                {
                    //create a new group as receiptID
                    listView1.Groups.Add("GroupKey " + groupCount, "Receipt ID: " + Convert.ToString(item.receiptId));
                }
                else if (previousReceiptId != item.receiptId)
                {
                    //create a new group as receiptID
                    groupCount = groupCount + 1;
                    listView1.Groups.Add("GroupKey " + groupCount, "Receipt ID: " + Convert.ToString(item.receiptId));
                    previousReceiptId = item.receiptId;
                }
                
                if (previousReceiptId == item.receiptId)
                {
                    //Add the product to the respective group(recceipt id)
                    ListViewItem item1 = new ListViewItem(new string[] {item.productName, string.Format("{0}", item.productQuantity),
                        String.Format("{0:C}",item.productTotalSalePrice)});
                    this.listView1.Items.Insert(0, item1);
                    this.listView1.Groups[groupCount].Items.Insert(0, item1);
                }
                previousReceiptId = item.receiptId;
                counter++;
            }
        }

        //back to the End Day form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EndDay endDay = new EndDay(mainForm, adminOrUser);
            endDay.ShowDialog();
            this.Close();
        }
    }
}
