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

namespace MedEasy.Forms.item
{
    public partial class ItemEntry : Form
    {
        public ItemEntry()
        {
            InitializeComponent();

            pnl_CreateItem.Location = new Point(50, this.ClientSize.Height / 2 - pnl_CreateItem.Size.Height / 2);
            pnl_CreateItem.Anchor = AnchorStyles.Left;
            pnl_CreateItem.Visible = true;

            pnl_viewItemGrid.Location = new Point(this.ClientSize.Width - pnl_viewItemGrid.Size.Width - 5, 25);
            pnl_viewItemGrid.Size = new Size(pnl_viewItemGrid.Size.Width, this.ClientSize.Height);
            pnl_viewItemGrid.Anchor = AnchorStyles.Right;
            pnl_viewItemGrid.Visible = true;

            dataGrid_Item.DataSource = new ItemBuss().GetSearchItem();
        }

        private void RefreshGrid()
        {
            foreach (DataGridViewRow row in dataGrid_Item.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }


        private void txtVieItemSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVieItemSearch.Text))
            {
                RefreshGrid();
                return;
            }

            // Code to search the  alphanumneric Part Number (in Column1 header called "PART NUMBER") and highlihgt the row
            foreach (DataGridViewRow row in dataGrid_Item.Rows)
            {
                //var cellValue = row.Cells["ItemBrandName"].Value;
                if (txtVieItemSearch.Text.Length < 3 && row.Cells["ItemBrandName"].Value.ToString().ToLower().Contains(txtVieItemSearch.Text.ToLower()))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells["ItemBrandName"].Value.ToString().ToLower().Equals(txtVieItemSearch.Text.ToLower()))
                    row.DefaultCellStyle.BackColor = Color.Yellow;

            }
        }
    }
}
