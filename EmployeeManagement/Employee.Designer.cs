namespace EmployeeManagement
{
    partial class Employee
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
            label1 = new Label();
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpGenderCb = new ComboBox();
            label9 = new Label();
            EmpEduCb = new ComboBox();
            label8 = new Label();
            EmpPhoneTb = new TextBox();
            label7 = new Label();
            EmpDob = new DateTimePicker();
            label6 = new Label();
            EmpPosCb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            EmpAddTb = new TextBox();
            EmpName = new Label();
            EmpNameTb = new TextBox();
            EmpId = new Label();
            EmpIdTb = new TextBox();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(3, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 3;
            label1.Text = "Manage Employee";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EmpGenderCb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpEduCb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(EmpDob);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(EmpName);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpId);
            panel1.Controls.Add(EmpIdTb);
            panel1.Location = new Point(0, 55);
            panel1.Margin = new Padding(3, 8, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 474);
            panel1.TabIndex = 4;
            // 
            // EmpDGV
            // 
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Location = new Point(366, 16);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.Size = new Size(662, 393);
            EmpDGV.TabIndex = 26;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(122, 417);
            button4.Margin = new Padding(3, 5, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 38);
            button4.TabIndex = 25;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(222, 371);
            button3.Margin = new Padding(3, 5, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 38);
            button3.TabIndex = 24;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(122, 371);
            button2.Margin = new Padding(3, 5, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 23;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 371);
            button1.Margin = new Padding(3, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 22;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmpGenderCb
            // 
            EmpGenderCb.FormattingEnabled = true;
            EmpGenderCb.Items.AddRange(new object[] { "Male", "Female" });
            EmpGenderCb.Location = new Point(189, 147);
            EmpGenderCb.Name = "EmpGenderCb";
            EmpGenderCb.Size = new Size(139, 28);
            EmpGenderCb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(183, 122);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 20;
            label9.Text = "Gender";
            // 
            // EmpEduCb
            // 
            EmpEduCb.FormattingEnabled = true;
            EmpEduCb.Items.AddRange(new object[] { "BTech", "MTech", "BBA", "MBA", "BCom" });
            EmpEduCb.Location = new Point(189, 309);
            EmpEduCb.Name = "EmpEduCb";
            EmpEduCb.Size = new Size(163, 28);
            EmpEduCb.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(189, 284);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 18;
            label8.Text = "Education";
            label8.Click += label8_Click;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.BackColor = SystemColors.HighlightText;
            EmpPhoneTb.Location = new Point(22, 309);
            EmpPhoneTb.Margin = new Padding(4);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(135, 27);
            EmpPhoneTb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(22, 284);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 21);
            label7.TabIndex = 16;
            label7.Text = "Phone";
            // 
            // EmpDob
            // 
            EmpDob.Location = new Point(189, 222);
            EmpDob.Name = "EmpDob";
            EmpDob.Size = new Size(171, 27);
            EmpDob.TabIndex = 15;
            EmpDob.Value = new DateTime(2024, 5, 10, 0, 0, 0, 0);
            EmpDob.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(189, 197);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 14;
            label6.Text = "Employee Name";
            label6.Click += label6_Click;
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "Manager", "Senior Developer", "Junior Devveloper", "Accountant", "receptionist" });
            EmpPosCb.Location = new Point(22, 221);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(135, 28);
            EmpPosCb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(22, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 12;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(22, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 11;
            label4.Text = "Address";
            label4.Click += label4_Click;
            // 
            // EmpAddTb
            // 
            EmpAddTb.BackColor = SystemColors.HighlightText;
            EmpAddTb.Location = new Point(22, 147);
            EmpAddTb.Margin = new Padding(4);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(135, 27);
            EmpAddTb.TabIndex = 10;
            // 
            // EmpName
            // 
            EmpName.AutoSize = true;
            EmpName.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpName.ForeColor = SystemColors.MenuHighlight;
            EmpName.Location = new Point(183, 48);
            EmpName.Margin = new Padding(4, 0, 4, 0);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(145, 21);
            EmpName.TabIndex = 9;
            EmpName.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BackColor = SystemColors.HighlightText;
            EmpNameTb.Location = new Point(183, 73);
            EmpNameTb.Margin = new Padding(4);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(145, 27);
            EmpNameTb.TabIndex = 8;
            // 
            // EmpId
            // 
            EmpId.AutoSize = true;
            EmpId.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpId.ForeColor = SystemColors.MenuHighlight;
            EmpId.Location = new Point(22, 48);
            EmpId.Margin = new Padding(4, 0, 4, 0);
            EmpId.Name = "EmpId";
            EmpId.Size = new Size(113, 21);
            EmpId.TabIndex = 7;
            EmpId.Text = "Employee id";
            // 
            // EmpIdTb
            // 
            EmpIdTb.BackColor = SystemColors.HighlightText;
            EmpIdTb.Location = new Point(22, 73);
            EmpIdTb.Margin = new Padding(4);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(135, 27);
            EmpIdTb.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1006, 6);
            button5.Margin = new Padding(3, 5, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(33, 38);
            button5.TabIndex = 27;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1061, 561);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox EmpAddTb;
        private Label EmpName;
        private TextBox EmpNameTb;
        private Label EmpId;
        private TextBox EmpIdTb;
        private Label label6;
        private ComboBox EmpPosCb;
        private Label label5;
        private DateTimePicker EmpDob;
        private Label label8;
        private TextBox EmpPhoneTb;
        private Label label7;
        private ComboBox EmpGenderCb;
        private Label label9;
        private ComboBox EmpEduCb;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView EmpDGV;
        private Button button5;
    }
}