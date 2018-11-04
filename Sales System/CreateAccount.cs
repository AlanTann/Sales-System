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
    public partial class CreateAccount : Form
    {
        MainForm mainForm;
        public CreateAccount(MainForm mainForm2)
        {
            InitializeComponent();
            mainForm = mainForm2;
        }

        //create account for user/admin and add it to database
        private void button1_Click(object sender, EventArgs e)
        {
            //validate if there is any empty text box
            if (validateEmptyBox() == false)
            {
                int adminOrUser = 0;
                string DbFileLocation = @"D:\SampleDatabase.mdf"; 
                string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + DbFileLocation + "; Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString); //connect the database with the connection string
                con.Open();
                string sql = "INSERT INTO UserTable(UserName,Password,UserOrAdmin)";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (username.Text != "" && password.Text != "")
                {
                    //to check whether the value in admin/user value does not exceed 2
                    if (Convert.ToInt32(access.Text) > 2 && Convert.ToInt32(access.Text) >= 1)
                    {
                        MessageBox.Show("Invalid input  of user and admin");
                    }
                    else
                    {
                        cmd.CommandText = "insert into UserTable(UserName,Password,UserOrAdmin)" +
                           " values ('" + username.Text + "','" + password.Text + "','" + adminOrUser + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created!");
                    }
                }
                else
                {
                    MessageBox.Show("username or password cannot be empty");
                }
                con.Close();
                username.Text = "";
                password.Text = "";
                access.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all the text box");
            }
        }

        //back to the admin form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(mainForm);
            admin.ShowDialog();
            this.Close();
        }

        //only allow numeric/integer value in access text box
        private void access_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(access, "Enter 1 as User, 2 as Admin");
        }
        //show the tool tip when the user hover to the admin/user text box
        private void access_MouseHover(object sender, EventArgs e)
        {
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(access, "Enter 1 as User, 2 as Admin");
        }

        //if there is change in text in the admin/user text ox
        private void access_TextChanged(object sender, EventArgs e)
        {
            
            if (access.Text == "")// if the value in admin/user text box is empty then display label3(instructions)
            {
                label3.Visible = true;
            }
            else if (Convert.ToInt32(access.Text) == 1 || Convert.ToInt32(access.Text) == 2)
            {
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(access, "Enter 1 as User, 2 as Admin");
        }

        //validate if there is any empty text box
        private Boolean validateEmptyBox()
        {
            if (username.Text == "" || password.Text == "" || access.Text == "")
            {
                return true;//if there is any empty textbox then return true
            }
            else
            {
                return false;
            }
        }

        private void access_KeyDown(object sender, KeyEventArgs e)
        {
            if (access.Text != "" && username.Text != "" && password.Text != "")
            {
                //press enter to add or edit quantity without pressing add
                if (e.KeyCode == Keys.Enter)
                {
                    button1_Click((object)sender, (EventArgs)e);
                }
            }
        }
    }
}
