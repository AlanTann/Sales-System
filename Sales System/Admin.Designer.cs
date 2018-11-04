namespace C_Sharp_Assignment
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Update = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.modifyQuantity = new System.Windows.Forms.Button();
            this.manageStock = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(142, 129);
            this.Update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(180, 30);
            this.Update.TabIndex = 1;
            this.Update.Text = "Add,Update,Delete";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(142, 205);
            this.reportButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(180, 30);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(142, 281);
            this.logOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(180, 30);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(142, 92);
            this.Search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 30);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // modifyQuantity
            // 
            this.modifyQuantity.Location = new System.Drawing.Point(142, 167);
            this.modifyQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.modifyQuantity.Name = "modifyQuantity";
            this.modifyQuantity.Size = new System.Drawing.Size(180, 30);
            this.modifyQuantity.TabIndex = 6;
            this.modifyQuantity.Text = "Modify Quantity";
            this.modifyQuantity.UseVisualStyleBackColor = true;
            this.modifyQuantity.Click += new System.EventHandler(this.modifyQuantity_Click);
            // 
            // manageStock
            // 
            this.manageStock.Location = new System.Drawing.Point(142, 243);
            this.manageStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.manageStock.Name = "manageStock";
            this.manageStock.Size = new System.Drawing.Size(180, 30);
            this.manageStock.TabIndex = 7;
            this.manageStock.Text = "Manage Stock";
            this.manageStock.UseVisualStyleBackColor = true;
            this.manageStock.Click += new System.EventHandler(this.manageStock_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(142, 16);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(180, 30);
            this.createUserButton.TabIndex = 8;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(142, 54);
            this.saleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(180, 30);
            this.saleButton.TabIndex = 9;
            this.saleButton.Text = "Sales";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(142, 320);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 30);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 362);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.manageStock);
            this.Controls.Add(this.modifyQuantity);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.Update);
            this.Font = new System.Drawing.Font("Century", 10.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button modifyQuantity;
        private System.Windows.Forms.Button manageStock;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button exitButton;
    }
}

