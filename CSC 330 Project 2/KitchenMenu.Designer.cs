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
            this.foodList = new System.Windows.Forms.GroupBox();
            this.drinkList = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // foodList
            // 
            this.foodList.BackColor = System.Drawing.Color.Maroon;
            this.foodList.ForeColor = System.Drawing.SystemColors.Control;
            this.foodList.Location = new System.Drawing.Point(13, 13);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(200, 306);
            this.foodList.TabIndex = 0;
            this.foodList.TabStop = false;
            this.foodList.Text = "Food";
            // 
            // drinkList
            // 
            this.drinkList.BackColor = System.Drawing.Color.RosyBrown;
            this.drinkList.Location = new System.Drawing.Point(219, 13);
            this.drinkList.Name = "drinkList";
            this.drinkList.Size = new System.Drawing.Size(200, 306);
            this.drinkList.TabIndex = 1;
            this.drinkList.TabStop = false;
            this.drinkList.Text = "Drink";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(426, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 306);
            this.panel1.TabIndex = 2;
            // 
            // KitchenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drinkList);
            this.Controls.Add(this.foodList);
            this.Name = "KitchenMenu";
            this.Text = "KitchenMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitchenMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox foodList;
        private System.Windows.Forms.GroupBox drinkList;
        private System.Windows.Forms.Panel panel1;
    }
}