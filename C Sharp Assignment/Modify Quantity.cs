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
    public partial class Modify_Quantity : Form
    {
        MainForm mainForm;
        public Modify_Quantity(MainForm mainForm2)
        {
            InitializeComponent();
            mainForm = mainForm2;
            foreach (var item in mainForm.FoodMenuList)
            {
                // add the product from the FoodMenuList to List View
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView1.Items.Add(item1);
            }
           listView1.Items[0].Selected = true;
           comboBox1.SelectedIndex = 0;
            Ok.Enabled = false;
        }

        //if ok button is click
        private void Ok_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // if edit is selected
            {
                foreach (ListViewItem selectItem in listView1.SelectedItems)
                {
                    var query =
                        from value in mainForm.FoodMenuList
                        where value.productName == label2.Text
                        select value;

                    foreach (var item in query)
                    {
                        //the quantity in text box is equal to the current quantity of the FoodMenuList
                        item.productQuantity = Convert.ToInt32(textBox1.Text);
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1) // if add is selected
            {
                foreach (ListViewItem selectItem in listView1.SelectedItems)
                {
                    var query =
                        from value in mainForm.FoodMenuList
                        where value.productName == label2.Text
                        select value;

                    foreach (var item in query)
                    {
                        //add the quantity from the quantity textbox to the current quantity of the FoodMenuList
                        item.productQuantity = item.productQuantity + Convert.ToInt32(textBox1.Text);
                    }
                }
            }
            refreshListView();
        }

        private void refreshListView()
        {
            listView1.Items.Clear(); //clear list view
            foreach (var item in mainForm.FoodMenuList)
            {
                // add the product from the FoodMenuList to List View
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView1.Items.Add(item1);
            }
            listView1.Items[0].Selected = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //go to admin form
            Admin admin = new Admin(mainForm);
            admin.ShowDialog();
            this.Close();
        }

        // if selected index in list view change
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected == true)
                {
                    //add the product name of the selected item to the label2
                    label2.Text = listView1.Items[i].SubItems[0].Text;
                    break;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numeric/ integer in quantity tet box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //if text in quantity text box change
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                //if text in quantity text box is empty, then disable the ok button
                Ok.Enabled = false;
            }
            else
            {
                Ok.Enabled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                //press enter to add or edit quantity without pressing add
                if (e.KeyCode == Keys.Enter)
                {
                    Ok_Click((object)sender, (EventArgs)e);
                }
            }
        }
    }
}
