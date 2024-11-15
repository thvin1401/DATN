using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class frmAccountManagement : Form
    {
        private List<string> listSelectedUsername = new List<string>();
        public frmAccountManagement()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            cmbtype.Items.Add("Owner");
            cmbtype.Items.Add("Manager");

            cmbtype.SelectedIndex = 0;

            cmbactivation.Items.Add("Inactive");
            cmbactivation.Items.Add("Active");

            cmbactivation.SelectedIndex = 0;

            btndeactive.Enabled = false;

            btnactivate.Enabled = false;

            btnedit.Enabled = false;

            initDatagridview();

            cmbtype.SelectedIndexChanged += cmbtype_SelectedIndexChanged;
            cmbactivation.SelectedIndexChanged += cmbactivation_SelectedIndexChanged;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            initDatagridview();
        }

        private void initDatagridview()
        {
            // init grdheader
            grdheader.Rows.Clear();

            grdheader.RowCount = 1;
            grdheader.ColumnCount = 9;

            grdheader.RowTemplate.Height = 30;
            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Username";
            grdheader[2, 0].Value = "Name";
            grdheader[3, 0].Value = "Phone";
            grdheader[4, 0].Value = "Email";
            grdheader[5, 0].Value = "Status";
            grdheader[6, 0].Value = "Account Type";
            grdheader[7, 0].Value = "Create Time";
            grdheader[8, 0].Value = "";

            grdheader.Columns[0].Width = 50;
            grdheader.Columns[1].Width = 200;
            grdheader.Columns[2].Width = 250;
            grdheader.Columns[3].Width = 150;
            grdheader.Columns[4].Width = 150;
            grdheader.Columns[5].Width = 100;
            grdheader.Columns[6].Width = 100;
            grdheader.Columns[7].Width = 100;
            grdheader.Columns[8].Width = 83;

            grdheader.Height = 30;
            grdheader.ClearSelection();

            // get data
            var data = clsController.getAllAccountInfo(cmbtype.SelectedIndex, cmbactivation.SelectedIndex, txtsearch.Text.Trim());

            // init grddata
            grddata.Rows.Clear();

            grddata.RowCount = data.Count;
            grddata.ColumnCount = 8;

            grddata.RowTemplate.Height = 30;
            grddata.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grddata.Columns[0].Width = 50;
            grddata.Columns[1].Width = 200;
            grddata.Columns[2].Width = 250;
            grddata.Columns[3].Width = 150;
            grddata.Columns[4].Width = 150;
            grddata.Columns[5].Width = 100;
            grddata.Columns[6].Width = 100;
            grddata.Columns[7].Width = 100;

            for (int i = 0; i < data.Count; i++)
            {
                grddata[0, i].Value = i + 1;
                grddata[1, i].Value = data[i].username;
                grddata[2, i].Value = data[i].name;
                grddata[3, i].Value = data[i].phone;
                grddata[4, i].Value = data[i].email;
                grddata[5, i].Value = data[i].isenabled == true ? "Active" : "Inactice";
                grddata[6, i].Value = data[i].accounttype == 0 ? "Owner" : "Manager";
                grddata[7, i].Value = Convert.ToDateTime(data[i].createdatetime).ToString("yyyy/MM/dd");
            }

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "ckbcolumn",
                Width = 83
            };

            grddata.Columns.Add(checkBoxColumn);

            grddata.Height = 480;
            grddata.ClearSelection();
        }

        private void cmbtype_SelectedIndexChanged(object? sender, EventArgs e)
        {
            initDatagridview();
        }

        private void cmbactivation_SelectedIndexChanged(object? sender, EventArgs e)
        {
            initDatagridview();
        }

        private void grddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grddata.Columns["ckbcolumn"].Index && e.RowIndex >= 0)
            {
                // Toggle checkbox value
                bool isChecked = Convert.ToBoolean(grddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                grddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;

                if (!isChecked)
                {
                    listSelectedUsername.Add(grddata.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                {
                    listSelectedUsername.Remove(grddata.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }

            btnactivate.Enabled = false;

            btndeactive.Enabled = false;

            btnedit.Enabled = false;

            if (listSelectedUsername.Count > 0)
            {
                btndeactive.Enabled = true;

                btnactivate.Enabled = true;
            }
            if(listSelectedUsername.Count == 1)
            {
                btnedit.Enabled = true;
            }
        }

        private void btndeactive_Click(object sender, EventArgs e)
        {
            if (clsController.deactiveOrActivateAccount(listSelectedUsername, false))
            {
                mdlMain.updateMDIMainMessage("Deactivated successfully!", Color.LimeGreen);
            }
            else
            {
                mdlMain.updateMDIMainMessage("Deactivated failed!", Color.Red);
            }

            initDatagridview();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            frmCreateUpdateAccount frm = new frmCreateUpdateAccount();
            frm.isEdit = true;
            frm.username = listSelectedUsername.First();
            frm.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            frmCreateUpdateAccount frm = new frmCreateUpdateAccount();
            frm.isEdit = false;
            frm.Show();
            this.Hide();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (clsController.deactiveOrActivateAccount(listSelectedUsername, true))
            {
                mdlMain.updateMDIMainMessage("Activated successfully!", Color.LimeGreen);
            }
            else
            {
                mdlMain.updateMDIMainMessage("Activated failed!", Color.Red);
            }

            initDatagridview();
        }
    }
}
