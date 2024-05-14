namespace EmployeeManagement
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            label1 = new Label();
            button5 = new Button();
            panel1 = new Panel();
            empgenderlbl = new Label();
            empedulbl = new Label();
            empdoblbl = new Label();
            empnamelbl = new Label();
            empphonelbl = new Label();
            empposlbl = new Label();
            empaddlbl = new Label();
            Empidlbl = new Label();
            button7 = new Button();
            button6 = new Button();
            label2 = new Label();
            EmpidTb = new TextBox();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            EmpName = new Label();
            EmpId = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(3, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 4;
            label1.Text = "Manage Employee";
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1016, 5);
            button5.Margin = new Padding(3, 5, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(33, 38);
            button5.TabIndex = 28;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(empgenderlbl);
            panel1.Controls.Add(empedulbl);
            panel1.Controls.Add(empdoblbl);
            panel1.Controls.Add(empnamelbl);
            panel1.Controls.Add(empphonelbl);
            panel1.Controls.Add(empposlbl);
            panel1.Controls.Add(empaddlbl);
            panel1.Controls.Add(Empidlbl);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EmpidTb);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpName);
            panel1.Controls.Add(EmpId);
            panel1.Location = new Point(3, 64);
            panel1.Margin = new Padding(3, 8, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 474);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // empgenderlbl
            // 
            empgenderlbl.AutoSize = true;
            empgenderlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empgenderlbl.ForeColor = SystemColors.GrayText;
            empgenderlbl.Location = new Point(820, 159);
            empgenderlbl.Margin = new Padding(4, 0, 4, 0);
            empgenderlbl.Name = "empgenderlbl";
            empgenderlbl.Size = new Size(75, 21);
            empgenderlbl.TabIndex = 37;
            empgenderlbl.Text = "Gender";
            empgenderlbl.Visible = false;
            // 
            // empedulbl
            // 
            empedulbl.AutoSize = true;
            empedulbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empedulbl.ForeColor = SystemColors.GrayText;
            empedulbl.Location = new Point(826, 321);
            empedulbl.Margin = new Padding(4, 0, 4, 0);
            empedulbl.Name = "empedulbl";
            empedulbl.Size = new Size(101, 21);
            empedulbl.TabIndex = 36;
            empedulbl.Text = "Education";
            empedulbl.Visible = false;
            // 
            // empdoblbl
            // 
            empdoblbl.AutoSize = true;
            empdoblbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empdoblbl.ForeColor = SystemColors.GrayText;
            empdoblbl.Location = new Point(826, 234);
            empdoblbl.Margin = new Padding(4, 0, 4, 0);
            empdoblbl.Name = "empdoblbl";
            empdoblbl.Size = new Size(158, 21);
            empdoblbl.TabIndex = 35;
            empdoblbl.Text = "Employee Name";
            empdoblbl.Visible = false;
            // 
            // empnamelbl
            // 
            empnamelbl.AutoSize = true;
            empnamelbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empnamelbl.ForeColor = SystemColors.GrayText;
            empnamelbl.Location = new Point(820, 85);
            empnamelbl.Margin = new Padding(4, 0, 4, 0);
            empnamelbl.Name = "empnamelbl";
            empnamelbl.Size = new Size(158, 21);
            empnamelbl.TabIndex = 34;
            empnamelbl.Text = "Employee Name";
            empnamelbl.Visible = false;
            // 
            // empphonelbl
            // 
            empphonelbl.AutoSize = true;
            empphonelbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empphonelbl.ForeColor = SystemColors.GrayText;
            empphonelbl.Location = new Point(296, 310);
            empphonelbl.Margin = new Padding(4, 0, 4, 0);
            empphonelbl.Name = "empphonelbl";
            empphonelbl.Size = new Size(65, 21);
            empphonelbl.TabIndex = 33;
            empphonelbl.Text = "Phone";
            empphonelbl.Visible = false;
            // 
            // empposlbl
            // 
            empposlbl.AutoSize = true;
            empposlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empposlbl.ForeColor = SystemColors.GrayText;
            empposlbl.Location = new Point(296, 223);
            empposlbl.Margin = new Padding(4, 0, 4, 0);
            empposlbl.Name = "empposlbl";
            empposlbl.Size = new Size(85, 21);
            empposlbl.TabIndex = 32;
            empposlbl.Text = "Position";
            empposlbl.Visible = false;
            // 
            // empaddlbl
            // 
            empaddlbl.AutoSize = true;
            empaddlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            empaddlbl.ForeColor = SystemColors.GrayText;
            empaddlbl.Location = new Point(296, 148);
            empaddlbl.Margin = new Padding(4, 0, 4, 0);
            empaddlbl.Name = "empaddlbl";
            empaddlbl.Size = new Size(83, 21);
            empaddlbl.TabIndex = 31;
            empaddlbl.Text = "Address";
            empaddlbl.Visible = false;
            // 
            // Empidlbl
            // 
            Empidlbl.AutoSize = true;
            Empidlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            Empidlbl.ForeColor = SystemColors.GrayText;
            Empidlbl.Location = new Point(296, 74);
            Empidlbl.Margin = new Padding(4, 0, 4, 0);
            Empidlbl.Name = "Empidlbl";
            Empidlbl.Size = new Size(124, 21);
            Empidlbl.TabIndex = 30;
            Empidlbl.Text = "Employee id";
            Empidlbl.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightCyan;
            button7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(598, 5);
            button7.Margin = new Padding(3, 5, 3, 3);
            button7.Name = "button7";
            button7.Size = new Size(104, 33);
            button7.TabIndex = 29;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(614, 396);
            button6.Margin = new Padding(3, 5, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 38);
            button6.TabIndex = 28;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(317, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 27;
            label2.Text = "Employee id";
            // 
            // EmpidTb
            // 
            EmpidTb.BackColor = SystemColors.HighlightText;
            EmpidTb.Location = new Point(438, 5);
            EmpidTb.Margin = new Padding(4);
            EmpidTb.Name = "EmpidTb";
            EmpidTb.Size = new Size(135, 27);
            EmpidTb.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(438, 396);
            button1.Margin = new Padding(3, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 22;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(557, 159);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 20;
            label9.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(563, 321);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 18;
            label8.Text = "Education";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(85, 310);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 21);
            label7.TabIndex = 16;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(563, 234);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 21);
            label6.TabIndex = 14;
            label6.Text = "Employee DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(85, 223);
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
            label4.Location = new Point(85, 148);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // EmpName
            // 
            EmpName.AutoSize = true;
            EmpName.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpName.ForeColor = SystemColors.MenuHighlight;
            EmpName.Location = new Point(557, 85);
            EmpName.Margin = new Padding(4, 0, 4, 0);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(145, 21);
            EmpName.TabIndex = 9;
            EmpName.Text = "Employee Name";
            // 
            // EmpId
            // 
            EmpId.AutoSize = true;
            EmpId.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpId.ForeColor = SystemColors.MenuHighlight;
            EmpId.Location = new Point(85, 74);
            EmpId.Margin = new Padding(4, 0, 4, 0);
            EmpId.Name = "EmpId";
            EmpId.Size = new Size(113, 21);
            EmpId.TabIndex = 7;
            EmpId.Text = "Employee id";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1066, 561);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmployee";
            Load += ViewEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button5;
        private Panel panel1;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label EmpName;
        private Label EmpId;
        private Label empphonelbl;
        private Label empposlbl;
        private Label empaddlbl;
        private Label Empidlbl;
        private Button button7;
        private Button button6;
        private Label label2;
        private TextBox EmpidTb;
        private Label empgenderlbl;
        private Label empedulbl;
        private Label empdoblbl;
        private Label empnamelbl;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}