namespace Vehicle_Rent_and_Booking_System
{
    partial class Form4
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
            signbtn = new Button();
            penaltycomputationbtn = new Button();
            rentbtn = new Button();
            rentalrecordbtn = new Button();
            fleetbtn = new Button();
            dashboardbtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.ForestGreen;
            signbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(63, 923);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(284, 64);
            signbtn.TabIndex = 16;
            signbtn.Text = "SIGN OUT ";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click;
            // 
            // penaltycomputationbtn
            // 
            penaltycomputationbtn.BackColor = Color.ForestGreen;
            penaltycomputationbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penaltycomputationbtn.Location = new Point(19, 677);
            penaltycomputationbtn.Name = "penaltycomputationbtn";
            penaltycomputationbtn.Size = new Size(382, 104);
            penaltycomputationbtn.TabIndex = 15;
            penaltycomputationbtn.Text = "PENALTY COMPUTATION";
            penaltycomputationbtn.UseVisualStyleBackColor = false;
            penaltycomputationbtn.Click += penaltycomputationbtn_Click;
            // 
            // rentbtn
            // 
            rentbtn.BackColor = Color.ForestGreen;
            rentbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentbtn.Location = new Point(13, 531);
            rentbtn.Name = "rentbtn";
            rentbtn.Size = new Size(382, 104);
            rentbtn.TabIndex = 14;
            rentbtn.Text = "RENT";
            rentbtn.UseVisualStyleBackColor = false;
            rentbtn.Click += rentbtn_Click;
            // 
            // rentalrecordbtn
            // 
            rentalrecordbtn.BackColor = Color.ForestGreen;
            rentalrecordbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalrecordbtn.Location = new Point(13, 393);
            rentalrecordbtn.Name = "rentalrecordbtn";
            rentalrecordbtn.Size = new Size(389, 104);
            rentalrecordbtn.TabIndex = 13;
            rentalrecordbtn.Text = "RENTAL RECORD";
            rentalrecordbtn.UseVisualStyleBackColor = false;
            // 
            // fleetbtn
            // 
            fleetbtn.BackColor = Color.ForestGreen;
            fleetbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fleetbtn.Location = new Point(12, 269);
            fleetbtn.Name = "fleetbtn";
            fleetbtn.Size = new Size(382, 104);
            fleetbtn.TabIndex = 12;
            fleetbtn.Text = "FLEET";
            fleetbtn.UseVisualStyleBackColor = false;
            fleetbtn.Click += fleetbtn_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.ForestGreen;
            dashboardbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 144);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(382, 104);
            dashboardbtn.TabIndex = 17;
            dashboardbtn.Text = "DASHBOARD";
            dashboardbtn.UseVisualStyleBackColor = false;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(487, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1314, 825);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.rental_record;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView1);
            Controls.Add(dashboardbtn);
            Controls.Add(signbtn);
            Controls.Add(penaltycomputationbtn);
            Controls.Add(rentbtn);
            Controls.Add(rentalrecordbtn);
            Controls.Add(fleetbtn);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button signbtn;
        private Button penaltycomputationbtn;
        private Button rentbtn;
        private Button rentalrecordbtn;
        private Button fleetbtn;
        private Button dashboardbtn;
        private DataGridView dataGridView1;
    }
}