using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuySallsProject
{
    public partial class AddCustomar : Form
    {
        public AddCustomar()
        {
            InitializeComponent();
        }

        private void btnAddCustomar_Click(object sender, EventArgs e)
        {
            try
            {
                var objEstimate = new ESTIMATEEntities();

                var objcustomar = new CustomarInfo();

                objcustomar.CustomarId = Convert.ToInt32(txtId.Text.Trim());
                objcustomar.C_Name = txtName.Text.Trim();
                objcustomar.C_Address = txtAddress.Text.Trim();
                objcustomar.C_Phone = Convert.ToInt32(txtPhone.Text.Trim());
                objcustomar.C_Type = txtType.Text.Trim();

                objEstimate.AddToCustomarInfoes(objcustomar);
                objEstimate.SaveChanges();
                MessageBox.Show(@"Successfully");
                ClearTextbos();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error!Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void ClearTextbos()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtType.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearTextbos();
        }
    }
}
