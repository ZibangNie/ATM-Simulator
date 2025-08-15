namespace ATM
{
    partial class BankSystem
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
            labelHelloBank = new Label();
            labelChooseRace = new Label();
            buttonRace = new Button();
            buttonNonRace = new Button();
            buttonLaunchATM = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelHelloBank
            // 
            labelHelloBank.AutoSize = true;
            labelHelloBank.Font = new Font("Wide Latin", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHelloBank.ForeColor = Color.White;
            labelHelloBank.Location = new Point(70, 133);
            labelHelloBank.Margin = new Padding(4, 0, 4, 0);
            labelHelloBank.Name = "labelHelloBank";
            labelHelloBank.Size = new Size(989, 88);
            labelHelloBank.TabIndex = 0;
            labelHelloBank.Text = "ATM Simulator";
            // 
            // labelChooseRace
            // 
            labelChooseRace.AutoSize = true;
            labelChooseRace.Font = new Font("Lucida Calligraphy", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelChooseRace.ForeColor = Color.White;
            labelChooseRace.Location = new Point(225, 305);
            labelChooseRace.Margin = new Padding(4, 0, 4, 0);
            labelChooseRace.Name = "labelChooseRace";
            labelChooseRace.Size = new Size(668, 41);
            labelChooseRace.TabIndex = 1;
            labelChooseRace.Text = "Please choose one of the options below:";
            // 
            // buttonRace
            // 
            buttonRace.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRace.Location = new Point(300, 388);
            buttonRace.Margin = new Padding(4);
            buttonRace.Name = "buttonRace";
            buttonRace.Size = new Size(253, 83);
            buttonRace.TabIndex = 2;
            buttonRace.Text = "DATA RACE";
            buttonRace.UseVisualStyleBackColor = true;
            buttonRace.Click += buttonRace_Click;
            // 
            // buttonNonRace
            // 
            buttonNonRace.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNonRace.Location = new Point(561, 388);
            buttonNonRace.Margin = new Padding(4);
            buttonNonRace.Name = "buttonNonRace";
            buttonNonRace.Size = new Size(253, 83);
            buttonNonRace.TabIndex = 3;
            buttonNonRace.Text = "NON-DATA RACE";
            buttonNonRace.UseVisualStyleBackColor = true;
            buttonNonRace.Click += buttonNonRace_Click;
            // 
            // buttonLaunchATM
            // 
            buttonLaunchATM.BackColor = Color.IndianRed;
            buttonLaunchATM.Font = new Font("Mistral", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLaunchATM.Location = new Point(613, 507);
            buttonLaunchATM.Margin = new Padding(4);
            buttonLaunchATM.Name = "buttonLaunchATM";
            buttonLaunchATM.Size = new Size(165, 76);
            buttonLaunchATM.TabIndex = 4;
            buttonLaunchATM.Text = "START";
            buttonLaunchATM.UseVisualStyleBackColor = false;
            buttonLaunchATM.Click += buttonLaunchATM_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.IndianRed;
            buttonExit.Font = new Font("Mistral", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(340, 507);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(165, 76);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // BankSystem
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1100, 801);
            Controls.Add(buttonExit);
            Controls.Add(buttonLaunchATM);
            Controls.Add(buttonNonRace);
            Controls.Add(buttonRace);
            Controls.Add(labelChooseRace);
            Controls.Add(labelHelloBank);
            Margin = new Padding(6);
            Name = "BankSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHelloBank;
        private System.Windows.Forms.Label labelChooseRace;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.Button buttonNonRace;
        private System.Windows.Forms.Button buttonLaunchATM;
        private System.Windows.Forms.Button buttonExit;
    }
}

