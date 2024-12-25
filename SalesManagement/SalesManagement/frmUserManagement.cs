using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class frmUserManagement : Form
    {

        private List<string> listSelectedUserID;

        public frmUserManagement()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            listSelectedUserID = new List<string>();

            btnactivate.Enabled = false;

            btndeactivate.Enabled = false;

            cmbstatus.Items.Clear();

            cmbstatus.Items.Add("Inactive");
            cmbstatus.Items.Add("Active");

            cmbstatus.SelectedIndex = 1;

            dpkbirthdayfrom.Value = DateTime.Now.AddYears(1968 - DateTime.Now.Year);

            initGrdHeader();

            initGrdData();
        }

        private void initGrdHeader()
        {
            grdheader.Rows.Clear();

            grdheader.RowCount = 1;
            grdheader.ColumnCount = 14;

            grdheader.Columns[0].Width = 48;
            grdheader.Columns[1].Width = 200;
            grdheader.Columns[2].Width = 100;
            grdheader.Columns[3].Width = 70;
            grdheader.Columns[4].Width = 100;
            grdheader.Columns[5].Width = 80;
            grdheader.Columns[6].Width = 100;
            grdheader.Columns[7].Width = 100;
            grdheader.Columns[8].Width = 100;
            grdheader.Columns[9].Width = 60;
            grdheader.Columns[10].Width = 50;
            grdheader.Columns[11].Width = 60;
            grdheader.Columns[12].Width = 80;
            grdheader.Columns[13].Width = 50;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Full name";
            grdheader[2, 0].Value = "Address";
            grdheader[3, 0].Value = "Phone";
            grdheader[4, 0].Value = "Email";
            grdheader[5, 0].Value = "Birthday";
            grdheader[6, 0].Value = "Total purchase";
            grdheader[7, 0].Value = "Total debt";
            grdheader[8, 0].Value = "Total lend";
            grdheader[9, 0].Value = "Point";
            grdheader[10, 0].Value = "Rank";
            grdheader[11, 0].Value = "Status";
            grdheader[12, 0].Value = "Type";
            grdheader[13, 0].Value = "";

            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void initGrdData()
        {
            var name = string.IsNullOrEmpty(txtname.Text) ? null : txtname.Text.Trim();
            var address = string.IsNullOrEmpty(txtaddress.Text) ? null : txtaddress.Text.Trim();
            var phone = string.IsNullOrEmpty(txtphone.Text) ? null : txtphone.Text.Trim();

            var data = clsController.getListUserInfoByFullCondition(dpkbirthdayfrom.Value, dpkbirthdayto.Value, cmbstatus.SelectedIndex, name, address, phone);

            grddata.Rows.Clear();

            if (data.Count > 0)
            {
                grddata.ColumnCount = 14;
                grddata.RowCount = data.Count;

                for (int i = 0; i < grddata.RowCount; i++)
                {
                    grddata[0, i].Value = data[i].id;
                    grddata[1, i].Value = i + 1;
                    grddata[2, i].Value = data[i].name;
                    grddata[3, i].Value = data[i].address;
                    grddata[4, i].Value = data[i].phone;
                    grddata[5, i].Value = data[i].email;
                    grddata[6, i].Value = data[i].birthday.ToString("dd/MM/yyyy");
                    grddata[7, i].Value = data[i].totalpurchase.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[8, i].Value = data[i].totaldebt.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[9, i].Value = data[i].totallend.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[10, i].Value = data[i].point.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[11, i].Value = data[i].rank;
                    grddata[12, i].Value = data[i].isactive;
                    grddata[13, i].Value = data[i].type;
                }

                grddata.Columns[0].Visible = false;

                grddata.Columns[1].Width = 48;
                grddata.Columns[2].Width = 200;
                grddata.Columns[3].Width = 100;
                grddata.Columns[4].Width = 70;
                grddata.Columns[5].Width = 100;
                grddata.Columns[6].Width = 80;
                grddata.Columns[7].Width = 100;
                grddata.Columns[8].Width = 100;
                grddata.Columns[9].Width = 100;
                grddata.Columns[10].Width = 60;
                grddata.Columns[11].Width = 50;
                grddata.Columns[12].Width = 60;
                grddata.Columns[13].Width = 80;

                grddata.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grddata.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grddata.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grddata.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grddata.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grddata.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grddata.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grddata.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grddata.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grddata.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grddata.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grddata.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grddata.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "ckbcolumn",
                    Width = 50
                };

                grddata.Columns.Add(checkBoxColumn);
            }
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
                    listSelectedUserID.Add(grddata[0, e.RowIndex].Value.ToString());
                }
                else
                {
                    listSelectedUserID.Remove(grddata[0, e.RowIndex].Value.ToString());
                }

                if (listSelectedUserID.Count >= 1)
                {
                    btnactivate.Enabled = true;
                    btndeactivate.Enabled = true;
                }
                else
                {
                    btnactivate.Enabled = false;
                    btndeactivate.Enabled = false;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmCreateUpdateUserinfo frm = new frmCreateUpdateUserinfo();
            frm.ShowDialog(this);

            initGrdData();
        }

        private void btndeactivate_Click(object sender, EventArgs e)
        {
            if (clsController.deactiveOrActivateUser(listSelectedUserID, false))
            {
                mdlMain.updateMDIMainMessage("Deactivated successfully!", Color.LimeGreen);
            }
            else
            {
                mdlMain.updateMDIMainMessage("Deactivated failed!", Color.Red);
            }

            initGrdData();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (clsController.deactiveOrActivateUser(listSelectedUserID, true))
            {
                mdlMain.updateMDIMainMessage("Activated successfully!", Color.LimeGreen);
            }
            else
            {
                mdlMain.updateMDIMainMessage("Activated failed!", Color.Red);
            }

            initGrdData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            initGrdData();
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void grddata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = grddata[0, e.RowIndex].Value.ToString();

                frmCreateUpdateUserinfo frm = new frmCreateUpdateUserinfo();
                frm.isEdit = true;
                frm.userId = id;
                frm.ShowDialog(this);

                initGrdData();
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            initGrdData();
        }

        private void dpkbirthdayto_ValueChanged(object sender, EventArgs e)
        {
            initGrdData();
        }

        private void dpkbirthdayfrom_ValueChanged(object sender, EventArgs e)
        {
            initGrdData();
        }
    }
}
