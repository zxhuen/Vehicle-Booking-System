namespace Vehicle_Rent_and_Booking_System
{
    partial class RegVehicleForm
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
            txtVehicleModel = new TextBox();
            txtSeats = new TextBox();
            txtDailyRate = new TextBox();
            txtMileage = new TextBox();
            cmbVehicleType = new ComboBox();
            cmbStatus = new ComboBox();
            txtPlateNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtVehicleModel
            // 
            txtVehicleModel.Location = new Point(610, 241);
            txtVehicleModel.Multiline = true;
            txtVehicleModel.Name = "txtVehicleModel";
            txtVehicleModel.Size = new Size(602, 84);
            txtVehicleModel.TabIndex = 0;
            txtVehicleModel.TextChanged += txtVehicleModel_TextChanged;
            // 
            // txtSeats
            // 
            txtSeats.Location = new Point(609, 665);
            txtSeats.Multiline = true;
            txtSeats.Name = "txtSeats";
            txtSeats.Size = new Size(193, 82);
            txtSeats.TabIndex = 1;
            // 
            // txtDailyRate
            // 
            txtDailyRate.Location = new Point(1277, 240);
            txtDailyRate.Multiline = true;
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(322, 85);
            txtDailyRate.TabIndex = 2;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(1274, 381);
            txtMileage.Multiline = true;
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(325, 85);
            txtMileage.TabIndex = 3;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.ItemHeight = 86;
            cmbVehicleType.Items.AddRange(new object[] { "Sedan", "SUV", "Van" });
            cmbVehicleType.Location = new Point(610, 510);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(602, 94);
            cmbVehicleType.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available" });
            cmbStatus.Location = new Point(1274, 510);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(353, 94);
            cmbStatus.TabIndex = 5;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(610, 374);
            txtPlateNumber.Multiline = true;
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(602, 81);
            txtPlateNumber.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(896, 904);
            button1.Name = "button1";
            button1.Size = new Size(316, 81);
            button1.TabIndex = 7;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1232, 904);
            button2.Name = "button2";
            button2.Size = new Size(321, 81);
            button2.TabIndex = 8;
            button2.Text = "REGISTER VEHICLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 1038);
            panel1.TabIndex = 10;
            // 
            // RegVehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vehicle_registration_;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPlateNumber);
            Controls.Add(cmbStatus);
            Controls.Add(cmbVehicleType);
            Controls.Add(txtMileage);
            Controls.Add(txtDailyRate);
            Controls.Add(txtSeats);
            Controls.Add(txtVehicleModel);
            Name = "RegVehicleForm";
            Text = "RegVehicleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVehicleModel;
        private TextBox txtSeats;
        private TextBox txtDailyRate;
        private TextBox txtMileage;
        private ComboBox cmbVehicleType;
        private ComboBox cmbStatus;
        private TextBox txtPlateNumber;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}