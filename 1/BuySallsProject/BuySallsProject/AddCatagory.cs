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
    public partial class AddCatagory : Form
    {
        public AddCatagory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var objEstimate = new ESTIMATEEntities();
                var objCatagory = new CatagoryInfo();

                objCatagory.CatagoryId = Convert.ToInt32(txtCId.Text.Trim());
                objCatagory.C_Name = txtCName.Text.Trim();

                objEstimate.AddToCatagoryInfoes(objCatagory);
                objEstimate.SaveChanges();
                MessageBox.Show(@"Add Catagory Successfully.");
                ClearTextbox();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error!Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void ClearTextbox()
        {
            txtCId.Text = string.Empty;
            txtCName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

       
    }
}
