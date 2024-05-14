namespace EmployeeManagement
{
    partial class Sslary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sslary));
            panel1 = new Panel();
            button4 = new Button();
            SalarySlip = new RichTextBox();
            EmpPosTb = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            WorkedTb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            EmpName = new Label();
            EmpNameTb = new TextBox();
            EmpId = new Label();
            EmpIdTb = new TextBox();
            button5 = new Button();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(SalarySlip);
            panel1.Controls.Add(EmpPosTb);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(WorkedTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EmpName);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(EmpId);
            panel1.Controls.Add(EmpIdTb);
            panel1.Location = new Point(3, 62);
            panel1.Margin = new Padding(3, 8, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 474);
            panel1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(9, 371);
            button4.Margin = new Padding(3, 5, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 38);
            button4.TabIndex = 29;
            button4.Text = " Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SalarySlip
            // 
            SalarySlip.BorderStyle = BorderStyle.None;
            SalarySlip.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalarySlip.ForeColor = SystemColors.GrayText;
            SalarySlip.Location = new Point(452, 17);
            SalarySlip.Name = "SalarySlip";
            SalarySlip.Size = new Size(562, 392);
            SalarySlip.TabIndex = 28;
            SalarySlip.Text = "";
            // 
            // EmpPosTb
            // 
            EmpPosTb.BackColor = SystemColors.HighlightText;
            EmpPosTb.Enabled = false;
            EmpPosTb.Location = new Point(22, 236);
            EmpPosTb.Margin = new Padding(4);
            EmpPosTb.Name = "EmpPosTb";
            EmpPosTb.Size = new Size(145, 27);
            EmpPosTb.TabIndex = 27;
            EmpPosTb.TextAlign = HorizontalAlignment.Right;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(204, 65);
            button3.Margin = new Padding(3, 5, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(134, 35);
            button3.TabIndex = 24;
            button3.Text = "Fetch Data";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(135, 371);
            button2.Margin = new Padding(3, 5, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 23;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(694, 417);
            button1.Margin = new Padding(3, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 22;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WorkedTb
            // 
            WorkedTb.BackColor = SystemColors.HighlightText;
            WorkedTb.Location = new Point(22, 309);
            WorkedTb.Margin = new Padding(4);
            WorkedTb.Name = "WorkedTb";
            WorkedTb.Size = new Size(145, 27);
            WorkedTb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(22, 284);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 16;
            label7.Text = "Worked Days";
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
            // EmpName
            // 
            EmpName.AutoSize = true;
            EmpName.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpName.ForeColor = SystemColors.MenuHighlight;
            EmpName.Location = new Point(22, 122);
            EmpName.Margin = new Padding(4, 0, 4, 0);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(145, 21);
            EmpName.TabIndex = 9;
            EmpName.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BackColor = SystemColors.HighlightText;
            EmpNameTb.Enabled = false;
            EmpNameTb.Location = new Point(22, 147);
            EmpNameTb.Margin = new Padding(4);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(145, 27);
            EmpNameTb.TabIndex = 8;
            EmpNameTb.TextAlign = HorizontalAlignment.Right;
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
            EmpIdTb.Size = new Size(145, 27);
            EmpIdTb.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1027, 4);
            button5.Margin = new Padding(3, 5, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(33, 38);
            button5.TabIndex = 30;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(3, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 29;
            label1.Text = "Employees salary";
            label1.Click += label1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            // 
            // Sslary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 561);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sslary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sslary";
            Load += Sslary_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox WorkedTb;
        private Label label7;
        private Label label5;
        private Label EmpName;
        private TextBox EmpNameTb;
        private Label EmpId;
        private TextBox EmpIdTb;
        private TextBox EmpPosTb;
        private Button button5;
        private Label label1;
        private Button button4;
        private RichTextBox SalarySlip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}