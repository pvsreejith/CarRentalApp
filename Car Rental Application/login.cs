﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_Rental_Application
{
    public partial class login : Form
    {
        private readonly CarRentalEntities _db;
        public login()
        {
            _db = new CarRentalEntities();
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Add comment for git testing
                var userName = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                
                var user = _db.users.FirstOrDefault(q => q.userName == userName && q.password == password);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainWindow = new MainWindow(this);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again");
            }
        }
    }
}
