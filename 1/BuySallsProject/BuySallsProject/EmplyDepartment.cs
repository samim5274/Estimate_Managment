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
    public partial class EmplyDepartment : Form
    {
        public EmplyDepartment()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var objEst = new ESTIMATEEntities();
                var objDepart = new EmpolyDipartment();

                objDepart.DepartmentId = Convert.ToInt32(txtEDId.Text.Trim());
                objDepart.DepartmentName = txtEDepartmentName.Text.Trim();

                objEst.AddToEmpolyDipartments(objDepart);
                objEst.SaveChanges();
                MessageBox.Show(@"Save Sucessfully");
                ClearTextbos();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error!Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void ClearTextbos()
        {
            txtEDId.Text = string.Empty;
            txtEDepartmentName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextbos();
        }
    }
}
