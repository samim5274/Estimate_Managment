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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            FillCustomer();
            //FillCategory();
            FillItem();
        }
        private void FillItem()
        {
            var mngr = new Manager();
            var list = mngr.GetAllItem();
           // CbxItemName.DisplayMember = "I_Name";
           // CbxItemName.ValueMember = "ItemId";
           // CbxItemName.DataSource = list;
        }

        private void FillCategory()
        {
            var BuyManager = new Manager();
            var list = BuyManager.GettAllCatagory();
            CbxCategory.DisplayMember = "C_Name";
            CbxCategory.ValueMember = "CatagoryId";
            CbxCategory.DataSource = list;
        }

        private void FillCustomer()
        {
            var mngr = new Manager();
            var list = mngr.GetCustomer();
            cbxCustomer.DisplayMember = "C_Name";
            cbxCustomer.ValueMember = "CustomarId";
            cbxCustomer.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cateId = Convert.ToInt32(CbxCategory.SelectedValue);
            var list = new Manager().GetItem(cateId);

            //CbxItemName.SelectedValue = "";
            //CbxItemName.DisplayMember = "I_Name";
            //CbxItemName.ValueMember = "ItemId";
            //CbxItemName.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var objEstimate = new ESTIMATEEntities();
            var objSells = new SaleInfo();

            objSells.SaleId = Convert.ToInt32(txtid.Text.Trim());
            objSells.SaleDate = Convert.ToDateTime(DtpDate.Value);
            objSells.CustomerId = Convert.ToInt32(cbxCustomer.SelectedValue);

            //objSells.CategoryId = Convert.ToInt32(CbxCategory.SelectedValue);

            //objSells.ItemName = Convert.ToInt32(CbxItemName.SelectedValue) create txtbox

            objSells.ItemName = txtItemName.Text.Trim();

            objSells.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            objSells.UnitPrice = Convert.ToInt32(txtPrice.Text.Trim());

            objEstimate.AddToSaleInfoes(objSells);
            objEstimate.SaveChanges();
            MessageBox.Show("Sell Sucsessfully......!");
            ClearTextbox();

        }
        private void ClearTextbox()
        {
            txtid.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cbxCustomer.ValueMember = string.Empty;
            txtItemName.Text = string.Empty;
            CbxCategory.ValueMember = string.Empty;
        }
    }
}
