namespace Vehicle_Rent_and_Booking_System
{
    partial class Form5
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
            dashboardbtn = new Button();
            signbtn = new Button();
            penaltycomputationbtn = new Button();
            rentbtn = new Button();
            rentalrecordbtn = new Button();
            fleetbtn = new Button();
            vehiclecbox = new ComboBox();
            returndatepicker = new DateTimePicker();
            pickupdatepicker = new DateTimePicker();
            panel1 = new Panel();
            duration = new TextBox();
            dailyrate = new TextBox();
            computation = new TextBox();
            total = new TextBox();
            btn = new Button();
            pickupbranch = new TextBox();
            SuspendLayout();
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.ForestGreen;
            dashboardbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 143);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(382, 104);
            dashboardbtn.TabIndex = 23;
            dashboardbtn.Text = "DASHBOARD";
            dashboardbtn.UseVisualStyleBackColor = false;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.ForestGreen;
            signbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(63, 922);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(284, 64);
            signbtn.TabIndex = 22;
            signbtn.Text = "SIGN OUT ";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click_1;
            // 
            // penaltycomputationbtn
            // 
            penaltycomputationbtn.BackColor = Color.ForestGreen;
            penaltycomputationbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penaltycomputationbtn.Location = new Point(19, 676);
            penaltycomputationbtn.Name = "penaltycomputationbtn";
            penaltycomputationbtn.Size = new Size(382, 104);
            penaltycomputationbtn.TabIndex = 21;
            penaltycomputationbtn.Text = "PENALTY COMPUTATION";
            penaltycomputationbtn.UseVisualStyleBackColor = false;
            penaltycomputationbtn.Click += penaltycomputationbtn_Click;
            // 
            // rentbtn
            // 
            rentbtn.BackColor = Color.ForestGreen;
            rentbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentbtn.Location = new Point(13, 530);
            rentbtn.Name = "rentbtn";
            rentbtn.Size = new Size(382, 104);
            rentbtn.TabIndex = 20;
            rentbtn.Text = "RENT";
            rentbtn.UseVisualStyleBackColor = false;
            // 
            // rentalrecordbtn
            // 
            rentalrecordbtn.BackColor = Color.ForestGreen;
            rentalrecordbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalrecordbtn.Location = new Point(13, 392);
            rentalrecordbtn.Name = "rentalrecordbtn";
            rentalrecordbtn.Size = new Size(389, 104);
            rentalrecordbtn.TabIndex = 19;
            rentalrecordbtn.Text = "RENTAL RECORD";
            rentalrecordbtn.UseVisualStyleBackColor = false;
            rentalrecordbtn.Click += rentalrecordbtn_Click;
            // 
            // fleetbtn
            // 
            fleetbtn.BackColor = Color.ForestGreen;
            fleetbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fleetbtn.Location = new Point(12, 268);
            fleetbtn.Name = "fleetbtn";
            fleetbtn.Size = new Size(382, 104);
            fleetbtn.TabIndex = 18;
            fleetbtn.Text = "FLEET";
            fleetbtn.UseVisualStyleBackColor = false;
            fleetbtn.Click += fleetbtn_Click;
            // 
            // vehiclecbox
            // 
            vehiclecbox.Font = new Font("Segoe UI", 20F);
            vehiclecbox.FormattingEnabled = true;
            vehiclecbox.Location = new Point(603, 252);
            vehiclecbox.Name = "vehiclecbox";
            vehiclecbox.Size = new Size(457, 45);
            vehiclecbox.TabIndex = 24;
            // 
            // returndatepicker
            // 
            returndatepicker.CalendarFont = new Font("Segoe UI", 13F);
            returndatepicker.Font = new Font("Segoe UI", 20F);
            returndatepicker.Location = new Point(616, 566);
            returndatepicker.Name = "returndatepicker";
            returndatepicker.Size = new Size(444, 43);
            returndatepicker.TabIndex = 26;
            // 
            // pickupdatepicker
            // 
            pickupdatepicker.CalendarFont = new Font("Segoe UI", 13F);
            pickupdatepicker.Font = new Font("Segoe UI", 20F);
            pickupdatepicker.Location = new Point(1302, 410);
            pickupdatepicker.Name = "pickupdatepicker";
            pickupdatepicker.Size = new Size(444, 43);
            pickupdatepicker.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Location = new Point(1271, 515);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 100);
            panel1.TabIndex = 28;
            // 
            // duration
            // 
            duration.Font = new Font("Segoe UI", 15F);
            duration.Location = new Point(1293, 676);
            duration.Name = "duration";
            duration.ReadOnly = true;
            duration.Size = new Size(146, 34);
            duration.TabIndex = 29;
            duration.TextChanged += duration_TextChanged;
            // 
            // dailyrate
            // 
            dailyrate.Font = new Font("Segoe UI", 15F);
            dailyrate.Location = new Point(1293, 717);
            dailyrate.Name = "dailyrate";
            dailyrate.ReadOnly = true;
            dailyrate.Size = new Size(146, 34);
            dailyrate.TabIndex = 30;
            // 
            // computation
            // 
            computation.Font = new Font("Segoe UI", 15F);
            computation.Location = new Point(1293, 757);
            computation.Name = "computation";
            computation.ReadOnly = true;
            computation.Size = new Size(187, 34);
            computation.TabIndex = 31;
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 15F);
            total.Location = new Point(1293, 797);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(146, 34);
            total.TabIndex = 32;
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 20F);
            btn.Location = new Point(904, 866);
            btn.Name = "btn";
            btn.Size = new Size(535, 79);
            btn.TabIndex = 33;
            btn.Text = "confirm rental";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // pickupbranch
            // 
            pickupbranch.Font = new Font("Segoe UI", 20F);
            pickupbranch.Location = new Point(619, 410);
            pickupbranch.MaxLength = 100;
            pickupbranch.Name = "pickupbranch";
            pickupbranch.Size = new Size(441, 43);
            pickupbranch.TabIndex = 34;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RENTAL_DETAILS_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pickupbranch);
            Controls.Add(btn);
            Controls.Add(total);
            Controls.Add(computation);
            Controls.Add(dailyrate);
            Controls.Add(duration);
            Controls.Add(panel1);
            Controls.Add(pickupdatepicker);
            Controls.Add(returndatepicker);
            Controls.Add(vehiclecbox);
            Controls.Add(dashboardbtn);
            Controls.Add(signbtn);
            Controls.Add(penaltycomputationbtn);
            Controls.Add(rentbtn);
            Controls.Add(rentalrecordbtn);
            Controls.Add(fleetbtn);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dashboardbtn;
        private Button signbtn;
        private Button penaltycomputationbtn;
        private Button rentbtn;
        private Button rentalrecordbtn;
        private Button fleetbtn;
        private ComboBox vehiclecbox;
        private DateTimePicker returndatepicker;
        private DateTimePicker pickupdatepicker;
        private Panel panel1;
        private TextBox duration;
        private TextBox dailyrate;
        private TextBox computation;
        private TextBox total;
        private Button btn;
        private TextBox pickupbranch;
    }
}