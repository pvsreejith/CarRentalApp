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
    public partial class Manage_Vehicle_Listing : Form
    {
        private readonly CarRentalEntities _db;
        public Manage_Vehicle_Listing()
        {
            
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void Manage_Vehicle_Listing_Load(object sender, EventArgs e)
        {
            //var cars = _db.typeOfCars.ToList();
            var cars = _db.typeOfCars.Select(q => new { ID = q.id, Name = q.carType }).ToList();
            gvVehicleList.DataSource = cars;

            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "Name";

            //gvVehicleList.Columns[2].Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}
