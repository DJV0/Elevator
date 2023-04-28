namespace Elevator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button10 = new Button();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 3;
            label5.Text = "4";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Location = new Point(652, 3);
            button4.Name = "button4";
            button4.Size = new Size(93, 34);
            button4.TabIndex = 4;
            button4.Text = "Down";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDown_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 2;
            label4.Text = "3";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 127);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 1;
            label3.Text = "2";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(552, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 3;
            button3.Text = "Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUp_Click;
            // 
            // button5
            // 
            button5.Location = new Point(652, 43);
            button5.Name = "button5";
            button5.Size = new Size(93, 34);
            button5.TabIndex = 7;
            button5.Text = "Down";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonDown_Click;
            // 
            // button6
            // 
            button6.Location = new Point(552, 43);
            button6.Name = "button6";
            button6.Size = new Size(94, 34);
            button6.TabIndex = 6;
            button6.Text = "Up";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonUp_Click;
            // 
            // button7
            // 
            button7.Location = new Point(652, 83);
            button7.Name = "button7";
            button7.Size = new Size(93, 34);
            button7.TabIndex = 9;
            button7.Text = "Down";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonDown_Click;
            // 
            // button9
            // 
            button9.Location = new Point(652, 163);
            button9.Name = "button9";
            button9.Size = new Size(93, 34);
            button9.TabIndex = 10;
            button9.Text = "Down";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonDown_Click;
            // 
            // button8
            // 
            button8.Location = new Point(552, 83);
            button8.Name = "button8";
            button8.Size = new Size(94, 34);
            button8.TabIndex = 8;
            button8.Text = "Up";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonUp_Click;
            // 
            // button10
            // 
            button10.Location = new Point(552, 163);
            button10.Name = "button10";
            button10.Size = new Size(94, 34);
            button10.TabIndex = 11;
            button10.Text = "Up";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonUp_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 168);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 1;
            label2.Text = "1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(270, 160);
            label1.Name = "label1";
            label1.Size = new Size(36, 42);
            label1.TabIndex = 5;
            label1.Text = "Lift";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 3, 3);
            tableLayoutPanel1.Controls.Add(button1, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button9, 3, 4);
            tableLayoutPanel1.Controls.Add(button5, 3, 1);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 3, 2);
            tableLayoutPanel1.Controls.Add(button10, 2, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(748, 202);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 4;
            label6.Text = "5";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(652, 123);
            button2.Name = "button2";
            button2.Size = new Size(93, 34);
            button2.TabIndex = 11;
            button2.Text = "Down";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(552, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 12;
            button1.Text = "Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 551);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button9;
        private Button button10;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
    }
}