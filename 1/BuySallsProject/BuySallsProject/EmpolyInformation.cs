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
    public partial class EmpolyInformation : Form
    {
        public EmpolyInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpolyInformation_Load(object sender, EventArgs e)
        {
            FillDepartment();
        }

        private void FillDepartment()
        {
            var mngr = new Manager();
            var list = mngr.GettAllDepartment();
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var objEst = new ESTIMATEEntities();
                var objEmpoly = new EmpolyInfo();

                objEmpoly.EmpolyId = Convert.ToInt32(txtID.Text.Trim());
                objEmpoly.E_Name = txtName.Text.Trim();
                objEmpoly.E_Address = txtAddress.Text.Trim();
                objEmpoly.E_Department = Convert.ToInt32(cbxDepartment.SelectedValue);
                objEmpoly.E_DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
                objEmpoly.E_JoinDate = Convert.ToDateTime(dtpJoinDate.Value);
                objEmpoly.E_Phone = Convert.ToInt32(txtPhone.Text.Trim());

                objEst.AddToEmpolyInfoes(objEmpoly);
                objEst.SaveChanges();
                MessageBox.Show(@"Employ Add Successfully.");
                ClearTextbox();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Employ Id Avilable is here.please try to another order id.Thank you..!!");
            }
        }

        private void ClearTextbox()
        {
            txtPhone.Text = string.Empty;
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cbxDepartment.SelectedValue = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var obj = new EmplyDepartment();
            obj.ShowDialog();
        }
    }
}
