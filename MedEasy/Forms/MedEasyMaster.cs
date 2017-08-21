using MedEasy.Forms.item;
using MedEasy.Forms.stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedEasy.Forms
{
    public partial class MedEasyMaster : Form
    {
        public MedEasyMaster()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }   
        }

        private void openingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockEntry childForm = new StockEntry();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemEntry childForm = new ItemEntry();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;
        }
    }
}
