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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           //int cateId = Convert.ToInt32(CbxCategory.SelectedValue);
            //var list = new Manager().GetItem(cateId);

            //CbxItemName.SelectedValue = "";
            //CbxItemName.DisplayMember = "I_Name";
            //CbxItemName.ValueMember = "ItemId";
            //CbxItemName.DataSource = list;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            FillCustomer();
            FillCategory();
            FillItem();
        }

        private void FillItem()
        {
            //var mngr = new Manager();
            //var list = mngr.GetAllItem();
            //CbxItemName.DisplayMember = "I_Name";
            //CbxItemName.ValueMember = "ItemId";
            //CbxItemName.DataSource = list;
        }

        private void FillCategory()
        {
            //var BuyManager = new Manager();
            //var list = BuyManager.GettAllCatagory();
            //CbxCategory.DisplayMember = "C_Name";
            //CbxCategory.ValueMember = "CatagoryId";
            //CbxCategory.DataSource = list;
        }

        private void FillCustomer()
        {
            var mngr = new Manager();
            var list = mngr.GetCustomer();
            cbxCustomer.DisplayMember = "C_Name";
            cbxCustomer.ValueMember = "CustomarId";
            cbxCustomer.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //jh
        }

        
    }
}
