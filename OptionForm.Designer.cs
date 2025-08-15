using System;

namespace ATM
{
    partial class OptionForm
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

        public void SetTextBoxValue(string value)
        {
            this.textBox1.Text = value;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelChooseOption = new Label();
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
            labelHelloAcc = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelChooseOption
            // 
            labelChooseOption.AutoSize = true;
            labelChooseOption.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelChooseOption.ForeColor = Color.White;
            labelChooseOption.Location = new Point(91, 204);
            labelChooseOption.Margin = new Padding(4, 0, 4, 0);
            labelChooseOption.Name = "labelChooseOption";
            labelChooseOption.Size = new Size(531, 32);
            labelChooseOption.TabIndex = 0;
            labelChooseOption.Text = "Please choose from the following options";
            labelChooseOption.Click += labelChooseOption_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Brown;
            buttonEnter.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnter.Location = new Point(375, 584);
            buttonEnter.Margin = new Padding(4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(202, 81);
            buttonEnter.TabIndex = 27;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += InvalidOption_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(375, 496);
            buttonClear.Margin = new Padding(4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(202, 81);
            buttonClear.TabIndex = 26;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += InvalidOption_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightCoral;
            buttonCancel.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(375, 405);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(202, 81);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += InvalidOption_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(182, 674);
            button0.Margin = new Padding(4);
            button0.Name = "button0";
            button0.Size = new Size(84, 83);
            button0.TabIndex = 24;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += InvalidOption_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(274, 584);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(84, 83);
            button9.TabIndex = 23;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += InvalidOption_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(182, 584);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(84, 83);
            button8.TabIndex = 22;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += InvalidOption_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(91, 584);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(84, 83);
            button7.TabIndex = 21;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InvalidOption_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(274, 492);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(84, 83);
            button6.TabIndex = 20;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += InvalidOption_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(182, 492);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(84, 83);
            button5.TabIndex = 19;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += InvalidOption_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(91, 492);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(84, 83);
            button4.TabIndex = 18;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += InvalidOption_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(274, 401);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(84, 83);
            button3.TabIndex = 17;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;

            var instance3 = ClassInFile2.SharedInstance;
            textBox1.Text = instance3.a;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(182, 401);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(84, 83);
            button2.TabIndex = 16;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            var instance2 = ClassInFile2.SharedInstance;
            textBox1.Text = instance2.a;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 401);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(84, 83);
            button1.TabIndex = 15;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            var instance1 = ClassInFile2.SharedInstance;
            textBox1.Text = instance1.a;
            // 
            // labelOptions
            // 
            labelOptions.AutoSize = true;
            labelOptions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOptions.ForeColor = Color.White;
            labelOptions.Location = new Point(91, 267);
            labelOptions.Margin = new Padding(4, 0, 4, 0);
            labelOptions.Name = "labelOptions";
            labelOptions.Size = new Size(220, 87);
            labelOptions.TabIndex = 28;
            labelOptions.Text = "[1] withdraw money\r\n[2] check balance\r\n[3] return card";
            labelOptions.Click += labelOptions_Click;
            // 
            // labelHelloAcc
            // 
            labelHelloAcc.AutoSize = true;
            labelHelloAcc.Font = new Font("Showcard Gothic", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHelloAcc.ForeColor = Color.White;
            labelHelloAcc.Location = new Point(65, 68);
            labelHelloAcc.Margin = new Padding(4, 0, 4, 0);
            labelHelloAcc.Name = "labelHelloAcc";
            labelHelloAcc.Size = new Size(570, 119);
            labelHelloAcc.TabIndex = 29;
            labelHelloAcc.Text = "Welcome! ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(715, 405);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 260);
            textBox1.TabIndex = 30;
            textBox1.Text = "\r\n";
            textBox1.TextChanged += textBox1_TextChanged_1;
            var instance = ClassInFile2.SharedInstance;
            textBox1.Text = instance.a;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1100, 849);
            Controls.Add(textBox1);
            Controls.Add(labelHelloAcc);
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
            Controls.Add(labelChooseOption);
            Margin = new Padding(4);
            Name = "OptionForm";
            Text = "OptionForm";
            Load += OptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelChooseOption;
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
        private System.Windows.Forms.Label labelHelloAcc;
        private System.Windows.Forms.TextBox textBox1;
    }
}