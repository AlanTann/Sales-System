namespace C_Sharp_Assignment
{
    partial class AdminMenu
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
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label gST_IDLabel;
            System.Windows.Forms.Label product_QuantityLabel;
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.gstPriceTextBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.editItemButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.DeleteValidButton = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            product_NameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            gST_IDLabel = new System.Windows.Forms.Label();
            product_QuantityLabel = new System.Windows.Forms.Label();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.BackColor = System.Drawing.Color.Transparent;
            product_NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            product_NameLabel.Location = new System.Drawing.Point(38, 33);
            product_NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(117, 17);
            product_NameLabel.TabIndex = 35;
            product_NameLabel.Text = "Product Name:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = System.Drawing.Color.Transparent;
            typeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            typeLabel.Location = new System.Drawing.Point(112, 67);
            typeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(49, 17);
            typeLabel.TabIndex = 37;
            typeLabel.Text = "Type:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            priceLabel.Location = new System.Drawing.Point(87, 105);
            priceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(80, 17);
            priceLabel.TabIndex = 39;
            priceLabel.Text = "Quantity:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.BackColor = System.Drawing.Color.Transparent;
            discountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            discountLabel.Location = new System.Drawing.Point(12, 139);
            discountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(146, 17);
            discountLabel.TabIndex = 41;
            discountLabel.Text = "Discount(decimal):";
            // 
            // gST_IDLabel
            // 
            gST_IDLabel.AutoSize = true;
            gST_IDLabel.BackColor = System.Drawing.Color.Transparent;
            gST_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            gST_IDLabel.Location = new System.Drawing.Point(48, 177);
            gST_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            gST_IDLabel.Name = "gST_IDLabel";
            gST_IDLabel.Size = new System.Drawing.Size(117, 17);
            gST_IDLabel.TabIndex = 43;
            gST_IDLabel.Text = "Original Price:";
            // 
            // product_QuantityLabel
            // 
            product_QuantityLabel.AutoSize = true;
            product_QuantityLabel.BackColor = System.Drawing.Color.Transparent;
            product_QuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            product_QuantityLabel.Location = new System.Drawing.Point(63, 216);
            product_QuantityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            product_QuantityLabel.Name = "product_QuantityLabel";
            product_QuantityLabel.Size = new System.Drawing.Size(97, 17);
            product_QuantityLabel.TabIndex = 45;
            product_QuantityLabel.Text = "Gst Charge:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.Location = new System.Drawing.Point(178, 24);
            this.product_NameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(164, 24);
            this.product_NameTextBox.TabIndex = 36;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(178, 63);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(164, 24);
            this.typeTextBox.TabIndex = 38;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(178, 101);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(164, 24);
            this.quantityTextBox.TabIndex = 40;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(178, 139);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(164, 24);
            this.discountTextBox.TabIndex = 42;
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(178, 173);
            this.originalPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(164, 24);
            this.originalPriceTextBox.TabIndex = 44;
            this.originalPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.originalPriceTextBox_KeyPress);
            // 
            // gstPriceTextBox
            // 
            this.gstPriceTextBox.Location = new System.Drawing.Point(178, 212);
            this.gstPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gstPriceTextBox.Name = "gstPriceTextBox";
            this.gstPriceTextBox.Size = new System.Drawing.Size(164, 24);
            this.gstPriceTextBox.TabIndex = 46;
            this.gstPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gstPriceTextBox_KeyPress);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(335, 75);
            this.delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(145, 30);
            this.delete.TabIndex = 51;
            this.delete.Text = "Confirm Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(10, 75);
            this.Add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 30);
            this.Add.TabIndex = 49;
            this.Add.Text = "Confirm Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1215, 435);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 30);
            this.Back.TabIndex = 47;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader14});
            this.listView1.Location = new System.Drawing.Point(622, 24);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 320);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Discount";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Original Price";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gst Charge";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Sale Price";
            this.columnHeader14.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Sale Price:";
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(178, 245);
            this.salePriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(164, 24);
            this.salePriceTextBox.TabIndex = 54;
            this.salePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salePriceTextBox_KeyPress);
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(170, 75);
            this.editItemButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(150, 30);
            this.editItemButton.TabIndex = 55;
            this.editItemButton.Text = "Confirm Edit";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 25);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 30);
            this.addButton.TabIndex = 56;
            this.addButton.Text = "Add new item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(170, 25);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 30);
            this.editButton.TabIndex = 57;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // DeleteValidButton
            // 
            this.DeleteValidButton.Location = new System.Drawing.Point(335, 25);
            this.DeleteValidButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteValidButton.Name = "DeleteValidButton";
            this.DeleteValidButton.Size = new System.Drawing.Size(145, 30);
            this.DeleteValidButton.TabIndex = 58;
            this.DeleteValidButton.Text = "Delete";
            this.DeleteValidButton.UseVisualStyleBackColor = true;
            this.DeleteValidButton.Click += new System.EventHandler(this.DeleteValidButton_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.cancelButton);
            this.Options.Controls.Add(this.addButton);
            this.Options.Controls.Add(this.DeleteValidButton);
            this.Options.Controls.Add(this.Add);
            this.Options.Controls.Add(this.editItemButton);
            this.Options.Controls.Add(this.delete);
            this.Options.Controls.Add(this.editButton);
            this.Options.Location = new System.Drawing.Point(25, 298);
            this.Options.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Options.Size = new System.Drawing.Size(490, 167);
            this.Options.TabIndex = 59;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(170, 126);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 30);
            this.cancelButton.TabIndex = 59;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1354, 502);
            this.ControlBox = false;
            this.Controls.Add(this.Options);
            this.Controls.Add(this.salePriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(gST_IDLabel);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(product_QuantityLabel);
            this.Controls.Add(this.gstPriceTextBox);
            this.Font = new System.Drawing.Font("Century", 10.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminMenu";
            this.Text = "Add, Update, Delete";
            this.Options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox gstPriceTextBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button DeleteValidButton;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button cancelButton;
    }
}