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
    public partial class AdminMenu : Form
    {
        public List<Food> store = new List<Food>();
        string tempProductName;
        MainForm mainForm;

        public AdminMenu(MainForm mainForm2)
        {
            InitializeComponent();
            mainForm = mainForm2;

            //Add the item from the food menu list to the list view
            foreach (var item in mainForm.FoodMenuList)
            {
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productOriginalPrice), String.Format("{0:C}", item.productGSTCharge),
                    String.Format("{0:C}", item.productSalePrice) });
                listView1.Items.Add(item1); 
            }
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.FullRowSelect = true;
            readTextBox();
            addButton.Enabled = true;
            Add.Enabled = false;
            editButton.Enabled = true;
            editItemButton.Enabled = false;
            DeleteValidButton.Enabled = true;
            delete.Enabled = false;
            cancelButton.Enabled = false;
            emptyTextBox();
        }

        //go to confirm delete click
        private void delete_Click(object sender, EventArgs e)
        {
            //if no item is selected in list view , display message box
            if (product_NameTextBox.Text == "")
            {
                MessageBox.Show("Please select the Item");
            }
            else //go to confirm delete button
            {
                delete_Data(product_NameTextBox.Text);
                mainForm.TotalProductSaleList.RemoveAll(a => a.productName == product_NameTextBox.Text);
                addButton.Enabled = true;
                Add.Enabled = false;
                editButton.Enabled = true;
                editItemButton.Enabled = false;
                DeleteValidButton.Enabled = true;
                delete.Enabled = false;
                cancelButton.Enabled = true;
                emptyTextBox();
                refreshListView();
            }
        }

        //Add item to the list
        private void Add_Click(object sender, EventArgs e)
        {
            string lowSearchName = product_NameTextBox.Text.ToLower();
            string highSearchName = product_NameTextBox.Text.ToUpper();

            if (ValidateEmptyTextBox() == true) //validate if there is any empty text box
            {
                string productName = product_NameTextBox.Text;
                string productType = typeTextBox.Text;
                int productQuantity = Convert.ToInt32(quantityTextBox.Text);
                double productDiscount = Convert.ToDouble(discountTextBox.Text);
                decimal productOriPrice = Convert.ToDecimal(originalPriceTextBox.Text);
                decimal productGstCharge = Convert.ToDecimal(gstPriceTextBox.Text);
                decimal productSalePrice = Convert.ToDecimal(salePriceTextBox.Text);

                if (validationTextBox() == true) // validate is the value is in the correct range
                {
                    int sameName = 0;

                    var query2 =
                         from value in mainForm.FoodMenuList
                         select value;

                    //validate to check the adding product name
                    foreach (var itemSame in query2)
                    {
                        if (itemSame.productName.ToLower() == lowSearchName || itemSame.productName.ToUpper() == highSearchName)
                        {
                            sameName = 1;
                        }
                    }

                    if (sameName == 0) //if the product name is no the same name, then add the product to foodmenulist and totalproductsalelist
                    {
                        mainForm._foodMenuList.Add(new Food(productName, productType,
                            productQuantity, productDiscount, productOriPrice, productGstCharge,
                            productSalePrice));
                        mainForm.TotalProductSaleList.Add(new TotalProductSale(productName));
                        addButton.Enabled = true;
                        Add.Enabled = false;
                        editButton.Enabled = true;
                        editItemButton.Enabled = false;
                        DeleteValidButton.Enabled = true;
                        delete.Enabled = false;
                        cancelButton.Enabled = true;
                        readTextBox();
                        emptyTextBox();
                        refreshListView();
                    }
                    else if (sameName == 1)
                    {
                        MessageBox.Show("Same Product Name cannot be Added");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Please Fill in everything in the text box");
            }
        }

        // Back to the admin form
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(mainForm);
            admin.ShowDialog();
            this.Close();
        }

        //delete method: remove the product from food menu list that match the product name with name
        private void delete_Data(string name)
        {
            mainForm.FoodMenuList.RemoveAll(a => a.productName == name);
        }

        // edit item from the food list
        private void editItemButton_Click(object sender, EventArgs e)
        {
            string lowSearchName = product_NameTextBox.Text.ToLower();
            string highSearchName = product_NameTextBox.Text.ToUpper();
            string listName = "";
            int sameName = 0;

            if (ValidateEmptyTextBox() == true) //validate if the text box is empty
            {
                if (validationTextBox() == true)// validate if the value in each textbox is in the correct range
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected == true)
                        {
                            listName = listView1.Items[i].SubItems[0].Text;
                        }
                    }

                    var query5 =
                        from value in mainForm.FoodMenuList
                        select value;

                    //check whether the product name in the food menu list is same as the name in the textbox
                    foreach (var itemSame in query5)
                    {
                        //if is the same name, then assign the variable sameName to 1
                        if (itemSame.productName.ToLower() == lowSearchName || itemSame.productName.ToUpper() == highSearchName)
                        {
                            sameName = 1;
                        }
                    }

                    //if is not the same name(sameNam = 0),then edit the item in the respective list
                    if (sameName == 0 || listName == product_NameTextBox.Text)
                    {
                        listView1.FullRowSelect = true;
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (listView1.Items[i].Selected == true)
                            {
                                tempProductName = listView1.Items[i].SubItems[0].Text;
                            }
                        }

                        var query =
                            from value in mainForm.FoodMenuList
                            where value.productName == tempProductName
                            select value;

                        var query2 =
                            from value in mainForm.TotalProductSaleList
                            where value.productName == tempProductName
                            select value;

                        //Edit Item and put in the list
                        foreach (var item in query)
                        {
                            item.productName = product_NameTextBox.Text;
                            foreach (var item2 in query2)
                            {
                                item2.productName = product_NameTextBox.Text;
                            }
                            item.productType = typeTextBox.Text;
                            item.productQuantity = Convert.ToInt32(quantityTextBox.Text);
                            item.productDiscount = Convert.ToDouble(discountTextBox.Text);
                            item.productOriginalPrice = Convert.ToDecimal(originalPriceTextBox.Text);
                            item.productGSTCharge = Convert.ToDecimal(gstPriceTextBox.Text);
                            item.productSalePrice = Convert.ToDecimal(salePriceTextBox.Text);
                        }
                        listView1.SelectedIndexChanged -= listView1_SelectedIndexChanged;
                        addButton.Enabled = true;
                        Add.Enabled = false;
                        editButton.Enabled = true;
                        editItemButton.Enabled = false;
                        DeleteValidButton.Enabled = true;
                        delete.Enabled = false;
                        cancelButton.Enabled = true;
                        readTextBox();
                        emptyTextBox();
                        refreshListView();
                    }
                    else
                    {
                        //if samename variable = 0 then display the message
                        MessageBox.Show("Cannot Edit to the same name");
                    }
                }
                else
                {
                    //if the value  is not in the same range, then display the message
                    MessageBox.Show("Invalid Input");
                }
            }
            else
            {
                //if there is any empty text box then display the message box
                MessageBox.Show("Please Fill in everything in the text box");
            }
        }

        // if different list is selected, then change the value of the textbox that match with the respective list
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected == true)
                {
                    product_NameTextBox.Text = listView1.Items[i].SubItems[0].Text;

                    var query =
                        from value in mainForm.FoodMenuList
                        where value.productName == listView1.Items[i].SubItems[0].Text
                        select value;
                    foreach (var item in query)
                    {
                        typeTextBox.Text = item.productType;
                        quantityTextBox.Text = Convert.ToString(item.productQuantity);
                        discountTextBox.Text = Convert.ToString(item.productDiscount);
                        originalPriceTextBox.Text = Convert.ToString(item.productOriginalPrice);
                        gstPriceTextBox.Text = Convert.ToString(item.productGSTCharge);
                        salePriceTextBox.Text = Convert.ToString(item.productSalePrice);
                    }
                    break;
                }
            }
        }

        //goto or enable the confirm add button
        private void addButton_Click(object sender, EventArgs e)
        {
            listView1.SelectedIndexChanged -= listView1_SelectedIndexChanged;
            listView1.FullRowSelect = false;
            unreadTextBox();
            addButton.Enabled = false;
            Add.Enabled = true;
            editButton.Enabled = false;
            editItemButton.Enabled = false;
            DeleteValidButton.Enabled = false;
            delete.Enabled = false;
            cancelButton.Enabled = true;
            emptyTextBox();
            listView1.SelectedIndexChanged -= listView1_SelectedIndexChanged;
        }

        //goto or enable the confirm edit button
        private void editButton_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Items[0].Selected = true;
            unreadTextBox();
            addButton.Enabled = false;
            Add.Enabled = false;
            editButton.Enabled = false;
            editItemButton.Enabled = true;
            DeleteValidButton.Enabled = false;
            delete.Enabled = false;
            cancelButton.Enabled = true;
        }

        //empty every text box
        private void emptyTextBox()
        {
            product_NameTextBox.Text = "";
            typeTextBox.Text = "";
            quantityTextBox.Text = "";
            discountTextBox.Text = "";
            originalPriceTextBox.Text = "";
            gstPriceTextBox.Text = "";
            salePriceTextBox.Text = "";
        }

        // refesh listview by clearing up the list view and add the value to the list view again
        private void refreshListView()
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

        //only allow numeric/integer number in the quantity text box
        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //allow decimal number in the discount text box
        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //allow decimal number in the original price text box
        private void originalPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //allow decimal number in the gst price text box
        private void gstPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //allow decimal number in the sale price text box
        private void salePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //goto or enable the confirm delete button
        private void DeleteValidButton_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            addButton.Enabled = false;
            Add.Enabled = false;
            editButton.Enabled = false;
            editItemButton.Enabled = false;
            DeleteValidButton.Enabled = false;
            delete.Enabled = true;
            cancelButton.Enabled = true;
            product_NameTextBox.ReadOnly = true;
        }

        //cancel the confirm  confirm add  , confirm edit, confirm delete button
        //enable the add new item, edit and delete button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            Add.Enabled = false;
            editButton.Enabled = true;
            editItemButton.Enabled = false;
            DeleteValidButton.Enabled = true;
            delete.Enabled = false;
            readTextBox();
            emptyTextBox();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.FullRowSelect = true;
        }

        //validate if each value in text box is in the respective range
        private Boolean validationTextBox()
        {
            double productDiscount = Convert.ToDouble(discountTextBox.Text);
            decimal productOriPrice = Convert.ToDecimal(originalPriceTextBox.Text);
            decimal productGstCharge = Convert.ToDecimal(gstPriceTextBox.Text);
            decimal productSalePrice = Convert.ToDecimal(salePriceTextBox.Text);

            if (productDiscount <= 1 && productDiscount>=0 &&productOriPrice <=productSalePrice && 
                productGstCharge <=productOriPrice &&  productSalePrice >= productOriPrice)
            {
                return true; //if every value in the text box is in their respective range, then return true
            }
            else
            {
                return false;
            }
        }

        //validate if there is any empty text box
        private Boolean ValidateEmptyTextBox()
        {
            if (product_NameTextBox.Text != ""&& typeTextBox.Text !="" && quantityTextBox.Text !=""
                && discountTextBox.Text !="" && originalPriceTextBox.Text!= "" && gstPriceTextBox.Text !=""
                && salePriceTextBox.Text != "")
            {
                return true; // if every text box is not empty then return true
            }
            else
            {
                return false;
            }
        }

        //set all the text box to read only which disallow the user enter value/data inside 
        private void readTextBox()
        {
            product_NameTextBox.ReadOnly = true;
            typeTextBox.ReadOnly = true;
            quantityTextBox.ReadOnly = true;
            discountTextBox.ReadOnly = true;
            originalPriceTextBox.ReadOnly = true;
            gstPriceTextBox.ReadOnly = true;
            salePriceTextBox.ReadOnly = true;
        }

        //set all the text box to unread which allow the user enter value/data inside 
        private void unreadTextBox()
        {
            product_NameTextBox.ReadOnly = false;
            typeTextBox.ReadOnly = false;
            quantityTextBox.ReadOnly = false;
            discountTextBox.ReadOnly = false;
            originalPriceTextBox.ReadOnly = false;
            gstPriceTextBox.ReadOnly = false;
            salePriceTextBox.ReadOnly = false;
        }
    }
}
