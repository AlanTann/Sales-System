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
    public partial class ReceiptList : Form
    {
        MainForm mainForm;
        int adminOrUser;

        public ReceiptList(MainForm mainForm2, int adminOrUser2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            adminOrUser = adminOrUser2;
            int totalSales = 0;
            decimal totalServiceTax = 0;
            decimal totalGstCharge = 0;
            decimal totalDiscount = 0;
            decimal totalCost = 0;

            //take the data from ReceiptList and display it to the list view
            foreach (var item in mainForm.ReceiptList)
            {
                ListViewItem item1 = new ListViewItem(new string[] { String.Format("{0}", item.receiptId),
                    String.Format("{0:C}", item.SubTotal), String.Format("{0:C}", item.ServiceTax), String.Format("{0:C}", item.GstCharge),
                    String.Format("{0:C}", item.discount), String.Format("{0:C}", item.TotalCost), item.dateString});
                listView1.Items.Add(item1);
            }

            var query =
                from value in mainForm.ReceiptList
                select value;

            //Calculate the total data from ReceiptList
            foreach (var item2 in query)
            {
                totalSales = totalSales + 1;
                totalServiceTax = totalServiceTax + item2.ServiceTax;
                totalGstCharge = totalGstCharge + item2.GstCharge;
                totalDiscount = totalDiscount + item2.discount;
                totalCost = totalCost + item2.TotalCost;
            }

            //display the calculated total data to their respective label
            label6.Text = Convert.ToString(totalSales);
            label7.Text = String.Format("{0:C}", totalServiceTax);
            label8.Text = String.Format("{0:C}", totalGstCharge);
            label9.Text = String.Format("{0:C}", totalDiscount);
            label10.Text = String.Format("{0:C}", totalCost);
        }

        //goto the End Day Form
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EndDay endDay = new EndDay(mainForm, adminOrUser);
            endDay.ShowDialog();
            this.Close();
        }
    }
}
