namespace Week_7_Activity_15
{
    partial class InformationPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.officeName = new System.Windows.Forms.Label();
            this.doctorsName = new System.Windows.Forms.Label();
            this.floorLevel = new System.Windows.Forms.Label();
            this.appointmentTime = new System.Windows.Forms.Label();
            this.closeApp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details For Your Visit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Office Name:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(82, 167);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 22);
            this.label.TabIndex = 2;
            this.label.Text = "Doctors Name:";
            this.label.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Floor Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Appointment Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.closeApp);
            this.groupBox1.Controls.Add(this.appointmentTime);
            this.groupBox1.Controls.Add(this.floorLevel);
            this.groupBox1.Controls.Add(this.doctorsName);
            this.groupBox1.Controls.Add(this.officeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(71, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 444);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // officeName
            // 
            this.officeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.officeName.Location = new System.Drawing.Point(226, 126);
            this.officeName.Name = "officeName";
            this.officeName.Size = new System.Drawing.Size(196, 23);
            this.officeName.TabIndex = 5;
            // 
            // doctorsName
            // 
            this.doctorsName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctorsName.Location = new System.Drawing.Point(226, 171);
            this.doctorsName.Name = "doctorsName";
            this.doctorsName.Size = new System.Drawing.Size(125, 23);
            this.doctorsName.TabIndex = 6;
            // 
            // floorLevel
            // 
            this.floorLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.floorLevel.Location = new System.Drawing.Point(226, 213);
            this.floorLevel.Name = "floorLevel";
            this.floorLevel.Size = new System.Drawing.Size(58, 26);
            this.floorLevel.TabIndex = 7;
            // 
            // appointmentTime
            // 
            this.appointmentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentTime.Location = new System.Drawing.Point(226, 267);
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(73, 23);
            this.appointmentTime.TabIndex = 8;
            // 
            // closeApp
            // 
            this.closeApp.Location = new System.Drawing.Point(342, 340);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(91, 40);
            this.closeApp.TabIndex = 9;
            this.closeApp.Text = "Close";
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Room Number:";
            // 
            // roomNumber
            // 
            this.roomNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomNumber.Location = new System.Drawing.Point(226, 320);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(73, 23);
            this.roomNumber.TabIndex = 11;
            // 
            // InformationPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(624, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "InformationPage";
            this.Text = "Information Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button closeApp;
        public System.Windows.Forms.Label appointmentTime;
        public System.Windows.Forms.Label floorLevel;
        public System.Windows.Forms.Label doctorsName;
        public System.Windows.Forms.Label officeName;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Label label3;
    }
}