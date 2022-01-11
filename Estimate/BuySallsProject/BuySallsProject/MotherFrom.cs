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
    public partial class MotherFrom : Form
    {
        public MotherFrom()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void customarInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddCustomar();
            obj.ShowDialog();
        }

        private void catagoryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddCatagory();
            obj.ShowDialog();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddItem();
            obj.ShowDialog();
        }

        private void sellofProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new Sell();
            obj.ShowDialog();
        }

        private void saleformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new OrderFrom();
            obj.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var obj = new OrderFrom();
            obj.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var obj = new AddItem();
            obj.ShowDialog();
        }

        private void btnSalls_Click(object sender, EventArgs e)
        {
            //var obj = new Sell();
            //obj.ShowDialog();
        }

        private void btnAddCustomar_Click(object sender, EventArgs e)
        {
            var obj = new AddCustomar();
            obj.ShowDialog();
        }

        private void btnCatagory_Click(object sender, EventArgs e)
        {
            var obj = new AddCatagory();
            obj.ShowDialog();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new Others();
            obj.ShowDialog();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label1.Text = DateTime.Now.ToString("T");
            label2.Text = DateTime.Now.ToString("dddd");
            label3.Text = DateTime.Now.ToString("MMM-dd-yyy");
        }
    }
}
