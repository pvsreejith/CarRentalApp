
namespace Car_Rental_Application
{
    partial class Manage_Vehicle_Listing
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
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(1, 97);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(241, 247);
            this.gvVehicleList.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeading.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(187, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(476, 46);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Manage Vehicle Listing";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(286, 97);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(112, 23);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(286, 139);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(112, 23);
            this.btnEditCar.TabIndex = 2;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(286, 182);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteCar.TabIndex = 2;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // Manage_Vehicle_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gvVehicleList);
            this.Name = "Manage_Vehicle_Listing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.Manage_Vehicle_Listing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}