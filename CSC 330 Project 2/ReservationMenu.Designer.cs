namespace CSC_330_Project_2
{
    partial class ReservationMenu
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
            this.backButton = new System.Windows.Forms.Button();
            this.createReservation = new System.Windows.Forms.Button();
            this.editReservation = new System.Windows.Forms.Button();
            this.finalize = new System.Windows.Forms.Button();
            this.roomInquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(59, 208);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 43);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createReservation
            // 
            this.createReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createReservation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.createReservation.Location = new System.Drawing.Point(16, 61);
            this.createReservation.Name = "createReservation";
            this.createReservation.Size = new System.Drawing.Size(225, 43);
            this.createReservation.TabIndex = 1;
            this.createReservation.Text = "Create Reservation";
            this.createReservation.UseVisualStyleBackColor = false;
            this.createReservation.Click += new System.EventHandler(this.createReservation_Click);
            // 
            // editReservation
            // 
            this.editReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editReservation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.editReservation.Location = new System.Drawing.Point(16, 110);
            this.editReservation.Name = "editReservation";
            this.editReservation.Size = new System.Drawing.Size(225, 43);
            this.editReservation.TabIndex = 2;
            this.editReservation.Text = "Edit/Delete Reservation";
            this.editReservation.UseVisualStyleBackColor = false;
            this.editReservation.Click += new System.EventHandler(this.editReservation_Click);
            // 
            // finalize
            // 
            this.finalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finalize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.finalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalize.ForeColor = System.Drawing.SystemColors.Control;
            this.finalize.Location = new System.Drawing.Point(16, 159);
            this.finalize.Name = "finalize";
            this.finalize.Size = new System.Drawing.Size(225, 43);
            this.finalize.TabIndex = 3;
            this.finalize.Text = "Finalize Bill";
            this.finalize.UseVisualStyleBackColor = false;
            this.finalize.Click += new System.EventHandler(this.finalize_Click);
            // 
            // roomInquiry
            // 
            this.roomInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomInquiry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roomInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInquiry.ForeColor = System.Drawing.SystemColors.Control;
            this.roomInquiry.Location = new System.Drawing.Point(16, 12);
            this.roomInquiry.Name = "roomInquiry";
            this.roomInquiry.Size = new System.Drawing.Size(225, 43);
            this.roomInquiry.TabIndex = 4;
            this.roomInquiry.Text = "Room Inquiry";
            this.roomInquiry.UseVisualStyleBackColor = false;
            this.roomInquiry.Click += new System.EventHandler(this.roomInquiry_Click);
            // 
            // ReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 265);
            this.Controls.Add(this.roomInquiry);
            this.Controls.Add(this.finalize);
            this.Controls.Add(this.editReservation);
            this.Controls.Add(this.createReservation);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReservationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservationMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createReservation;
        private System.Windows.Forms.Button editReservation;
        private System.Windows.Forms.Button finalize;
        private System.Windows.Forms.Button roomInquiry;
    }
}