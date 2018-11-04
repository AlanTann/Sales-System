namespace C_Sharp_Assignment
{
    partial class EndDay
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
            this.receiptListButton = new System.Windows.Forms.Button();
            this.totalProductSaleButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptListButton
            // 
            this.receiptListButton.Location = new System.Drawing.Point(42, 12);
            this.receiptListButton.Name = "receiptListButton";
            this.receiptListButton.Size = new System.Drawing.Size(121, 23);
            this.receiptListButton.TabIndex = 0;
            this.receiptListButton.Text = "Receipt List";
            this.receiptListButton.UseVisualStyleBackColor = true;
            this.receiptListButton.Click += new System.EventHandler(this.receiptListButton_Click);
            // 
            // totalProductSaleButton
            // 
            this.totalProductSaleButton.Location = new System.Drawing.Point(42, 73);
            this.totalProductSaleButton.Name = "totalProductSaleButton";
            this.totalProductSaleButton.Size = new System.Drawing.Size(121, 23);
            this.totalProductSaleButton.TabIndex = 1;
            this.totalProductSaleButton.Text = "Total Product Sale";
            this.totalProductSaleButton.UseVisualStyleBackColor = true;
            this.totalProductSaleButton.Click += new System.EventHandler(this.totalProductSaleButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(42, 102);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(42, 131);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(121, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Receipt List(Product)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(194, 169);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.totalProductSaleButton);
            this.Controls.Add(this.receiptListButton);
            this.Name = "EndDay";
            this.Text = "End Day Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button receiptListButton;
        private System.Windows.Forms.Button totalProductSaleButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
    }
}