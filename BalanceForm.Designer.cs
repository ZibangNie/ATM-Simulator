namespace ATM
{
    partial class BalanceForm
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
            labelDisplayBalance = new Label();
            labelBalance = new Label();
            buttonEnter = new Button();
            buttonClear = new Button();
            buttonCancel = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelOptions = new Label();
            SuspendLayout();
            // 
            // labelDisplayBalance
            // 
            labelDisplayBalance.AutoSize = true;
            labelDisplayBalance.Font = new Font("Poor Richard", 22F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDisplayBalance.ForeColor = Color.DimGray;
            labelDisplayBalance.Location = new Point(323, 88);
            labelDisplayBalance.Margin = new Padding(4, 0, 4, 0);
            labelDisplayBalance.Name = "labelDisplayBalance";
            labelDisplayBalance.Size = new Size(417, 51);
            labelDisplayBalance.TabIndex = 0;
            labelDisplayBalance.Text = "Your account balance is:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.ForeColor = Color.White;
            labelBalance.Location = new Point(208, 187);
            labelBalance.Margin = new Padding(4, 0, 4, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(28, 65);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "\r\n";
            labelBalance.Click += labelBalance_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.RosyBrown;
            buttonEnter.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnter.Location = new Point(415, 623);
            buttonEnter.Margin = new Padding(4, 4, 4, 4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(202, 81);
            buttonEnter.TabIndex = 40;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += InvalidOption_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.LightCoral;
            buttonClear.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(415, 532);
            buttonClear.Margin = new Padding(4, 4, 4, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(202, 81);
            buttonClear.TabIndex = 39;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += InvalidOption_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Font = new Font("Segoe Print", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(415, 442);
            buttonCancel.Margin = new Padding(4, 4, 4, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(202, 81);
            buttonCancel.TabIndex = 38;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonGoBack_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(208, 713);
            button0.Margin = new Padding(4, 4, 4, 4);
            button0.Name = "button0";
            button0.Size = new Size(84, 83);
            button0.TabIndex = 37;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += InvalidOption_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(300, 623);
            button9.Margin = new Padding(4, 4, 4, 4);
            button9.Name = "button9";
            button9.Size = new Size(84, 83);
            button9.TabIndex = 36;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += InvalidOption_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(208, 623);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(84, 83);
            button8.TabIndex = 35;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += InvalidOption_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(117, 623);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(84, 83);
            button7.TabIndex = 34;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InvalidOption_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(300, 530);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(84, 83);
            button6.TabIndex = 33;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += InvalidOption_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(208, 530);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(84, 83);
            button5.TabIndex = 32;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += InvalidOption_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(117, 530);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(84, 83);
            button4.TabIndex = 31;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += InvalidOption_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(300, 440);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(84, 83);
            button3.TabIndex = 30;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += InvalidOption_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(208, 439);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(84, 83);
            button2.TabIndex = 29;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(116, 439);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(84, 83);
            button1.TabIndex = 28;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonGoBack_Click;
            // 
            // labelOptions
            // 
            labelOptions.AutoSize = true;
            labelOptions.Font = new Font("Segoe Print", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelOptions.ForeColor = Color.White;
            labelOptions.Location = new Point(117, 357);
            labelOptions.Margin = new Padding(4, 0, 4, 0);
            labelOptions.Name = "labelOptions";
            labelOptions.Size = new Size(355, 49);
            labelOptions.TabIndex = 41;
            labelOptions.Text = "[1] return to last page \r\n";
            labelOptions.Click += labelOptions_Click;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1100, 864);
            Controls.Add(labelOptions);
            Controls.Add(buttonEnter);
            Controls.Add(buttonClear);
            Controls.Add(buttonCancel);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelBalance);
            Controls.Add(labelDisplayBalance);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BalanceForm";
            Text = "BalanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDisplayBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOptions;
    }
}