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
    public partial class AddRentalRecord : Form
    {
        //Add a comment to test fetch
        private readonly CarRentalEntities carRentalEntities;
        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                string customerName = tbCustomerName.Text;
                var cost = tbCost.Text;
                DateTime dateOut = dtpRented.Value;
                DateTime dateIn = dtpReturned.Value;

                var carType = cbTypeOfCar.Text;
                bool flag = true;
                var errorMessage = ""; 



                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    flag = false;
                    errorMessage += "Error : Please enter missing data\n\r";
                }

                if (dateOut > dateIn)
                {
                    flag = false;
                    errorMessage += "Error : Illegal Date Selection\n\r";
                }

                if (flag)
                {

                    var rentalInfo = new rentalInfo();
                    rentalInfo.customerName = customerName;
                    rentalInfo.dateRented = dateOut;
                    rentalInfo.dateReturned = dateIn;
                    rentalInfo.cost = decimal.Parse(cost);
                    rentalInfo.carId = (int)cbTypeOfCar.SelectedValue;

                    //saving data into the database
                    carRentalEntities.rentalInfoes.Add(rentalInfo);
                    carRentalEntities.SaveChanges();

                   MessageBox.Show($"Customer Name : {customerName} \n\r" +
                   $"Cost : {cost}" +
                   $"Date Rented : {dateOut}\n\r" +
                   $"Date Returned : {dateIn}\n\r" +
                   $"Car Type : {carType}\n\r" +
                   $"THANK YOU FOR USING OUR SERVICE");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

                     

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select * from typeOfCars
            var cars = carRentalEntities.typeOfCars.ToList();
            cbTypeOfCar.DisplayMember = "carType"; //field name in the table
            cbTypeOfCar.ValueMember = "id"; 
            cbTypeOfCar.DataSource = cars;
        }
    }
}
