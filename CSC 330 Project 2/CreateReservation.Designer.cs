namespace CSC_330_Project_2
{
    partial class CreateReservation
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
            this.nightlyRateLabel = new System.Windows.Forms.Label();
            this.availabilityLabel = new System.Windows.Forms.Label();
            this.numBedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.createReservationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.nightlyRateLabel);
            this.groupBox1.Controls.Add(this.availabilityLabel);
            this.groupBox1.Controls.Add(this.numBedLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.roomList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Info";
            // 
            // nightlyRateLabel
            // 
            this.nightlyRateLabel.AutoSize = true;
            this.nightlyRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.nightlyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightlyRateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nightlyRateLabel.Location = new System.Drawing.Point(303, 86);
            this.nightlyRateLabel.Name = "nightlyRateLabel";
            this.nightlyRateLabel.Size = new System.Drawing.Size(47, 25);
            this.nightlyRateLabel.TabIndex = 6;
            this.nightlyRateLabel.Text = "N/A";
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.availabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.availabilityLabel.Location = new System.Drawing.Point(289, 52);
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(47, 25);
            this.availabilityLabel.TabIndex = 5;
            this.availabilityLabel.Text = "N/A";
            // 
            // numBedLabel
            // 
            this.numBedLabel.AutoSize = true;
            this.numBedLabel.BackColor = System.Drawing.Color.Transparent;
            this.numBedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.numBedLabel.Location = new System.Drawing.Point(340, 20);
            this.numBedLabel.Name = "numBedLabel";
            this.numBedLabel.Size = new System.Drawing.Size(47, 25);
            this.numBedLabel.TabIndex = 4;
            this.numBedLabel.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(162, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "NightlyRate: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(162, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Availability:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(162, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Beds:";
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.Location = new System.Drawing.Point(6, 20);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(120, 147);
            this.roomList.TabIndex = 0;
            this.roomList.SelectedIndexChanged += new System.EventHandler(this.roomList_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guest Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check In Date/Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.errorLabel);
            this.groupBox2.Controls.Add(this.createReservationButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(53, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation Information";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(295, 16);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 7;
            // 
            // createReservationButton
            // 
            this.createReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReservationButton.Location = new System.Drawing.Point(403, 52);
            this.createReservationButton.Name = "createReservationButton";
            this.createReservationButton.Size = new System.Drawing.Size(136, 48);
            this.createReservationButton.TabIndex = 6;
            this.createReservationButton.Text = "Create Reservation";
            this.createReservationButton.UseVisualStyleBackColor = true;
            this.createReservationButton.Click += new System.EventHandler(this.createReservationButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateReservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateReservation_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox roomList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nightlyRateLabel;
        private System.Windows.Forms.Label availabilityLabel;
        private System.Windows.Forms.Label numBedLabel;
        private System.Windows.Forms.Button createReservationButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label errorLabel;
    }
}