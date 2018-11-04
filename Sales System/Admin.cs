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
    public partial class Admin : Form
    {
        MainForm mainForm;
        int adminOrUser = 2;

        public Admin(MainForm mainForm2, int adminOrUser2)
        {
            InitializeComponent();
            mainForm = mainForm2;
        }

        public Admin(MainForm mainForm2)
        {
            InitializeComponent();
            mainForm = mainForm2;
        }


        //go to Add,Update,Delete form
        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin1 = new AdminMenu(mainForm);
            admin1.ShowDialog();
            this.Close();
        }

        //go to admin search form
        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuSearch adminSearch = new AdminMenuSearch(mainForm);
            adminSearch.ShowDialog();
            this.Close();
        }

        //go to modify quantity form
        private void modifyQuantity_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify_Quantity modifyQuantity = new Modify_Quantity(mainForm);
            modifyQuantity.ShowDialog();
            this.Close();
        }

        //go to log out form
        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(mainForm);
            login.ShowDialog();
            this.Close();
        }

        //go to manage stock form
        private void manageStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock manageStock = new ManageStock(mainForm);
            manageStock.ShowDialog();
            this.Close();
        }

        //go to sale menu form
        private void saleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPersonMenu salesMenu = new SalesPersonMenu(mainForm, adminOrUser);
            salesMenu.ShowDialog();
            this.Close();
        }

        //go to report form 
        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EndDay endDay = new EndDay(mainForm, adminOrUser);
            endDay.ShowDialog();
            this.Close();
        }

        //go to create user form
        private void createUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount create = new CreateAccount(mainForm);
            create.ShowDialog();
            this.Close();
        }

        //go to exit form
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
