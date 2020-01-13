namespace Selenium_SYE_Interface
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
            this.components = new System.ComponentModel.Container();
            this.GetInfo = new System.Windows.Forms.Button();
            this.Get_Fuel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Get_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Company_Input = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Get_Job = new System.Windows.Forms.TextBox();
            this.Get_Phone = new System.Windows.Forms.TextBox();
            this.Get_Surname = new System.Windows.Forms.TextBox();
            this.Get_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Usage_Input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Get_MPRN = new System.Windows.Forms.TextBox();
            this.Get_MPAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Consent_Input = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Get_AccountNumber = new System.Windows.Forms.TextBox();
            this.Get_SortCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Get_AccountName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Get_BankName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Start_Preset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetInfo
            // 
            this.GetInfo.Location = new System.Drawing.Point(12, 331);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(433, 60);
            this.GetInfo.TabIndex = 0;
            this.GetInfo.Text = "Start";
            this.GetInfo.UseVisualStyleBackColor = true;
            this.GetInfo.Click += new System.EventHandler(this.Start_Click);
            // 
            // Get_Fuel
            // 
            this.Get_Fuel.FormattingEnabled = true;
            this.Get_Fuel.Items.AddRange(new object[] {
            "Electricity",
            "Gas",
            "Dual Energy"});
            this.Get_Fuel.Location = new System.Drawing.Point(69, 18);
            this.Get_Fuel.Name = "Get_Fuel";
            this.Get_Fuel.Size = new System.Drawing.Size(152, 21);
            this.Get_Fuel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuel Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // Get_Email
            // 
            this.Get_Email.Location = new System.Drawing.Point(50, 48);
            this.Get_Email.Name = "Get_Email";
            this.Get_Email.Size = new System.Drawing.Size(171, 20);
            this.Get_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Num:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Job Title: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Company_Input);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Get_Job);
            this.groupBox1.Controls.Add(this.Get_Phone);
            this.groupBox1.Controls.Add(this.Get_Surname);
            this.groupBox1.Controls.Add(this.Get_FirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(245, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Info";
            // 
            // Company_Input
            // 
            this.Company_Input.Location = new System.Drawing.Point(66, 18);
            this.Company_Input.Name = "Company_Input";
            this.Company_Input.Size = new System.Drawing.Size(128, 20);
            this.Company_Input.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Company:";
            // 
            // Get_Job
            // 
            this.Get_Job.Location = new System.Drawing.Point(65, 137);
            this.Get_Job.Name = "Get_Job";
            this.Get_Job.Size = new System.Drawing.Size(129, 20);
            this.Get_Job.TabIndex = 13;
            // 
            // Get_Phone
            // 
            this.Get_Phone.Location = new System.Drawing.Point(78, 107);
            this.Get_Phone.Name = "Get_Phone";
            this.Get_Phone.Size = new System.Drawing.Size(116, 20);
            this.Get_Phone.TabIndex = 12;
            // 
            // Get_Surname
            // 
            this.Get_Surname.Location = new System.Drawing.Point(67, 78);
            this.Get_Surname.Name = "Get_Surname";
            this.Get_Surname.Size = new System.Drawing.Size(127, 20);
            this.Get_Surname.TabIndex = 11;
            // 
            // Get_FirstName
            // 
            this.Get_FirstName.Location = new System.Drawing.Point(72, 48);
            this.Get_FirstName.Name = "Get_FirstName";
            this.Get_FirstName.Size = new System.Drawing.Size(122, 20);
            this.Get_FirstName.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Usage_Input);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.Get_MPRN);
            this.groupBox2.Controls.Add(this.Get_MPAN);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Get_Email);
            this.groupBox2.Controls.Add(this.Get_Fuel);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quote Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Contract End:";
            // 
            // Usage_Input
            // 
            this.Usage_Input.Location = new System.Drawing.Point(53, 137);
            this.Usage_Input.Name = "Usage_Input";
            this.Usage_Input.Size = new System.Drawing.Size(168, 20);
            this.Usage_Input.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Usage:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(84, 163);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(137, 20);
            this.DatePicker.TabIndex = 19;
            // 
            // Get_MPRN
            // 
            this.Get_MPRN.Location = new System.Drawing.Point(55, 107);
            this.Get_MPRN.Name = "Get_MPRN";
            this.Get_MPRN.Size = new System.Drawing.Size(166, 20);
            this.Get_MPRN.TabIndex = 14;
            // 
            // Get_MPAN
            // 
            this.Get_MPAN.Location = new System.Drawing.Point(54, 78);
            this.Get_MPAN.Name = "Get_MPAN";
            this.Get_MPAN.Size = new System.Drawing.Size(167, 20);
            this.Get_MPAN.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MPRN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MPAN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(371, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Switch Your Energy Selenium";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Consent_Input
            // 
            this.Consent_Input.AutoSize = true;
            this.Consent_Input.Location = new System.Drawing.Point(246, 232);
            this.Consent_Input.Name = "Consent_Input";
            this.Consent_Input.Size = new System.Drawing.Size(71, 17);
            this.Consent_Input.TabIndex = 13;
            this.Consent_Input.Text = "Consent?";
            this.Consent_Input.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Get_AccountNumber);
            this.groupBox3.Controls.Add(this.Get_SortCode);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Get_AccountName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Get_BankName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 70);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank Details";
            // 
            // Get_AccountNumber
            // 
            this.Get_AccountNumber.Location = new System.Drawing.Point(320, 44);
            this.Get_AccountNumber.Name = "Get_AccountNumber";
            this.Get_AccountNumber.Size = new System.Drawing.Size(107, 20);
            this.Get_AccountNumber.TabIndex = 7;
            // 
            // Get_SortCode
            // 
            this.Get_SortCode.Location = new System.Drawing.Point(302, 17);
            this.Get_SortCode.Name = "Get_SortCode";
            this.Get_SortCode.Size = new System.Drawing.Size(125, 20);
            this.Get_SortCode.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Account Num:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Sort Code:";
            // 
            // Get_AccountName
            // 
            this.Get_AccountName.Location = new System.Drawing.Point(94, 44);
            this.Get_AccountName.Name = "Get_AccountName";
            this.Get_AccountName.Size = new System.Drawing.Size(100, 20);
            this.Get_AccountName.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Bank Name:";
            // 
            // Get_BankName
            // 
            this.Get_BankName.Location = new System.Drawing.Point(79, 17);
            this.Get_BankName.Name = "Get_BankName";
            this.Get_BankName.Size = new System.Drawing.Size(115, 20);
            this.Get_BankName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Account Name:";
            // 
            // Start_Preset
            // 
            this.Start_Preset.Location = new System.Drawing.Point(324, 228);
            this.Start_Preset.Name = "Start_Preset";
            this.Start_Preset.Size = new System.Drawing.Size(121, 23);
            this.Start_Preset.TabIndex = 15;
            this.Start_Preset.Text = "Use Preset?";
            this.Start_Preset.UseVisualStyleBackColor = true;
            this.Start_Preset.Click += new System.EventHandler(this.Start_Preset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 402);
            this.Controls.Add(this.Start_Preset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Consent_Input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GetInfo);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.ComboBox Get_Fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Get_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Get_Job;
        private System.Windows.Forms.TextBox Get_Phone;
        private System.Windows.Forms.TextBox Get_Surname;
        private System.Windows.Forms.TextBox Get_FirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Get_MPRN;
        private System.Windows.Forms.TextBox Get_MPAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Consent_Input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Usage_Input;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox Company_Input;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Get_BankName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Get_AccountNumber;
        private System.Windows.Forms.TextBox Get_SortCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Get_AccountName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Start_Preset;
    }
}

