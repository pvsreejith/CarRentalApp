using System;
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
    public partial class MainWindow : Form
    {
        private login _login;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(login login)
        {
            InitializeComponent();
            _login = login;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCarRentalRecord = new AddRentalRecord();
            addCarRentalRecord.MdiParent = this;
            addCarRentalRecord.Show();
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new Manage_Vehicle_Listing();
            vehicleListing.MdiParent = this;
            vehicleListing.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
