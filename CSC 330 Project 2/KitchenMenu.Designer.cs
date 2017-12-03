namespace CSC_330_Project_2
{
    partial class KitchenMenu
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
            this.group1 = new System.Windows.Forms.GroupBox();
            this.foodList = new System.Windows.Forms.ListBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.drinkList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.Maroon;
            this.group1.Controls.Add(this.foodList);
            this.group1.ForeColor = System.Drawing.SystemColors.Control;
            this.group1.Location = new System.Drawing.Point(50, 13);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(200, 306);
            this.group1.TabIndex = 0;
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
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.RosyBrown;
            this.group2.Controls.Add(this.drinkList);
            this.group2.Location = new System.Drawing.Point(256, 13);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(200, 306);
            this.group2.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(463, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 96);
            this.groupBox1.TabIndex = 2;
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
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // KitchenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 331);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Name = "KitchenMenu";
            this.Text = "KitchenMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitchenMenu_FormClosing);
            this.group1.ResumeLayout(false);
            this.group2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.ListBox drinkList;
        private System.Windows.Forms.Button backButton;
    }
}