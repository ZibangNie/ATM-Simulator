﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATM
{
    public partial class BankSystem : Form
    {
        private Thread ATM1, ATM2;
        public Account[] ac = new Account[3];
        public Account currentAccountNum;   //use this in combination with the AtmControl semaphore

        public BankSystem()
        {
            InitializeComponent();

            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitAtm()
        {
            var atm = new AtmMachine(ac);
            atm.launchForm();
        }

        private void buttonLaunchATM_Click(object sender, EventArgs e)
        {
            ATM1 = new Thread(new ThreadStart(InitAtm)); //creating a thread
            ATM1.Start();

            ATM2 = new Thread(new ThreadStart(InitAtm));
            ATM2.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ATM1.Abort(); //correctly stopping threads to not create memory leaks
            ATM2.Abort();
            
            Application.Exit();
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            Bank.isDataRace = true;
        }

        private void buttonNonRace_Click(object sender, EventArgs e)
        {
            Bank.isDataRace = false;
        }
    }
}
