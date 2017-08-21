using MedEasy.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedEasy
{
    public partial class Main : Form
    {
        public Main()
        {
            //this.Menu = new MainMenu();
            //MenuItem item = new MenuItem("File");
            //this.Menu.MenuItems.Add(item);
            //item.MenuItems.Add("Save");
            ////item.MenuItems.Add("Save", new EventHandler(Save_Click));
            ////item.MenuItems.Add("Open", new EventHandler(Open_Click));
            //item = new MenuItem("Create");
            //this.Menu.MenuItems.Add(item);
            //item.MenuItems.Add("Item", new EventHandler(CreateItem_Click));
            ////item.MenuItems.Add("Paste", new EventHandler(Paste_Click));
            //item = new MenuItem("List");
            //this.Menu.MenuItems.Add(item);
            ////item.MenuItems.Add("Copy", new EventHandler(Copy_Click));
            ////item.MenuItems.Add("Paste", new EventHandler(Paste_Click));

            InitializeComponent();
            DisplayOffInitialLoad();
            this.WindowState = FormWindowState.Maximized; // make form full screen 
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayOffInitialLoad();
            pnl_CreateItem.Location = new Point(50, this.ClientSize.Height / 2 - pnl_CreateItem.Size.Height / 2);
            pnl_CreateItem.Anchor = AnchorStyles.Left;
            pnl_CreateItem.Visible = true;

            pnl_viewItemGrid.Location = new Point(this.ClientSize.Width - pnl_viewItemGrid.Size.Width - 5, 25);
            pnl_viewItemGrid.Size = new Size(pnl_viewItemGrid.Size.Width, this.ClientSize.Height);
            pnl_viewItemGrid.Anchor = AnchorStyles.Right;
            pnl_viewItemGrid.Visible = true;

            dataGrid_Item.DataSource = new ItemBuss().GetSearchItem();
            
        }

        private void DisplayOffInitialLoad()
        {
            pnl_CreateItem.Visible = false;
            pnl_viewItemGrid.Visible = false;
            pnl_stockOpeningStock.Visible = false;
        }

        private void openingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayOffInitialLoad();
            pnl_stockOpeningStock.Location = new Point(50, this.ClientSize.Height / 2 - pnl_CreateItem.Size.Height / 2);
            pnl_stockOpeningStock.Anchor = AnchorStyles.Left;
            pnl_stockOpeningStock.Visible = true;
            SuspendLayout();
            pnl_stockOpeningStock.BringToFront();
            ResumeLayout();
           

            pnl_viewItemGrid.Location = new Point(this.ClientSize.Width - pnl_viewItemGrid.Size.Width - 5, 25);
            pnl_viewItemGrid.Size = new Size(pnl_viewItemGrid.Size.Width, this.ClientSize.Height);
            pnl_viewItemGrid.Anchor = AnchorStyles.Right;
            pnl_viewItemGrid.Visible = true;

            dataGrid_Item.DataSource = new ItemBuss().GetSearchItem();
        }

        //private void dataGrid_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        private void dataGrid_Item_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid_Item.SelectedRows)
            {
                textBox19.Text = row.Cells[1].Value.ToString();
                textBox20.Text =  row.Cells[0].Value.ToString();
                //...
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox18.Text))
            {
                RefreshGrid();
                return; 
            }

            // Code to search the  alphanumneric Part Number (in Column1 header called "PART NUMBER") and highlihgt the row
            foreach (DataGridViewRow row in dataGrid_Item.Rows)
            {
                //var cellValue = row.Cells["ItemBrandName"].Value;
                if (textBox18.Text.Length < 3 && row.Cells["ItemBrandName"].Value.ToString().ToLower().Contains(textBox18.Text.ToLower()))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells["ItemBrandName"].Value.ToString().ToLower().Equals(textBox18.Text.ToLower()))
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                
            }

        }

        private void RefreshGrid()
        {
            foreach (DataGridViewRow row in dataGrid_Item.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
