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
    public partial class SelaryInformation : Form
    {
        public SelaryInformation()
        {
            InitializeComponent();
        }

        private void SelaryInformation_Load(object sender, EventArgs e)
        {
            FillEmployName();
            FillDepartment();
        }

        private void FillDepartment()
        {
            var objMgnr = new Manager();
            var list = objMgnr.GettAllDepartment();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentId";
            cbxDepartment.DataSource = list;
        }

        private void FillEmployName()
        {
            var objMngr = new Manager();
            var list = objMngr.GetAllEmployName();
            cbxEmployName.DisplayMember = "E_Name";
            cbxEmployName.ValueMember = "EmployId";
            cbxEmployName.DataSource = list;
        }

        private void btnSelarySave_Click(object sender, EventArgs e)
        {
            var objEsti = new ESTIMATEEntities();
            var objslry = new SelayInformation();

            objslry.SelaryId = Convert.ToInt32(txtSelaryId.Text.Trim());
            objslry.EmployId = Convert.ToInt32(cbxEmployName.SelectedValue);
            objslry.Date = Convert.ToDateTime(dtpSelaryDate.Value);
            objslry.Department = Convert.ToInt32(cbxDepartment.SelectedValue);
            objslry.Ammount = Convert.ToInt32(txtAmmount.Text.Trim());

            objEsti.AddToSelayInformations(objslry);
            objEsti.SaveChanges();
            MessageBox.Show(@"Selary has been successfully.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
