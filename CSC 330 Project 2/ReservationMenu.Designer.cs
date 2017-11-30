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
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createReservation
            // 
            this.createReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReservation.Location = new System.Drawing.Point(89, 51);
            this.createReservation.Name = "createReservation";
            this.createReservation.Size = new System.Drawing.Size(190, 43);
            this.createReservation.TabIndex = 1;
            this.createReservation.Text = "Create Reservation";
            this.createReservation.UseVisualStyleBackColor = true;
            this.createReservation.Click += new System.EventHandler(this.createReservation_Click);
            // 
            // editReservation
            // 
            this.editReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReservation.Location = new System.Drawing.Point(72, 103);
            this.editReservation.Name = "editReservation";
            this.editReservation.Size = new System.Drawing.Size(225, 43);
            this.editReservation.TabIndex = 2;
            this.editReservation.Text = "Edit/Delete Reservation";
            this.editReservation.UseVisualStyleBackColor = true;
            this.editReservation.Click += new System.EventHandler(this.editReservation_Click);
            // 
            // finalize
            // 
            this.finalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalize.Location = new System.Drawing.Point(89, 152);
            this.finalize.Name = "finalize";
            this.finalize.Size = new System.Drawing.Size(190, 43);
            this.finalize.TabIndex = 3;
            this.finalize.Text = "Finalize Bill";
            this.finalize.UseVisualStyleBackColor = true;
            this.finalize.Click += new System.EventHandler(this.finalize_Click);
            // 
            // ReservationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 247);
            this.Controls.Add(this.finalize);
            this.Controls.Add(this.editReservation);
            this.Controls.Add(this.createReservation);
            this.Controls.Add(this.backButton);
            this.Name = "ReservationMenu";
            this.Text = "ReservationMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createReservation;
        private System.Windows.Forms.Button editReservation;
        private System.Windows.Forms.Button finalize;
    }
}