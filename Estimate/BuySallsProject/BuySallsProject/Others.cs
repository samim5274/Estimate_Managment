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
    public partial class Others : Form
    {
        public Others()
        {
            InitializeComponent();
        }

        private void departmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new EmplyDepartment();
            obj.ShowDialog();
        }

        private void employInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new EmpolyInformation();
            obj.ShowDialog();
        }

        private void salatryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SelaryInformation();
            obj.ShowDialog();
        }
    }
}
