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
    public partial class MainForm : Form
    {
        public List<Food> _foodMenuList = new List<Food> {
                new Food("Beef Burger", "Food", 200, 0.1, 4.9M, 0.30M, 7.0M),
                new Food("Chicken Pie", "Food", 210, 0, 4.0M, 0.24M, 6.5M),
                new Food("Fish", "Food", 150, 0, 4.5M, 0.27M, 6.8M),
                new Food("Meat", "Food", 100, 0, 3.5M, 0.21M, 5.5M),
                new Food("Veggie", "Food", 200, 0, 3M, 0.18M, 5.2M),
                new Food("Chicken and Mushroom", "Food", 300,0,3.9M,0.23M, 6.9M),
                new Food("Egg Burger", "Food", 100, 0.2, 2.5M, 0.21M, 3.5M),
                new Food("Soda Large", "Drinks", 100,0.1,1.95M,0.12M, 2.5M),
                new Food("Soda Small", "Drinks", 100,0.1,1.55M,0.09M, 2.0M),
                new Food("Hot Drink", "Drinks", 100,0,1.85M, 0.11M, 2.2M),
                new Food("Juice Drink Large", "Drinks", 100,0,2.95M,0.18M, 3.4M),
                new Food("Juice Drink Small", "Drinks", 100,0,2.45M,0.15M, 3M),
                new Food("Mineral Water", "Drinks", 100,0,1.25M,0.08M, 1.5M)
        };
        public List<tempProductRec> _tempFoodList = new List<tempProductRec>();
        public List<Receipt> _receipt = new List<Receipt>();
        public List<ReceiptFoodList> _receiptListFood = new List<ReceiptFoodList>();
        public List<TotalProductSale> _totalProductSaleList = new List<TotalProductSale> {
            new TotalProductSale("Beef Burger", "Food", 200, 0.1, 4.9M, 0.30M, 7.0M),
                new TotalProductSale("Chicken Pie", "Food", 210, 0, 4.0M, 0.24M, 6.5M),
                new TotalProductSale("Fish", "Food", 150, 0, 4.5M, 0.27M, 6.8M),
                new TotalProductSale("Meat", "Food", 100, 0, 3.5M, 0.21M, 5.5M),
                new TotalProductSale("Veggie", "Food", 200, 0, 3M, 0.18M, 5.2M),
                new TotalProductSale("Chicken and Mushroom", "Food", 300,0,3.9M,0.23M, 6.9M),
                new TotalProductSale("Egg Burger", "Food", 100, 0.2, 2.5M, 0.21M, 3.5M),
                new TotalProductSale("Soda Large", "Drinks", 100,0.1,1.95M,0.12M, 2.5M),
                new TotalProductSale("Soda Small", "Drinks", 100,0.1,1.55M,0.09M, 2.0M),
                new TotalProductSale("Hot Drink", "Drinks", 100,0,1.85M, 0.11M, 2.2M),
                new TotalProductSale("Juice Drink Large", "Drinks", 100,0,2.95M,0.18M, 3.4M),
                new TotalProductSale("Juice Drink Small", "Drinks", 100,0,2.45M,0.15M, 3M),
                new TotalProductSale("Mineral Water", "Drinks", 100,0,1.25M,0.08M, 1.5M)
        };


        public MainForm()
        {
            InitializeComponent();
        }

        public List<tempProductRec> TempFoodList
        {
            get { return _tempFoodList; }
            set { _tempFoodList = value; }
        }

        public List<Food> FoodMenuList
        {
            get { return _foodMenuList; }
            set { _foodMenuList = value; }
        }

        public List<TotalProductSale> TotalProductSaleList
        {
            get { return _totalProductSaleList; }
            set { _totalProductSaleList = value; }
        }

        public List<Receipt> ReceiptList
        {
            get { return _receipt; }
            set { _receipt = value; }
        }

        public List<ReceiptFoodList> ReceiptListFood
        {
            get { return _receiptListFood; }
            set { _receiptListFood = value; }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(this);
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

            this.pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.welc0me));

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = ((System.Drawing.Image)(Properties.Resources.w2_test));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(this);
            login.ShowDialog();
            this.Close();
        }
    }
}
