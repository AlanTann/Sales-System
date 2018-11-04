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
    public partial class EndDay : Form
    {
        MainForm mainForm;
        int adminOrUser;

        public EndDay(MainForm mainForm2, int adminOrUser2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            adminOrUser = adminOrUser2;
        }

        //goto the receipt list form
        private void receiptListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptList receiptList = new ReceiptList(mainForm, adminOrUser);
            receiptList.ShowDialog();
            this.Close();
        }

        //goto the total product sale form
        private void totalProductSaleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalProductSaleForm totalProductSale = new TotalProductSaleForm(mainForm, adminOrUser);
            totalProductSale.ShowDialog();
            this.Close();
        }

        //go back to admin or user form
        private void BackButton_Click(object sender, EventArgs e)
        {

            if (adminOrUser == 1) //if adminOrUser variable equal to 1 then goto the sales person menu form
            {
                this.Hide();
                SalesPersonMenu salesMenu = new SalesPersonMenu(mainForm, adminOrUser);
                salesMenu.ShowDialog();
                this.Close();
            }
            else if (adminOrUser == 2)//if adminOrUser variable equal to 2 then goto the admin form
            {
                this.Hide();
                Admin admin = new Admin(mainForm, adminOrUser);
                admin.ShowDialog();
                this.Close();
            }
        }

        //end the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //go tot the receipt list which display all products for each list
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptFoodListReport receiptFoodListReport = new ReceiptFoodListReport(mainForm,adminOrUser);
            receiptFoodListReport.ShowDialog();
            this.Close();
        }
    }
}
