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
    public partial class ReceiptForm : Form
    {
        MainForm mainForm;
        double serviceTaxing;
        int adminOrUser;
        decimal cash;
        Random randomNumbers = new Random();
        int receiptId = 0;

        public ReceiptForm(MainForm mainForm2, double serviceTax2, int adminOrUser2, decimal cash2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            serviceTaxing = serviceTax2;
            adminOrUser = adminOrUser2;
            cash = cash2;
            receiptId = randomNumbers.Next(10000000, 90000000);

            label9.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);

            foreach (var item in mainForm.TempFoodList)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, string.Format("{0}", item.productQuantity), 
                    String.Format("{0:C}",item.TotalProductPrice)});
                listView1.Items.Add(item1);

                mainForm.ReceiptListFood.Add(new ReceiptFoodList(receiptId, item.productName,
                    item.productQuantity, Convert.ToDecimal(item.TotalProductPrice)));
            }
            Calculation();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            mainForm.TempFoodList.Clear();
            this.Hide();
            SalesPersonMenu salesPersonMenu = new SalesPersonMenu(mainForm, adminOrUser);
            salesPersonMenu.ShowDialog();
            this.Close();
        }

        public void Calculation()
        {
            decimal subTotal = 0;
            decimal gstCharge = 0;
            decimal serviceTax = 0;
            decimal discount = 0;
            decimal totalCost = 0;

            var query =
                    from value in mainForm.TempFoodList
                    select value;

            foreach (var item in query)
            {
                subTotal = subTotal + (item.productQuantity * item.productSalePrice);
                gstCharge = gstCharge + (item.productQuantity * item.productGSTCharge);
                serviceTax = subTotal * Convert.ToDecimal(serviceTaxing);
                discount = discount + (Convert.ToDecimal(item.productDiscount) * item.productQuantity * item.productSalePrice);
                totalCost = subTotal + gstCharge + serviceTax - discount;
            }

            label4.Text = string.Format("{0}", receiptId);
            label15.Text = string.Format("{0:C}", subTotal);
            label16.Text = string.Format("{0:C}", gstCharge);
            label17.Text = string.Format("{0:C}", serviceTax);
            label18.Text = string.Format("{0:C}", discount);
            label20.Text = string.Format("{0:C}", totalCost);
            label22.Text = string.Format("{0:C}", cash);
            label25.Text = string.Format("{0:C}", cash - totalCost);

            mainForm.ReceiptList.Add(new Receipt(receiptId, subTotal, serviceTax, gstCharge,
                discount, totalCost, string.Format("{0:HH:mm:ss tt}", DateTime.Now)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("            =====Your receipt has been printed======\n========Thank you and please come again========");
        }
    }
}
