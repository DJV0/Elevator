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
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button4, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 2, 2);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(487, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(391, 43);
            button4.Name = "button4";
            button4.Size = new Size(93, 34);
            button4.TabIndex = 4;
            button4.Text = "Down";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDown_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 3);
            button2.Name = "button2";
            button2.Size = new Size(93, 34);
            button2.TabIndex = 2;
            button2.Text = "Down";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDown_Click;
            // 
            // button1
            // 
            button1.Location = new Point(291, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 1;
            button1.Text = "Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonUp_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 43);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 3;
            button3.Text = "Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUp_Click;
            // 
            // button5
            // 
            button5.Location = new Point(391, 83);
            button5.Name = "button5";
            button5.Size = new Size(93, 34);
            button5.TabIndex = 7;
            button5.Text = "Down";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonDown_Click;
            // 
            // button6
            // 
            button6.Location = new Point(291, 83);
            button6.Name = "button6";
            button6.Size = new Size(94, 34);
            button6.TabIndex = 6;
            button6.Text = "Up";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonUp_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(126, 80);
            label1.Name = "label1";
            label1.Size = new Size(36, 70);
            label1.TabIndex = 5;
            label1.Text = "Lift";
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
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
    }
}