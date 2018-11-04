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
    public partial class SalesPersonMenu : Form
    {
        public Boolean serviceCharge;
        MainForm mainForm;
        double serviceTax = 0;
        int adminOrUser;
        decimal mainTotalCost = 0;

        public SalesPersonMenu(MainForm mainForm2, int adminOrUser2)
        {
            mainForm = mainForm2;
            InitializeComponent();
            adminOrUser = adminOrUser2;
            ListViewItem list = new ListViewItem();

            //loop through FoodMenuList
            foreach (var item in mainForm.FoodMenuList)
            {
                //Add each product from the FoodMenuList to the Full product list View
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    string.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productSalePrice) });
                listView3.Items.Add(item1);
            }
            if (adminOrUser == 1)
            {
                goAdminButton.Visible = false;
            }
            richTextBox1.Text = "Press the food in the food menu to add quantity";
            richTextBox1.ReadOnly = true;
            cashBox.ReadOnly = true;
            button3.Enabled = false;
            EditQuantity.Enabled = false;
            RemoveItemButton.Enabled = false;
            ConfirmButton.Enabled = false;
            CancelButton.Enabled = false;
            comboBox1.SelectedIndex = 0;
            label12.Text = "";
            label2.Text = "";
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        //if Add button is click
        private void button3_Click(object sender, EventArgs e)
        {
            int foodQuantity = 0;
            int validateTextQuantity = Convert.ToInt32(quantityTextBox.Text);
            int validateListQuantity = 0;

            var validateQuery =
                from validateValue in mainForm.FoodMenuList
                where validateValue.productName == label12.Text
                select validateValue;

            //loop through the FoodMenuList which has the same name in the product name in add quantity
            foreach (var item5 in validateQuery)
            {
                //assign the current quantity of the product to validateListQuantity
                validateListQuantity = Convert.ToInt32(item5.productQuantity);
            }

            if (validateTextQuantity <= validateListQuantity)
            {
                if (quantityTextBox.Text != "")
                {
                    int quantityText = Convert.ToInt32(quantityTextBox.Text);

                    foreach (ListViewItem selectItem in listView3.SelectedItems)
                    {
                        var comNameQuery =
                            from value2 in mainForm.TempFoodList
                            where value2.productName == label12.Text
                            select value2;

                        foreach (var item3 in comNameQuery)
                        {
                            foodQuantity = item3.productQuantity;
                        }

                        foodQuantity = foodQuantity + quantityText;

                        mainForm.TempFoodList.RemoveAll(a => a.productName == label12.Text);

                        var query =
                            from value in mainForm.FoodMenuList
                            where value.productName == label12.Text
                            select value;

                        foreach (var item in query)
                        {
                            mainForm.TempFoodList.Add(new tempProductRec(item.productName, item.productType,
                                    foodQuantity, item.productDiscount, item.productOriginalPrice,
                                    item.productGSTCharge, item.productSalePrice));
                            item.productQuantity = item.productQuantity - quantityText;
                        }
                    }
                    richTextBox1.Visible = false;
                    cashBox.ReadOnly = false;
                    EditQuantity.Enabled = false;
                    RemoveItemButton.Enabled = false;
                    CancelButton.Enabled = true;
                    refreshListView2();
                    refreshListView3();
                    quantityTextBox.Text = "";
                    label12.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid Quantity.");
                quantityTextBox.Text = "";
            }
            refreshTotalCost();
        }

        //if selected index in full product list view change
        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < listView3.Items.Count; i++)
                {
                    if (listView3.Items[i].Selected == true)
                    {
                        label12.Text = listView3.Items[i].SubItems[0].Text;
                        label2.Text = "";
                        quantityTextBox.Text = "";
                        break;
                    }
                }
                foreach (ListViewItem itm in listView3.SelectedItems)
                {
                    int imgIndex = itm.ImageIndex;

                    for (int i = 0; i < listView3.Items.Count; i++)
                    {
                        if (listView3.Items[i].Selected == true)
                        {
                            label2.Text = listView3.Items[i].SubItems[0].Text;
                            break;
                        }
                    }
                    if (imgIndex >= 0 && imgIndex < this.imageList1.Images.Count)
                    {
                        pictureBox1.Image = this.imageList1.Images[imgIndex];
                    }


                    if (label12.Text == "Beef Burger")
                    {
                        pictureBox1.Image = imageList1.Images["brger.jpg"];
                    }
                    else if (label12.Text == "Chicken Pie")
                    {
                        pictureBox1.Image = imageList1.Images["ChickenPie.jpg"];
                    }
                    else if (label12.Text == "Fish")
                    {
                        pictureBox1.Image = imageList1.Images["fish.jpg"];
                    }
                    else if (label12.Text == "Meat")
                    {
                        pictureBox1.Image = imageList1.Images["Meat.jpg"];
                    }
                    else if (label12.Text == "Veggie")
                    {
                        pictureBox1.Image = imageList1.Images["veggie.jpg"];
                    }
                    else if (label12.Text == "Chicken and Mushroom")
                    {
                        pictureBox1.Image = imageList1.Images["ChickenMushroom.jpg"];
                    }
                    else if (label12.Text == "Egg Burger")
                    {
                        pictureBox1.Image = imageList1.Images["EggBurger.jpg"];
                    }
                    else if (label12.Text == "Soda Large")
                    {
                        pictureBox1.Image = imageList1.Images["SodaLarge.jpg"];
                    }
                    else if (label12.Text == "Soda Small")
                    {
                        pictureBox1.Image = imageList1.Images["SodaSmall.jpg"];
                    }
                    else if (label12.Text == "Hot Drink")
                    {
                        pictureBox1.Image = imageList1.Images["HotDrink.jpg"];
                    }
                    else if (label12.Text == "Juice Drink Large")
                    {
                        pictureBox1.Image = imageList1.Images["JuiceDrinkLarge.jpg"];
                    }
                    else if (label12.Text == "Juice Drink Small")
                    {
                        pictureBox1.Image = imageList1.Images["JuiceDrinkSmall.jpg"];
                    }
                    else if (label12.Text == "Mineral Water")
                    {
                        pictureBox1.Image = imageList1.Images["MineralWater.jpg"];
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
        }
        //refresh full product list view
        private void refreshListView3()
        {
            listView3.Items.Clear(); //clear full product list view
            foreach (var item in mainForm.FoodMenuList)
            {
                //add each item from FoodMenuList to full product list view
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, item.productType,
                    String.Format("{0}", item.productQuantity), String.Format("{0}", item.productDiscount),
                    String.Format("{0:C}", item.productSalePrice) });
                listView3.Items.Add(item1);
            }
        }

        //refresh the order list view
        private void refreshListView2()
        {
            listView2.Items.Clear();// clear order list view
            foreach (var item in mainForm.TempFoodList)
            {
                //add each item from TempFoodList to order list view
                ListViewItem item1 = new ListViewItem(new string[] { item.productName, Convert.ToString(item.productQuantity) });
                listView2.Items.Add(item1);
            }
        }

        //if confirm button is click
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            decimal cash = 0;

            if (comboBox1.SelectedIndex == 0)// if dine in is selected in combo box
            {
                serviceTax = 0.03;// then assign service tax as 0.03
            }
            else if (comboBox1.SelectedIndex == 1)// if take away is selected in combo box
            {
                serviceTax = 0;// then assign service tax as 0
            }

            var query =
                from value in mainForm.TempFoodList
                select value;

            var query2 =
                from value2 in mainForm.TotalProductSaleList
                select value2;
            foreach (var item in query)
            {
                foreach (var item2 in query2)
                {
                    if (item.productName == item2.productName)
                    {
                        item2.totalQuantitySale = item2.totalQuantitySale + item.productQuantity;
                    }
                }
            }
            if (cashBox.Text == "")
            {
                // if cash text box is empty, display the message box
                MessageBox.Show("Please insert the Cash");
            }
            else
            {
                cash = Convert.ToDecimal(cashBox.Text);
                if (cash < mainTotalCost) 
                {
                    //if cash in text box is less thn actual total cost, display the message box
                    MessageBox.Show("Not enough Cash.");
                }
                else
                {
                    //if cash in text box is more than actual total cost, display the receipt form
                    this.Hide();
                    ReceiptForm receiptForm = new ReceiptForm(mainForm, serviceTax, adminOrUser, cash);
                    receiptForm.ShowDialog();
                    this.Close();
                }
            }
        }

        //if cancel button is click
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var query =
                from value in mainForm.TempFoodList
                select value;

            var mainFoodQuery =
                from value2 in mainForm.FoodMenuList
                select value2;

            foreach (var item in mainFoodQuery)
            {
                foreach (var item2 in query)
                {
                    if (item.productName == item2.productName)
                    {   
                        //add back the quantity from TempFoodList to FoodMenuList
                        item.productQuantity = item.productQuantity + item2.productQuantity;
                    }
                }
            }
            richTextBox1.Visible = true;
            EditQuantity.Enabled = false;
            RemoveItemButton.Enabled = false;
            ConfirmButton.Enabled = false;
            CancelButton.Enabled = false;
            cashBox.ReadOnly = true;
            mainForm.TempFoodList.Clear(); //clear all the product information of TempFoodList
            refreshListView2();
            refreshListView3();
            refreshTotalCost();
        }

        //if log out button is click
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //go to login form
            Login login = new Login(mainForm);
            login.ShowDialog();
            this.Close();
        }

        //if end day button is click
        private void EndDayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // go to end day form
            EndDay endDay = new EndDay(mainForm, adminOrUser);
            endDay.ShowDialog();
            this.Close();
        }

        // if text in add quantity text box change
        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void delete_Data(string name)
        {
            //delete product which has the same name as name variable from FoodMenuList
            mainForm.TempFoodList.RemoveAll(a => a.productName == name);
        }

        //Edit the order quantity
        private void EditQuantity_Click(object sender, EventArgs e)
        {
            int foodQuantity = 0;
            int quantityText = Convert.ToInt32(textBox1.Text);
            int tempitemQuantity = 0; //for invalid,return to previous data

            foreach (ListViewItem selectItem in listView2.SelectedItems)
            {
                var comNameQuery =
                    from value2 in mainForm.TempFoodList
                    where value2.productName == label2.Text
                    select value2;

                foreach (var item3 in comNameQuery)
                {
                    //get the quantity from tempFoodList which has the same name as label2.text and assign it to foodQuantity
                    foodQuantity = item3.productQuantity;
                }

                var query =
                    from value in mainForm.TempFoodList
                    where value.productName == label2.Text
                    select value;

                foreach (var item in query)
                {
                    tempitemQuantity = item.productQuantity;
                    item.productQuantity = Convert.ToInt32(textBox1.Text);
                }

                var topFoodQuery =
                    from value in mainForm.FoodMenuList
                    where value.productName == label2.Text
                    select value;

                foreach (var item in topFoodQuery)
                {
                    foreach (var item2 in query)
                    {
                        if (quantityText <= (foodQuantity + item.productQuantity))
                        {
                            if (quantityText > foodQuantity) //if edit quantity in text box is higher than current quantity of tempfood list
                            {
                                item.productQuantity = item.productQuantity - (quantityText - foodQuantity);
                            }
                            else if (quantityText < foodQuantity)//if edit quantity in text box is lower than current quantity of tempfood list
                            {
                                item.productQuantity = item.productQuantity + (foodQuantity - quantityText);
                            }
                            label2.Text = "";
                            textBox1.Text = "";
                            refreshListView2();
                            refreshListView3();
                            refreshTotalCost();
                        }
                        else
                        {
                            item2.productQuantity = tempitemQuantity;
                            label2.Text = item.productName;
                            MessageBox.Show("Invalid Quantity Value");
                            break;
                        }
                    }
                }
            }
        }

        //if the selected index in order list view is changed 
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].Selected == true)
                {
                    label2.Text = listView2.Items[i].SubItems[0].Text;
                    RemoveItemButton.Enabled = true;
                    label12.Text = "";
                    break;
                }
            }
        }

        //if remove item button is click
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int foodQuantity = 0;
            foreach (ListViewItem selectItem in listView2.SelectedItems)
            {
                var comNameQuery =
                    from value2 in mainForm.TempFoodList
                    where value2.productName == label2.Text
                    select value2;

                foreach (var item3 in comNameQuery)
                {
                    foodQuantity = item3.productQuantity;
                }

                var query =
                    from value in mainForm.FoodMenuList
                    where value.productName == label2.Text
                    select value;

                foreach (var item in query)
                {
                    //add back the quantity to FoodMenuList which has the same name as remove item name
                    item.productQuantity = item.productQuantity + foodQuantity;
                }

                //remove the product from tempFoodList
                mainForm.TempFoodList.RemoveAll(a => a.productName == label2.Text);
            }
            label2.Text = "";
            refreshListView2();
            refreshListView3();

            //if order list view has no item
            if (listView2.Items.Count == 0)
            {
                richTextBox1.Visible = true;
                EditQuantity.Enabled = false;
                RemoveItemButton.Enabled = false;
                ConfirmButton.Enabled = false;
                CancelButton.Enabled = false;
                cashBox.ReadOnly = true;
            }
            refreshTotalCost();
        }

        private void dataToTotalProductSale()
        {
            int foodQuantity = 0;
            int quantityText = Convert.ToInt32(quantityTextBox.Text);

            foreach (ListViewItem selectItem in listView3.SelectedItems)
            {
                var comNameQuery =
                    from value2 in mainForm.TempFoodList
                    where value2.productName == label12.Text
                    select value2;

                foreach (var item3 in comNameQuery)
                {
                    foodQuantity = item3.productQuantity;
                }

                foodQuantity = foodQuantity + quantityText;

                mainForm.TempFoodList.RemoveAll(a => a.productName == label12.Text);

                var query =
                    from value in mainForm.FoodMenuList
                    where value.productName == label12.Text
                    select value;

                foreach (var item in query)
                {
                    //minus the quantity of the product in FoodMenuList which has the same name as label12
                    mainForm.TempFoodList.Add(new tempProductRec(item.productName, item.productType,
                            foodQuantity, item.productDiscount, item.productOriginalPrice,
                            item.productGSTCharge, item.productSalePrice));
                    item.productQuantity = item.productQuantity - quantityText;
                }
            }
        }

        //if selected index(Dine in & take away) in comboBox change
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //if dine in is selected , then service tax = 0.03
            {
                label13.Text = "0.03";//diplay service tax in label13
            }
            else if (comboBox1.SelectedIndex == 1) //if take away is selected , then service tax = 0
            {
                label13.Text = "0";//diplay service tax in label13
            }
           refreshTotalCost();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numeric/integer value in add quantity text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numeric value in edit quantity text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if value in edit quantity text box change
            if (textBox1.Text == "")
            {
                EditQuantity.Enabled = false;
            }
            else
            {
                EditQuantity.Enabled = true;
            }
        }

        
        private void label2_TextChanged(object sender, EventArgs e)
        {
            //if product name in edit quantity(label2) change
            if (label2.Text == "")
            {
                RemoveItemButton.Enabled = false;
                textBox1.ReadOnly = true;
            }
            else
            {
                RemoveItemButton.Enabled = true;
                textBox1.ReadOnly = false;
            }
        }

        //goto Admin Form 
        private void goAdminButton_Click(object sender, EventArgs e)
        {
            //if is admin, then allow it to go Admin form else show the message box
            if (adminOrUser == 2)
            {
                this.Hide();
                Admin admin = new Admin(mainForm, adminOrUser);
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You are not Admin.");
            }
        }

        private void cashBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow decimal or numeric number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void refreshTotalCost()
        {
            decimal subTotal = 0;
            decimal gstCharge = 0;
            decimal serviceTax = 0;
            decimal discount = 0;
            decimal totalCost = 0;

            var query =
                    from value in mainForm.TempFoodList
                    select value;

            //loop through TempFoodList
            foreach (var item in query)
            {
                //Add the total information of each product from TempFoodList
                subTotal = subTotal +(item.productQuantity*item.productSalePrice);
                gstCharge = gstCharge + (item.productQuantity * item.productGSTCharge);
                serviceTax = subTotal * Convert.ToDecimal(label13.Text);
                discount = discount + (Convert.ToDecimal(item.productDiscount) * item.productQuantity * item.productSalePrice);
                totalCost = subTotal + gstCharge + serviceTax - discount;
            }
            label7.Text = string.Format("{0:C}", totalCost); //display the total cost in label 7
            mainTotalCost = totalCost;
        }

        //if enaled in cancel button is change
        private void CancelButton_EnabledChanged(object sender, EventArgs e)
        {
            if (CancelButton.Enabled == true)
            {
                goAdminButton.Enabled = false;
                EndDayButton.Enabled = false;
                ExitButton.Enabled = false;
            }
            else
            {
                goAdminButton.Enabled = true;
                EndDayButton.Enabled = true;
                ExitButton.Enabled = true;
            }
        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            //if product name in add item(label12) is empty then disable the user to enter quantity in text box(quantityTextBox.ReadOnly)
            if (label12.Text == "")
            {
                quantityTextBox.ReadOnly = true;
            }
            else
            {
                quantityTextBox.ReadOnly = false;
            }
        }

        private void cashBox_TextChanged(object sender, EventArgs e)
        {
            //if the cash text box is epty then, disable the confirm button
            if (cashBox.Text == "")
            {
                ConfirmButton.Enabled = false;
            }
            else
            {
                ConfirmButton.Enabled = true;
            }
        }

        //allow the timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label16.Text = DateTime.Now.ToString("hh:mm:ss");
        }

    
        private void SalesPersonMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (quantityTextBox.Text != "")
            {
                //press enter to add quantity without pressing add
                if (e.KeyCode == Keys.Enter)
                {
                    button3_Click((object)sender, (EventArgs)e);
                }
            }

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                //press enter to edit quantity without pressing add
                if (e.KeyCode == Keys.Enter)
                {
                    EditQuantity_Click((object)sender, (EventArgs)e);
                }
            }
        }

        private void cashBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (cashBox.Text != "")
            {
                //press enter to confirm to pay without pressing confirm
                if (e.KeyCode == Keys.Enter)
                {
                    ConfirmButton_Click((object)sender, (EventArgs)e);
                }
            }
        }
    }
}
