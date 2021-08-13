
namespace Car_Rental_Application
{
    partial class AddRentalRecord
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lblRented = new System.Windows.Forms.Label();
            this.dtpRented = new System.Windows.Forms.DateTimePicker();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblTypeOfCar = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeading.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(228, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(264, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Add Rental Record";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(32, 134);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(226, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(28, 99);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(131, 23);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(417, 99);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(45, 23);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(421, 134);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(226, 20);
            this.tbCost.TabIndex = 1;
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.Location = new System.Drawing.Point(28, 196);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(102, 23);
            this.lblRented.TabIndex = 2;
            this.lblRented.Text = "Date Rented";
            // 
            // dtpRented
            // 
            this.dtpRented.Location = new System.Drawing.Point(32, 231);
            this.dtpRented.Name = "dtpRented";
            this.dtpRented.Size = new System.Drawing.Size(226, 20);
            this.dtpRented.TabIndex = 3;
            // 
            // dtpReturned
            // 
            this.dtpReturned.Location = new System.Drawing.Point(421, 231);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(226, 20);
            this.dtpReturned.TabIndex = 3;
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(417, 196);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(118, 23);
            this.lblReturned.TabIndex = 2;
            this.lblReturned.Text = "Date Returned";
            // 
            // lblTypeOfCar
            // 
            this.lblTypeOfCar.AutoSize = true;
            this.lblTypeOfCar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfCar.Location = new System.Drawing.Point(28, 288);
            this.lblTypeOfCar.Name = "lblTypeOfCar";
            this.lblTypeOfCar.Size = new System.Drawing.Size(101, 23);
            this.lblTypeOfCar.TabIndex = 2;
            this.lblTypeOfCar.Text = "Type of  Car";
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(32, 323);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(226, 21);
            this.cbTypeOfCar.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(273, 388);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 37);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dtpReturned);
            this.Controls.Add(this.dtpRented);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblReturned);
            this.Controls.Add(this.lblTypeOfCar);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lblHeading);
            this.Name = "AddRentalRecord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.DateTimePicker dtpRented;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblTypeOfCar;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
    }
}

