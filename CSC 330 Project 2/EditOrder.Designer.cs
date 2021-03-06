﻿namespace CSC_330_Project_2
{
    partial class EditOrder
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.sendKitchen = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentOrderList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.drinkList = new System.Windows.Forms.ListBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.foodList = new System.Windows.Forms.ListBox();
            this.ordersList = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.orderTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(161, 7);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(48, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.number);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(12, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 156);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guest Information";
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(117, 46);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(121, 26);
            this.number.TabIndex = 1;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged_1);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(117, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 26);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
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
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.deleteOrderButton);
            this.groupBox3.Controls.Add(this.sendKitchen);
            this.groupBox3.Controls.Add(this.deleteOrder);
            this.groupBox3.Controls.Add(this.addOrder);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 187);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu Controls";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.BackColor = System.Drawing.Color.DarkGray;
            this.deleteOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteOrderButton.Location = new System.Drawing.Point(40, 141);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(170, 34);
            this.deleteOrderButton.TabIndex = 10;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = false;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // sendKitchen
            // 
            this.sendKitchen.BackColor = System.Drawing.Color.DarkGray;
            this.sendKitchen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendKitchen.ForeColor = System.Drawing.SystemColors.Control;
            this.sendKitchen.Location = new System.Drawing.Point(40, 99);
            this.sendKitchen.Name = "sendKitchen";
            this.sendKitchen.Size = new System.Drawing.Size(170, 36);
            this.sendKitchen.TabIndex = 9;
            this.sendKitchen.Text = "Send To Kitchen";
            this.sendKitchen.UseVisualStyleBackColor = false;
            this.sendKitchen.Click += new System.EventHandler(this.sendKitchen_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.DarkGray;
            this.deleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteOrder.Location = new System.Drawing.Point(40, 59);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(170, 34);
            this.deleteOrder.TabIndex = 8;
            this.deleteOrder.Text = "Delete from Order";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.Color.DarkGray;
            this.addOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.addOrder.Location = new System.Drawing.Point(40, 19);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(170, 34);
            this.addOrder.TabIndex = 7;
            this.addOrder.Text = "Add to Order";
            this.addOrder.UseVisualStyleBackColor = false;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.currentOrderList);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(765, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 306);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Order";
            // 
            // currentOrderList
            // 
            this.currentOrderList.BackColor = System.Drawing.Color.LightGray;
            this.currentOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOrderList.FormattingEnabled = true;
            this.currentOrderList.ItemHeight = 24;
            this.currentOrderList.Location = new System.Drawing.Point(6, 19);
            this.currentOrderList.Name = "currentOrderList";
            this.currentOrderList.Size = new System.Drawing.Size(188, 268);
            this.currentOrderList.TabIndex = 6;
            this.currentOrderList.SelectedIndexChanged += new System.EventHandler(this.currentOrderList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(285, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 96);
            this.groupBox1.TabIndex = 23;
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
            this.group2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group2.Controls.Add(this.drinkList);
            this.group2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group2.ForeColor = System.Drawing.SystemColors.Control;
            this.group2.Location = new System.Drawing.Point(525, 71);
            this.group2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(200, 306);
            this.group2.TabIndex = 21;
            this.group2.TabStop = false;
            this.group2.Text = "Drink";
            // 
            // drinkList
            // 
            this.drinkList.BackColor = System.Drawing.Color.LightGray;
            this.drinkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkList.FormattingEnabled = true;
            this.drinkList.ItemHeight = 24;
            this.drinkList.Location = new System.Drawing.Point(6, 19);
            this.drinkList.Name = "drinkList";
            this.drinkList.Size = new System.Drawing.Size(188, 268);
            this.drinkList.TabIndex = 5;
            this.drinkList.SelectedIndexChanged += new System.EventHandler(this.drinkList_SelectedIndexChanged);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group1.Controls.Add(this.foodList);
            this.group1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1.ForeColor = System.Drawing.SystemColors.Control;
            this.group1.Location = new System.Drawing.Point(285, 71);
            this.group1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(200, 306);
            this.group1.TabIndex = 20;
            this.group1.TabStop = false;
            this.group1.Text = "Food";
            // 
            // foodList
            // 
            this.foodList.BackColor = System.Drawing.Color.LightGray;
            this.foodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodList.FormattingEnabled = true;
            this.foodList.ItemHeight = 24;
            this.foodList.Location = new System.Drawing.Point(6, 19);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(188, 268);
            this.foodList.TabIndex = 4;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.foodList_SelectedIndexChanged);
            // 
            // ordersList
            // 
            this.ordersList.BackColor = System.Drawing.Color.LightGray;
            this.ordersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ordersList.FormattingEnabled = true;
            this.ordersList.ItemHeight = 24;
            this.ordersList.Location = new System.Drawing.Point(12, 18);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(226, 100);
            this.ordersList.TabIndex = 3;
            this.ordersList.SelectedIndexChanged += new System.EventHandler(this.ordersList_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.ordersList);
            this.groupBox5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(12, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 136);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orders List";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox6.Controls.Add(this.orderTotal);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(748, 394);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 96);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total";
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotal.Location = new System.Drawing.Point(111, 38);
            this.orderTotal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(0, 20);
            this.orderTotal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Order Total: $";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(263, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(719, 58);
            this.label6.TabIndex = 31;
            this.label6.Text = "Directions: To edit an order, enter the name on the reservation, and reservation " +
    "room number. Then select an order from the left-hand list to view contents and e" +
    "dit.";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(12, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 58);
            this.button4.TabIndex = 35;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 577);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditOrder_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sendKitchen;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox currentOrderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.ListBox drinkList;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.ListBox ordersList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label orderTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}