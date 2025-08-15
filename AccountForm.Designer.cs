namespace ATM
{
    partial class AccountForm
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
            labelEnterAcc = new Label();
            TextBoxAcc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonCancel = new Button();
            buttonClear = new Button();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // labelEnterAcc
            // 
            labelEnterAcc.AutoSize = true;
            labelEnterAcc.Font = new Font("Old English Text MT", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEnterAcc.ForeColor = Color.IndianRed;
            labelEnterAcc.Location = new Point(118, 96);
            labelEnterAcc.Margin = new Padding(4, 0, 4, 0);
            labelEnterAcc.Name = "labelEnterAcc";
            labelEnterAcc.Size = new Size(909, 57);
            labelEnterAcc.TabIndex = 0;
            labelEnterAcc.Text = "Please enter your account at the textbox below\r\n";
            // 
            // TextBoxAcc
            // 
            TextBoxAcc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxAcc.Location = new Point(249, 191);
            TextBoxAcc.Margin = new Padding(4);
            TextBoxAcc.Name = "TextBoxAcc";
            TextBoxAcc.Size = new Size(591, 35);
            TextBoxAcc.TabIndex = 1;
            TextBoxAcc.Text = "(Input account number here)";
            TextBoxAcc.UseWaitCursor = true;
            TextBoxAcc.TextChanged += TextBoxAcc_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(142, 404);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(84, 83);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(234, 404);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(84, 83);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(326, 404);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(84, 83);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(142, 495);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(84, 83);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(234, 495);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(84, 83);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(326, 495);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(84, 83);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(142, 586);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(84, 83);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(234, 586);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(84, 83);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(326, 586);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(84, 83);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(234, 677);
            button0.Margin = new Padding(4);
            button0.Name = "button0";
            button0.Size = new Size(84, 83);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += NumberButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.Font = new Font("Segoe Script", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(430, 406);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(202, 81);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 128, 128);
            buttonClear.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(430, 497);
            buttonClear.Margin = new Padding(4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(202, 81);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.MistyRose;
            buttonEnter.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnter.Location = new Point(430, 586);
            buttonEnter.Margin = new Padding(4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(202, 81);
            buttonEnter.TabIndex = 14;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1100, 801);
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
            Controls.Add(TextBoxAcc);
            Controls.Add(labelEnterAcc);
            Margin = new Padding(4);
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelEnterAcc;
        private System.Windows.Forms.TextBox TextBoxAcc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEnter;
    }
}