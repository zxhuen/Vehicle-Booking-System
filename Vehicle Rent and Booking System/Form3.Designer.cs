namespace Vehicle_Rent_and_Booking_System
{
    partial class Form3
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
            colModel = new DataGridViewTextBoxColumn();
            colPlateNumber = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colSeats = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            Mileage = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            regVehiclebtn = new Button();
            edit = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.ForestGreen;
            signbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(63, 920);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(284, 64);
            signbtn.TabIndex = 11;
            signbtn.Text = "SIGN OUT ";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click;
            // 
            // penaltycomputationbtn
            // 
            penaltycomputationbtn.BackColor = Color.ForestGreen;
            penaltycomputationbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            penaltycomputationbtn.Location = new Point(19, 674);
            penaltycomputationbtn.Name = "penaltycomputationbtn";
            penaltycomputationbtn.Size = new Size(382, 104);
            penaltycomputationbtn.TabIndex = 10;
            penaltycomputationbtn.Text = "PENALTY COMPUTATION";
            penaltycomputationbtn.UseVisualStyleBackColor = false;
            // 
            // rentbtn
            // 
            rentbtn.BackColor = Color.ForestGreen;
            rentbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentbtn.Location = new Point(13, 528);
            rentbtn.Name = "rentbtn";
            rentbtn.Size = new Size(382, 104);
            rentbtn.TabIndex = 9;
            rentbtn.Text = "RENT";
            rentbtn.UseVisualStyleBackColor = false;
            rentbtn.Click += rentbtn_Click_1;
            // 
            // rentalrecordbtn
            // 
            rentalrecordbtn.BackColor = Color.ForestGreen;
            rentalrecordbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rentalrecordbtn.Location = new Point(13, 390);
            rentalrecordbtn.Name = "rentalrecordbtn";
            rentalrecordbtn.Size = new Size(389, 104);
            rentalrecordbtn.TabIndex = 8;
            rentalrecordbtn.Text = "RENTAL RECORD";
            rentalrecordbtn.UseVisualStyleBackColor = false;
            rentalrecordbtn.Click += rentalrecordbtn_Click;
            // 
            // fleetbtn
            // 
            fleetbtn.BackColor = Color.ForestGreen;
            fleetbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fleetbtn.Location = new Point(12, 266);
            fleetbtn.Name = "fleetbtn";
            fleetbtn.Size = new Size(382, 104);
            fleetbtn.TabIndex = 7;
            fleetbtn.Text = "FLEET";
            fleetbtn.UseVisualStyleBackColor = false;
            fleetbtn.Click += fleetbtn_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.BackColor = Color.ForestGreen;
            dashboardbtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardbtn.Location = new Point(12, 140);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(382, 104);
            dashboardbtn.TabIndex = 6;
            dashboardbtn.Text = "DASHBOARD";
            dashboardbtn.UseVisualStyleBackColor = false;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colModel, colPlateNumber, colType, colSeats, colPrice, Mileage, colStatus });
            dataGridView1.Location = new Point(528, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1300, 736);
            dataGridView1.TabIndex = 12;
            // 
            // colModel
            // 
            colModel.HeaderText = "Model";
            colModel.Name = "colModel";
            colModel.ReadOnly = true;
            // 
            // colPlateNumber
            // 
            colPlateNumber.HeaderText = "Plate Number";
            colPlateNumber.Name = "colPlateNumber";
            colPlateNumber.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colSeats
            // 
            colSeats.HeaderText = "Seats";
            colSeats.Name = "colSeats";
            colSeats.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price/Day";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // Mileage
            // 
            Mileage.HeaderText = "Mileage";
            Mileage.Name = "Mileage";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // regVehiclebtn
            // 
            regVehiclebtn.BackColor = Color.ForestGreen;
            regVehiclebtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regVehiclebtn.Location = new Point(1444, 75);
            regVehiclebtn.Name = "regVehiclebtn";
            regVehiclebtn.Size = new Size(382, 104);
            regVehiclebtn.TabIndex = 13;
            regVehiclebtn.Text = "Register Vehicle";
            regVehiclebtn.UseVisualStyleBackColor = false;
            regVehiclebtn.Click += regVehiclebtn_Click;
            // 
            // edit
            // 
            edit.Location = new Point(535, 945);
            edit.Name = "edit";
            edit.Size = new Size(535, 23);
            edit.TabIndex = 14;
            edit.Text = "edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(1176, 945);
            delete.Name = "delete";
            delete.Size = new Size(535, 23);
            delete.TabIndex = 15;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fleet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(regVehiclebtn);
            Controls.Add(dataGridView1);
            Controls.Add(signbtn);
            Controls.Add(penaltycomputationbtn);
            Controls.Add(rentbtn);
            Controls.Add(rentalrecordbtn);
            Controls.Add(fleetbtn);
            Controls.Add(dashboardbtn);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
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
        private Button regVehiclebtn;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colPlateNumber;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colSeats;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn Mileage;
        private DataGridViewTextBoxColumn colStatus;
        private Button edit;
        private Button delete;
    }
}