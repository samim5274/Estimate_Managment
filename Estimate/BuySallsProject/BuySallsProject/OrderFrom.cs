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
    public partial class OrderFrom : Form
    {
        public OrderFrom()
        {
            InitializeComponent();
        }

        private void OrderFrom_Load(object sender, EventArgs e)
        {
            dtpOrderDate.Value = DateTime.Now;
            dtpDeliveryDate.Value = DateTime.Now;

            FillCustomar();
            FillItem();
        }

        private void Cleartext()
        {
            txtOrderid.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtAdvance.Text = string.Empty;
            cbxItemName.ValueMember = string.Empty;
            cbxCustomarName.ValueMember = string.Empty;
        }

        private void FillItem()
        {
            var OrderManager = new Manager();
            var list = OrderManager.GettAllItem();
            cbxItemName.DisplayMember = "I_Name";
            cbxItemName.ValueMember = "ItemId";
            cbxItemName.DataSource = list;
        }

        private void FillCustomar()
        {
            var OrderManager = new Manager();
            var list = OrderManager.GettCustomar();
            cbxCustomarName.DisplayMember = "C_Name";
            cbxCustomarName.ValueMember = "CustomarId";
            cbxCustomarName.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var estimateObj = new ESTIMATEEntities();
                var Objorder = new OrderInfo();

                Objorder.OrderId = Convert.ToInt32(txtOrderid.Text.Trim());
                Objorder.CustomarId = Convert.ToInt32(cbxCustomarName.SelectedValue);
                Objorder.ItemId = Convert.ToInt32(cbxItemName.SelectedValue);
                Objorder.OrderDate = Convert.ToDateTime(dtpOrderDate.Value);
                Objorder.DeliveryDate = Convert.ToDateTime(dtpDeliveryDate.Value);
                Objorder.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                Objorder.AdvancePay = Convert.ToInt32(txtAdvance.Text.Trim());
                Objorder.TotalMoney = Convert.ToInt32(txtTotal.Text.Trim());

                estimateObj.AddToOrderInfoes(Objorder);
                estimateObj.SaveChanges();
                MessageBox.Show("Order Success !...");
                Cleartext();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Order Id Avilable is here.please try to another order id.Thank you..!!");
            }
        }

        private void btnAddCustomar_Click(object sender, EventArgs e)
        {
            var obj = new AddCustomar();
            obj.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var obj = new AddItem();
            obj.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Cleartext();
        }
    }
}
