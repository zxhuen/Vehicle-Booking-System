namespace Vehicle_Rent_and_Booking_System
{
    partial class Form6
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
            SuspendLayout();
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.ForestGreen;
            dashboardbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 139);
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
            signbtn.Location = new Point(63, 918);
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
            penaltycomputationbtn.Location = new Point(19, 672);
            penaltycomputationbtn.Name = "penaltycomputationbtn";
            penaltycomputationbtn.Size = new Size(382, 104);
            penaltycomputationbtn.TabIndex = 21;
            penaltycomputationbtn.Text = "PENALTY COMPUTATION";
            penaltycomputationbtn.UseVisualStyleBackColor = false;
            // 
            // rentbtn
            // 
            rentbtn.BackColor = Color.ForestGreen;
            rentbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentbtn.Location = new Point(13, 526);
            rentbtn.Name = "rentbtn";
            rentbtn.Size = new Size(382, 104);
            rentbtn.TabIndex = 20;
            rentbtn.Text = "RENT";
            rentbtn.UseVisualStyleBackColor = false;
            rentbtn.Click += rentbtn_Click;
            // 
            // rentalrecordbtn
            // 
            rentalrecordbtn.BackColor = Color.ForestGreen;
            rentalrecordbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalrecordbtn.Location = new Point(13, 388);
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
            fleetbtn.Location = new Point(12, 264);
            fleetbtn.Name = "fleetbtn";
            fleetbtn.Size = new Size(382, 104);
            fleetbtn.TabIndex = 18;
            fleetbtn.Text = "FLEET";
            fleetbtn.UseVisualStyleBackColor = false;
            fleetbtn.Click += fleetbtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.penalty_computation;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dashboardbtn);
            Controls.Add(signbtn);
            Controls.Add(penaltycomputationbtn);
            Controls.Add(rentbtn);
            Controls.Add(rentalrecordbtn);
            Controls.Add(fleetbtn);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Button dashboardbtn;
        private Button signbtn;
        private Button penaltycomputationbtn;
        private Button rentbtn;
        private Button rentalrecordbtn;
        private Button fleetbtn;
    }
}