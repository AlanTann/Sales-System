using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace C_Sharp_Assignment
{
    public partial class Login : Form
    {
        MainForm mainForm;
        int counter = 0;
        int adminOrUser = 0;
        int lowStockCounter = 0;

        public Login(MainForm mainform2)
        {
            InitializeComponent();
            mainForm = mainform2;
            lowStockCounter = 0;
        }


        //press enter in the password textbox equals to press okay
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginpic_Click((object)sender, (EventArgs)e);
            }
        }

        //exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
        }

        private void exitpic_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private void loginpic_Click(object sender, EventArgs e)
        {
            {
                string userinput;
                string userpass;

                string DbFileLocation = @"D:\SampleDatabase.mdf";
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + DbFileLocation + "; Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString); //connect the database with connection string
                con.Open(); //open the database

                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandText = "SELECT COUNT(*) FROM UserTable";
                Int32 count = (Int32)cmd.ExecuteScalar();

                userinput = username.Text;
                userpass = password.Text;

                //loop through the database
                for (int i = 1; i <= count; i++)
                {
                    cmd.CommandText = "SELECT UserName FROM UserTable WHERE ID = " + i;
                    string useroutput = (String)cmd.ExecuteScalar();
                    cmd.CommandText = "SELECT Password FROM UserTable WHERE ID = " + i;
                    string passoutput = (String)cmd.ExecuteScalar();

                    // if the data of username and password is match with the data in database
                    if (userinput == useroutput && userpass == passoutput)
                    {
                        cmd.CommandText = "SELECT UserOrAdmin FROM UserTable WHERE ID = " + i;
                        int userOrAdmin = (int)cmd.ExecuteScalar();
                        if (userOrAdmin == 1) //if the user is a salesman then go to Sales Menu
                        {
                            adminOrUser = 1;
                            this.Hide();
                            SalesPersonMenu salesMenu = new SalesPersonMenu(mainForm, adminOrUser);
                            salesMenu.ShowDialog();
                            this.Close();
                        }
                        else if (userOrAdmin == 2)  //if the user is an admin then go to Sales Menu
                        {
                            adminOrUser = 2;

                            var query =
                                from value in mainForm.FoodMenuList
                                where value.productQuantity < 10
                                select value;

                            //loop through the item in food menu list
                            foreach (var item in query)
                            {
                                //if there is any product quantity less than 10 then assign lock stock counter as 1
                                lowStockCounter = 1;
                            }

                            //if there is any product that is low stock, then display messgaeox
                            if (lowStockCounter == 1)
                            {
                                MessageBox.Show("Low of Stock.",
                                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            }

                            this.Hide();
                            Admin admin = new Admin(mainForm, adminOrUser); //goto admin form
                            admin.ShowDialog();
                            this.Close();
                        }
                    }
                    //if the username and password is not correct
                    else if ((userinput != useroutput || userpass != passoutput) && i == count)
                    {
                        counter = counter + 1;

                        //display the count of the wrong input in the message box
                        MessageBox.Show("Not Correct, Try " + counter + " times. Close at 5th Counter");
                        if (counter == 5)
                            this.Close();
                    }
                }
                con.Close();
            }

        }

        private void loginpic_MouseHover(object sender, EventArgs e)
        {
           this.loginpic.Image = ((System.Drawing.Image)(Properties.Resources.loginglow));
         }
        private void loginpic_MouseLeave(object sender, EventArgs e)
        {
            this.loginpic.Image = ((System.Drawing.Image)(Properties.Resources.login));
        }
        private void exitpic_MouseHover(object sender, EventArgs e)
        {
            exitpic.Image = ((System.Drawing.Image)(Properties.Resources.exitglow));

        }

        private void exitpic_MouseLeave(object sender, EventArgs e)
        {
            exitpic.Image = ((System.Drawing.Image)(Properties.Resources.exit));

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
