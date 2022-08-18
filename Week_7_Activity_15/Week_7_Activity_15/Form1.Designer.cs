namespace Week_7_Activity_15
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clemsonEye = new System.Windows.Forms.RadioButton();
            this.rockyCreekFamilyDentistry = new System.Windows.Forms.RadioButton();
            this.centervilleFamilyPractice = new System.Windows.Forms.RadioButton();
            this.submitForInfo = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Centerville Medical Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Select from the Following:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.clemsonEye);
            this.groupBox1.Controls.Add(this.rockyCreekFamilyDentistry);
            this.groupBox1.Controls.Add(this.centervilleFamilyPractice);
            this.groupBox1.Location = new System.Drawing.Point(53, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8:00AM",
            "9:00AM",
            "9:30AM",
            "10:00AM",
            "10:30AM",
            "11:00AM",
            "11:30AM",
            "12:00PM",
            "12:30PM\t",
            "1:00PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM"});
            this.comboBox2.Location = new System.Drawing.Point(33, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appointment Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor Seeing:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // clemsonEye
            // 
            this.clemsonEye.AutoSize = true;
            this.clemsonEye.Location = new System.Drawing.Point(33, 90);
            this.clemsonEye.Name = "clemsonEye";
            this.clemsonEye.Size = new System.Drawing.Size(108, 20);
            this.clemsonEye.TabIndex = 3;
            this.clemsonEye.TabStop = true;
            this.clemsonEye.Text = "Clemson Eye";
            this.clemsonEye.UseVisualStyleBackColor = true;
            this.clemsonEye.CheckedChanged += new System.EventHandler(this.clemsonEye_CheckedChanged);
            // 
            // rockyCreekFamilyDentistry
            // 
            this.rockyCreekFamilyDentistry.AutoSize = true;
            this.rockyCreekFamilyDentistry.Location = new System.Drawing.Point(33, 64);
            this.rockyCreekFamilyDentistry.Name = "rockyCreekFamilyDentistry";
            this.rockyCreekFamilyDentistry.Size = new System.Drawing.Size(204, 20);
            this.rockyCreekFamilyDentistry.TabIndex = 1;
            this.rockyCreekFamilyDentistry.TabStop = true;
            this.rockyCreekFamilyDentistry.Text = "Rocky Creek Family Dentistry";
            this.rockyCreekFamilyDentistry.UseVisualStyleBackColor = true;
            this.rockyCreekFamilyDentistry.CheckedChanged += new System.EventHandler(this.rockyCreekFamilyDentistry_CheckedChanged);
            // 
            // centervilleFamilyPractice
            // 
            this.centervilleFamilyPractice.AutoSize = true;
            this.centervilleFamilyPractice.Location = new System.Drawing.Point(33, 38);
            this.centervilleFamilyPractice.Name = "centervilleFamilyPractice";
            this.centervilleFamilyPractice.Size = new System.Drawing.Size(186, 20);
            this.centervilleFamilyPractice.TabIndex = 0;
            this.centervilleFamilyPractice.Text = "Centerville Family Practice";
            this.centervilleFamilyPractice.UseVisualStyleBackColor = true;
            this.centervilleFamilyPractice.CheckedChanged += new System.EventHandler(this.centervilleFamilyPractice_CheckedChanged);
            // 
            // submitForInfo
            // 
            this.submitForInfo.Location = new System.Drawing.Point(408, 416);
            this.submitForInfo.Name = "submitForInfo";
            this.submitForInfo.Size = new System.Drawing.Size(91, 34);
            this.submitForInfo.TabIndex = 2;
            this.submitForInfo.Text = "Submit";
            this.submitForInfo.UseVisualStyleBackColor = true;
            this.submitForInfo.Click += new System.EventHandler(this.submitForInfo_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(522, 416);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 34);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(689, 493);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submitForInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Centerville Medical Center Help Desk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button submitForInfo;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.RadioButton clemsonEye;
        public System.Windows.Forms.RadioButton rockyCreekFamilyDentistry;
        public System.Windows.Forms.RadioButton centervilleFamilyPractice;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}

