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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        private void AddItem_Load(object sender, EventArgs e)
        {
            dtpExpDate.Value = DateTime.Now;
            dtpMgfDate.Value = DateTime.Now;

            FillCatagory();
        }

        private void FillCatagory()
        {
            var BuyManager = new Manager();
            var list = BuyManager.GettAllCatagory();
            cbxCatagory.DisplayMember = "C_Name";
            cbxCatagory.ValueMember = "CatagoryId";
            cbxCatagory.DataSource = list;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            var objEstimate = new ESTIMATEEntities();
            var objItem = new ItemInfo();

            objItem.ItemId = Convert.ToInt32(txtId.Text.Trim());
            objItem.I_Name = txtName.Text.Trim();

            objItem.I_CatagoryId = Convert.ToInt32(cbxCatagory.SelectedValue);

            objItem.I_ExoDate = Convert.ToDateTime(dtpExpDate.Value);
            objItem.I_MgfDate = Convert.ToDateTime(dtpMgfDate.Value);
            objItem.I_BuyPrice = Convert.ToInt32(txtBuyPrice.Text.Trim());

            objEstimate.AddToItemInfoes(objItem);
            objEstimate.SaveChanges();
            MessageBox.Show(@"Add Item Successfully.");
            ClearTextbox();
            //try
            //{
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            //}
        }

        private void ClearTextbox()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtBuyPrice.Text = string.Empty;
            cbxCatagory.SelectedValue = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatagoryAdd_Click(object sender, EventArgs e)
        {
            var obj = new AddCatagory();
            obj.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

    }
}
