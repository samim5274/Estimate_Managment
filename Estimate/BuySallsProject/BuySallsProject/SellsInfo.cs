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
    public partial class SellsInfo : Form
    {
        public SellsInfo()
        {
            InitializeComponent();
        }

        private void SellsInfo_Load(object sender, EventArgs e)
        {
            FillCatagory();
            FillCustomar();
            FillItem();
        }

        private void FillCatagory()
        {
            var mng = new Manager();
            var list = mng.GettAllCatagory();
            cbxCatagory.DisplayMember = "C_Name";
            cbxCatagory.ValueMember = "CatagoryId";
            cbxCatagory.DataSource = list;
        }

        private void FillCustomar()
        {
            var mng = new Manager();
            var list = mng.GetCustomer();
            cbxCustomarId.DisplayMember = "C_Name";
            cbxCustomarId.ValueMember = "CustomarId";
            cbxCustomarId.DataSource = list;
        }

        private void FillItem()
        {
            var mng = new Manager();
            var list = mng.GetAllItem();
            cbxItemName.DisplayMember = "I_Name";
            cbxItemName.ValueMember = "ItemId";
            cbxItemName.DataSource = list;
        }

        private void cbxCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catId = Convert.ToInt32(cbxCatagory.SelectedValue);
            var list = new Manager().GetAllItem(catId);

         //   cbxItemName.SelectedValue = "";
            cbxItemName.DisplayMember = "I_Name";
            cbxItemName.ValueMember = "ItemId";
            cbxItemName.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

          
                var objEstimate = new ESTIMATEEntities();
                var objSells = new SaleInfo();

                objSells.SaleId = Convert.ToInt32(txtId.Text.Trim());
                objSells.SaleDate = Convert.ToDateTime(dtpSalesDate.Value);
                objSells.CustomerId = Convert.ToInt32(cbxCustomarId.SelectedValue);
                objSells.CategoryId = Convert.ToInt32(cbxCatagory.SelectedValue);
            
               // objSells.ItemId = Convert.ToInt32(cbxItemName.SelectedValue); create txtbox

                objSells.UnitPrice = Convert.ToInt32(txtPrice.Text.Trim());
                objSells.Quantity = Convert.ToInt32(txtWuantity.Text.Trim());

                objEstimate.AddToSaleInfoes(objSells);
                objEstimate.SaveChanges();
                MessageBox.Show(@"Sell Successfully!!!....");
                ClearTextbox();
          
        }

        private void ClearTextbox()
        {
            txtId.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtWuantity.Text = string.Empty;
            cbxItemName.ValueMember = string.Empty;
            cbxCustomarId.ValueMember = string.Empty;
            cbxCatagory.ValueMember = string.Empty;
        }
    }
}
