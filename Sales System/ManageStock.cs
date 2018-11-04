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
    public partial class ManageStock : Form
    {
        MainForm mainForm;
        public ManageStock(MainForm mainForm2)
        {
            mainForm = mainForm2;
            InitializeComponent();
            var query =
                from value in mainForm.FoodMenuList
                where value.productQuantity < 10
                select value;

            //loop through the products in foodmenulist that only have 10 quantity
            foreach (var item in query)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName,
                    String.Format("{0}", item.productQuantity) });
                listView1.Items.Add(item1); // add the product to the less quantity product list view
            }
            label4.Text = "";
        }

        //order only one particular product
        private void trigOrder_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear(); //clear the order list view

            foreach (ListViewItem selectItem in listView1.SelectedItems)
            {
                var query =
                from value in mainForm.FoodMenuList
                where value.productQuantity < 10
                select value;

                foreach (var item in query)
                {
                    // if the item of the list view/label4 match the product in food menu list, then add 20 quantity
                    if (item.productName == label4.Text)
                    {
                        item.productQuantity = item.productQuantity + 20; // add the particular product quantity to 20
                        ListViewItem item1 = new ListViewItem(new string[] { item.productName,
                    String.Format("{0}", item.productQuantity) });
                        listView2.Items.Add(item1); // add the order product to the order list
                    }
                }
            }
            refreshlistView1();
            MessageBox.Show("Order has been made.");
        }

        //back to admin
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(mainForm);
            admin.ShowDialog();
            this.Close();
        }

        //refresh the less product list view
        public void refreshlistView1()
        {
            listView1.Items.Clear(); //clear the less product list view

            var query =
                from value in mainForm.FoodMenuList
                where value.productQuantity < 10
                select value;

            //add back the products that has less than 10 quantity to the less product list view
            foreach (var item in query)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName,
                    String.Format("{0}", item.productQuantity) });
                listView1.Items.Add(item1);
            }
        }

        //order all the products that has less quantity
        private void allOrderButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear(); // clear the product in the order list
            var query =
                from value in mainForm.FoodMenuList
                where value.productQuantity < 10
                select value;

            // add 20 quantity to each product that has less than 10 quantity and put it back to the foodmenulist
            foreach (var item in query)
            {
                item.productQuantity = item.productQuantity + 20;
                ListViewItem item1 = new ListViewItem(new string[] { item.productName,
                String.Format("{0}", item.productQuantity) });
                listView2.Items.Add(item1); 
            }
        
            refreshlistView1();
            MessageBox.Show("Order has been made.");
        }

        //change the product name in label4 if there is any changed in the selected index in the less product list view
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected == true)
                {
                    label4.Text = listView1.Items[i].SubItems[0].Text;
                    break;
                }
            }
        }

        //if there is any text change
        private void label4_TextChanged(object sender, EventArgs e)
        {
            //if the labell4 is empty thats means no product/list is selected, so disable the Online Order button
            if (label4.Text == "")
            {
                trigOrder.Enabled = false;
            }
            else
            {
                trigOrder.Enabled = true;
            }
        }
    }
}
