namespace CSC_330_Project_2
{
    partial class CreateOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.drinkList = new System.Windows.Forms.ListBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.foodList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentOrderList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendKitchen = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(22, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Info";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(104, 50);
            this.itemPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(0, 20);
            this.itemPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Price: $";
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(104, 20);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(0, 20);
            this.itemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.RosyBrown;
            this.group2.Controls.Add(this.drinkList);
            this.group2.Location = new System.Drawing.Point(228, 98);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(200, 306);
            this.group2.TabIndex = 4;
            this.group2.TabStop = false;
            this.group2.Text = "Drink";
            // 
            // drinkList
            // 
            this.drinkList.FormattingEnabled = true;
            this.drinkList.Location = new System.Drawing.Point(6, 19);
            this.drinkList.Name = "drinkList";
            this.drinkList.Size = new System.Drawing.Size(188, 277);
            this.drinkList.TabIndex = 2;
            this.drinkList.SelectedIndexChanged += new System.EventHandler(this.drinkList_SelectedIndexChanged);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.Maroon;
            this.group1.Controls.Add(this.foodList);
            this.group1.ForeColor = System.Drawing.SystemColors.Control;
            this.group1.Location = new System.Drawing.Point(22, 98);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(200, 306);
            this.group1.TabIndex = 3;
            this.group1.TabStop = false;
            this.group1.Text = "Food";
            // 
            // foodList
            // 
            this.foodList.FormattingEnabled = true;
            this.foodList.Location = new System.Drawing.Point(6, 19);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(188, 277);
            this.foodList.TabIndex = 1;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.foodList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.currentOrderList);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(434, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 306);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Order";
            // 
            // currentOrderList
            // 
            this.currentOrderList.FormattingEnabled = true;
            this.currentOrderList.Location = new System.Drawing.Point(6, 19);
            this.currentOrderList.Name = "currentOrderList";
            this.currentOrderList.Size = new System.Drawing.Size(188, 277);
            this.currentOrderList.TabIndex = 2;
            this.currentOrderList.SelectedIndexChanged += new System.EventHandler(this.currentOrderList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Maroon;
            this.groupBox3.Controls.Add(this.sendKitchen);
            this.groupBox3.Controls.Add(this.deleteOrder);
            this.groupBox3.Controls.Add(this.addOrder);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(335, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 122);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu Controls";
            // 
            // sendKitchen
            // 
            this.sendKitchen.AutoSize = true;
            this.sendKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendKitchen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendKitchen.Location = new System.Drawing.Point(49, 89);
            this.sendKitchen.Name = "sendKitchen";
            this.sendKitchen.Size = new System.Drawing.Size(146, 30);
            this.sendKitchen.TabIndex = 10;
            this.sendKitchen.Text = "Send To Kitchen";
            this.sendKitchen.UseVisualStyleBackColor = true;
            this.sendKitchen.Click += new System.EventHandler(this.sendKitchen_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.AutoSize = true;
            this.deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteOrder.Location = new System.Drawing.Point(49, 55);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(146, 30);
            this.deleteOrder.TabIndex = 9;
            this.deleteOrder.Text = "Delete from Order";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.AutoSize = true;
            this.addOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addOrder.Location = new System.Drawing.Point(67, 19);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(110, 30);
            this.addOrder.TabIndex = 8;
            this.addOrder.Text = "Add to Order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.number);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Location = new System.Drawing.Point(22, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 79);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guest Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guest Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room Number:";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(117, 45);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 9;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(117, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 8;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(399, 13);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 19;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 575);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.ListBox drinkList;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox currentOrderList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button sendKitchen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
    }
}