namespace CSC_330_Project_2
{
    partial class MainScreen
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
            this.reservation = new System.Windows.Forms.Button();
            this.roomservice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservation
            // 
            this.reservation.Location = new System.Drawing.Point(77, 78);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(120, 23);
            this.reservation.TabIndex = 0;
            this.reservation.Text = "Reservation";
            this.reservation.UseVisualStyleBackColor = true;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // roomservice
            // 
            this.roomservice.Location = new System.Drawing.Point(77, 149);
            this.roomservice.Name = "roomservice";
            this.roomservice.Size = new System.Drawing.Size(120, 23);
            this.roomservice.TabIndex = 1;
            this.roomservice.Text = "Room Service";
            this.roomservice.UseVisualStyleBackColor = true;
            this.roomservice.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.roomservice);
            this.Controls.Add(this.reservation);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Button roomservice;
    }
}

