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
            this.reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reservation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation.ForeColor = System.Drawing.SystemColors.Control;
            this.reservation.Location = new System.Drawing.Point(42, 32);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(200, 80);
            this.reservation.TabIndex = 0;
            this.reservation.Text = "Reservation";
            this.reservation.UseVisualStyleBackColor = false;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // roomservice
            // 
            this.roomservice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomservice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roomservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomservice.ForeColor = System.Drawing.SystemColors.Control;
            this.roomservice.Location = new System.Drawing.Point(42, 149);
            this.roomservice.Name = "roomservice";
            this.roomservice.Size = new System.Drawing.Size(200, 80);
            this.roomservice.TabIndex = 1;
            this.roomservice.Text = "Room Service";
            this.roomservice.UseVisualStyleBackColor = false;
            this.roomservice.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.roomservice);
            this.Controls.Add(this.reservation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Button roomservice;
    }
}

