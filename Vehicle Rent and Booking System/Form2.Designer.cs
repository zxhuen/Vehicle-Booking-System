namespace Vehicle_Rent_and_Booking_System
{
    partial class Form2
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

        private void InitializeComponent()
        {
            dashboardbtn = new Button();
            fleetbtn = new Button();
            rentalrecordbtn = new Button();
            rentbtn = new Button();
            penaltycomputationbtn = new Button();
            signbtn = new Button();
            panel1 = new Panel();
            pnlRecentActivity = new Panel();
            pnlEarnings = new Panel();
            textBoxTotalVehicles = new TextBox();
            textBoxAvailability = new TextBox();
            textBoxRented = new TextBox();
            SuspendLayout();
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.ForestGreen;
            dashboardbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 140);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(382, 104);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "DASHBOARD";
            dashboardbtn.UseVisualStyleBackColor = false;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // fleetbtn
            // 
            fleetbtn.BackColor = Color.ForestGreen;
            fleetbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fleetbtn.Location = new Point(12, 266);
            fleetbtn.Name = "fleetbtn";
            fleetbtn.Size = new Size(382, 104);
            fleetbtn.TabIndex = 1;
            fleetbtn.Text = "FLEET";
            fleetbtn.UseVisualStyleBackColor = false;
            fleetbtn.Click += fleetbtn_Click_1;
            // 
            // rentalrecordbtn
            // 
            rentalrecordbtn.BackColor = Color.ForestGreen;
            rentalrecordbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalrecordbtn.Location = new Point(13, 390);
            rentalrecordbtn.Name = "rentalrecordbtn";
            rentalrecordbtn.Size = new Size(389, 104);
            rentalrecordbtn.TabIndex = 2;
            rentalrecordbtn.Text = "RENTAL RECORD";
            rentalrecordbtn.UseVisualStyleBackColor = false;
            rentalrecordbtn.Click += rentalrecordbtn_Click_1;
            // 
            // rentbtn
            // 
            rentbtn.BackColor = Color.ForestGreen;
            rentbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentbtn.Location = new Point(13, 528);
            rentbtn.Name = "rentbtn";
            rentbtn.Size = new Size(382, 104);
            rentbtn.TabIndex = 3;
            rentbtn.Text = "RENT";
            rentbtn.UseVisualStyleBackColor = false;
            rentbtn.Click += rentbtn_Click_1;
            // 
            // penaltycomputationbtn
            // 
            penaltycomputationbtn.BackColor = Color.ForestGreen;
            penaltycomputationbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penaltycomputationbtn.Location = new Point(19, 674);
            penaltycomputationbtn.Name = "penaltycomputationbtn";
            penaltycomputationbtn.Size = new Size(382, 104);
            penaltycomputationbtn.TabIndex = 4;
            penaltycomputationbtn.Text = "PENALTY COMPUTATION";
            penaltycomputationbtn.UseVisualStyleBackColor = false;
            penaltycomputationbtn.Click += penaltycomputationbtn_Click_1;
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.ForestGreen;
            signbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(63, 920);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(284, 64);
            signbtn.TabIndex = 5;
            signbtn.Text = "SIGN OUT ";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(493, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 79);
            panel1.TabIndex = 6;
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.Location = new Point(695, 570);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Size = new Size(930, 208);
            pnlRecentActivity.TabIndex = 10;
            // 
            // pnlEarnings
            // 
            pnlEarnings.Location = new Point(1047, 917);
            pnlEarnings.Name = "pnlEarnings";
            pnlEarnings.Size = new Size(283, 67);
            pnlEarnings.TabIndex = 11;
            // 
            // textBoxTotalVehicles
            // 
            textBoxTotalVehicles.Font = new Font("Segoe UI", 30F);
            textBoxTotalVehicles.Location = new Point(754, 336);
            textBoxTotalVehicles.Name = "textBoxTotalVehicles";
            textBoxTotalVehicles.ReadOnly = true;
            textBoxTotalVehicles.Size = new Size(139, 61);
            textBoxTotalVehicles.TabIndex = 12;
            // 
            // textBoxAvailability
            // 
            textBoxAvailability.Font = new Font("Segoe UI", 30F);
            textBoxAvailability.Location = new Point(1124, 336);
            textBoxAvailability.Name = "textBoxAvailability";
            textBoxAvailability.ReadOnly = true;
            textBoxAvailability.Size = new Size(139, 61);
            textBoxAvailability.TabIndex = 13;
            // 
            // textBoxRented
            // 
            textBoxRented.Font = new Font("Segoe UI", 30F);
            textBoxRented.Location = new Point(1496, 336);
            textBoxRented.Name = "textBoxRented";
            textBoxRented.ReadOnly = true;
            textBoxRented.Size = new Size(139, 61);
            textBoxRented.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboard;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(textBoxRented);
            Controls.Add(textBoxAvailability);
            Controls.Add(textBoxTotalVehicles);
            Controls.Add(pnlEarnings);
            Controls.Add(pnlRecentActivity);
            Controls.Add(panel1);
            Controls.Add(signbtn);
            Controls.Add(penaltycomputationbtn);
            Controls.Add(rentbtn);
            Controls.Add(rentalrecordbtn);
            Controls.Add(fleetbtn);
            Controls.Add(dashboardbtn);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button dashboardbtn;
        private Button fleetbtn;
        private Button rentalrecordbtn;
        private Button rentbtn;
        private Button penaltycomputationbtn;
        private Button signbtn;
        private Panel panel1;
        private Panel pnlRecentActivity;
        private Panel pnlEarnings;
        private TextBox textBoxTotalVehicles;
        private TextBox textBoxAvailability;
        private TextBox textBoxRented;
    }
}