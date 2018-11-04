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
    public partial class AdminMenuSearch : Form
    {
        MainForm mainForm;

        public AdminMenuSearch(MainForm mainForm2)
        {
            mainForm = mainForm2;
            InitializeComponent();

            //add the item from the foodmenulist to the list view
            foreach (var item in mainForm.FoodMenuList)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView1.Items.Add(item1);
            }
            Ok.Enabled = false;
            removeSearch.Enabled = false;
            okSearchQuantity.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
        }

        //if Ok button is click, then search the item and display it in the search list
        private void Ok_Click(object sender, EventArgs e)
        {
            string lowSearchName = textBox1.Text.ToLower();
            string highSearchName = textBox1.Text.ToUpper();

            listView2.Items.Clear(); //clear the item in search list

            var query =
                from value in mainForm.FoodMenuList
                select value;

            //add the search item and display it in the search list
            foreach (var item in query)
            {
                if (item.productName.ToLower() == lowSearchName || item.productName.ToUpper() == highSearchName)
                {
                    ListViewItem searchItem = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                    listView2.Items.Add(searchItem);
                }
            }

            //if there is no item exist in the foodmenulist or no item in list view
            if (listView2.Items.Count!= 0)
            {
                comboBox1.SelectedIndex = 0;
                listView2.Items[0].Selected = true;
                label6.Text = listView2.Items[0].SubItems[0].Text;
                removeSearch.Enabled = true;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
            }
            textBox1.Text = "";
        }
    
        //back to the admin form
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(mainForm);
            admin.ShowDialog();
            this.Close();
        }

        //remove the search item from the list,FoodMenuList and TotalProductSaleList
        private void removeSearch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectItem in listView2.SelectedItems)
            {
                listView2.Items.Remove(selectItem);
                mainForm.FoodMenuList.RemoveAll(a => a.productName == selectItem.SubItems[0].Text);
                mainForm.TotalProductSaleList.RemoveAll(a => a.productName == selectItem.SubItems[0].Text);
            }
            textBox2.Text = "";
            removeSearch.Enabled = false;
            okSearchQuantity.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
            refreshListView1();
        }

        //add or edit quantity of the item
        private void okSearchQuantity_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //edit the quantity of the item
            {
                foreach (ListViewItem selectItem in listView2.SelectedItems)
                {
                    var query =
                        from value in mainForm.FoodMenuList
                        where value.productName == label6.Text
                        select value;

                    foreach (var item in query)
                    {
                        item.productQuantity = Convert.ToInt32(textBox2.Text);
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1) // add the quantity of the item
            {
                foreach (ListViewItem selectItem in listView2.SelectedItems)
                {
                    var query =
                        from value in mainForm.FoodMenuList
                        where value.productName == label6.Text
                        select value;

                    foreach (var item in query)
                    {
                        item.productQuantity = item.productQuantity + Convert.ToInt32(textBox2.Text);
                    }
                }
            }
            refreshListView1();
            refreshListView2();
        }

        //refresh the full list view
        private void refreshListView1() 
        {
            listView1.Items.Clear();
            foreach (var item in mainForm.FoodMenuList)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView1.Items.Add(item1);
            }
        }

        //refresh the search list view
        private void refreshListView2()
        {
            listView2.Items.Clear();
            string refreshSearchItem = label6.Text;

            var query =
                from value in mainForm.FoodMenuList
                where value.productName == refreshSearchItem
                select value;

            foreach (var item in query)
            {
                ListViewItem searchItem = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView2.Items.Add(searchItem);
            }
            listView2.Items[0].Selected = true;
            label6.Text = listView2.Items[0].SubItems[0].Text;
        }

        // validate if there is any value in the search textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // if the search text box is empty then disable the ok button
            {
                Ok.Enabled = false;
            }
            else
            {
                Ok.Enabled = true;
            }
        }

        //only allow numeric/ intefer value in the quantity textbox
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // validate if there is any value in the quantity textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")// if the quantity text box is empty then disable the ok button
            {
                okSearchQuantity.Enabled = false;
            }
            else
            {
                okSearchQuantity.Enabled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                //press enter to search without pressing okay
                if (e.KeyCode == Keys.Enter)
                {
                    Ok_Click((object)sender, (EventArgs)e);
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.Text != "")
            {
                //press enter to edit or add without pressing okay
                if (e.KeyCode == Keys.Enter)
                {
                    okSearchQuantity_Click((object)sender, (EventArgs)e);
                }
            }
        }
    }
}
