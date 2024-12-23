using System.Windows.Forms;

namespace SalesManagement
{
    public partial class frmMainMenu : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        private bool isViewAllNote = false;

        private bool isEventAssigned = false;

        public frmMainMenu()
        {
            InitializeComponent();

            clockTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            var currentUser = mdlMain.App.currentUser;
            CreateCircularButton(currentUser.username);
            lblaccounttype.Text = currentUser.accounttype == 0 ? "Owner" : "Manager";

            dpkreminddateto.Value = dpkreminddateto.Value.AddDays(7);

            initGrdNote();

            dpkreminddatefrom.ValueChanged += dpkreminddatefrom_ValueChanged;
            dpkreminddateto.ValueChanged += dpkreminddateto_ValueChanged;
        }

        private void CreateCircularButton(string username)
        {
            CircularButton btnavatar = new CircularButton
            {
                Initial = username.Substring(0, 1).ToUpper(),
                Width = 50,
                Height = 50,
                Location = new Point(20, 18),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnavatar.FlatAppearance.BorderSize = 0;
            btnavatar.Cursor = Cursors.Hand;
            btnavatar.Click += new EventHandler(btnavatar_Click);

            panel2.Controls.Add(btnavatar);
        }

        private void initGrdNote()
        {
            grdnote.Rows.Clear();
            grdnote.Columns.Clear();

            if (!isEventAssigned)
            {
                grdnote.CellPainting += grdnote_CellPainting;
                grdnote.CellClick += grdnote_CellClick;

                isEventAssigned = true;
            }

            var data = clsController.getNotes(dpkreminddatefrom.Value, dpkreminddateto.Value, isViewAllNote);

            grdnote.RowCount = data.Count;
            grdnote.ColumnCount = 4;

            for (int i = 0; i < data.Count; i++)
            {
                grdnote[0, i].Value = data[i].id;
                grdnote[1, i].Value = i + 1;
                grdnote[2, i].Value = data[i].reminddatetime.ToString("dd/MM/yyyy");
                grdnote[3, i].Value = data[i].message;
            }

            DataGridViewButtonColumn btndone = new DataGridViewButtonColumn
            {
                Name = "btndone",
                Text = "O",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn btndelete = new DataGridViewButtonColumn
            {
                Name = "btndelete",
                Text = "X",
                UseColumnTextForButtonValue = true
            };

            grdnote.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (grdnote.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        grdnote.Cursor = Cursors.Hand;
                    }
                }
            };

            grdnote.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (grdnote.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        grdnote.Cursor = Cursors.Default;
                    }
                }
            };

            grdnote.Columns.Add(btndone);
            grdnote.Columns.Add(btndelete);

            grdnote.Columns[0].Visible = false;

            grdnote.Columns[1].Width = 36;
            grdnote.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdnote.Columns[2].Width = 70;
            grdnote.Columns[3].Width = 650;
            grdnote.Columns["btndone"].Width = 50;
            grdnote.Columns["btndelete"].Width = 50;

            grdnote.Height = 450;

            grdnote.ClearSelection();

            lblnotecount.Text = "" + data.Count + " reminder(s)";
            lblnotecount.ForeColor = Color.LimeGreen;

            if (data.Count == 0)
            {
                lblnotecount.ForeColor = Color.Red;
            }
        }

        private void initGrdNoteAll()
        {
            grdnote.Rows.Clear();
            grdnote.Columns.Clear();

            if (isEventAssigned)
            {
                grdnote.CellPainting -= grdnote_CellPainting;
                grdnote.CellClick -= grdnote_CellClick;

                isEventAssigned = false;
            }

            var data = clsController.getNotes(dpkreminddatefrom.Value, dpkreminddateto.Value, isViewAllNote);

            grdnote.RowCount = data.Count;
            grdnote.ColumnCount = 6;

            grdnote.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdnote.Columns[4].DefaultCellStyle.ForeColor = Color.LimeGreen;
            grdnote.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdnote.Columns[5].DefaultCellStyle.ForeColor = Color.Red;
            grdnote.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < data.Count; i++)
            {
                grdnote[0, i].Value = data[i].id;
                grdnote[1, i].Value = i + 1;
                grdnote[2, i].Value = data[i].reminddatetime.ToString("dd/MM/yyyy");
                grdnote[3, i].Value = data[i].message;
                grdnote[4, i].Value = data[i].isdone ? "Done" : "";
                grdnote[5, i].Value = data[i].isdeleted ? "Delete" : "";
            }

            grdnote.Columns[0].Visible = false;

            grdnote.Columns[1].Width = 36;
            grdnote.Columns[2].Width = 70;
            grdnote.Columns[3].Width = 650;
            grdnote.Columns[4].Width = 50;
            grdnote.Columns[5].Width = 50;

            grdnote.Height = 450;

            grdnote.ClearSelection();

            lblnotecount.Text = "" + data.Count + " reminder(s)";
            lblnotecount.ForeColor = Color.LimeGreen;

            if (data.Count == 0)
            {
                lblnotecount.ForeColor = Color.Red;
            }
        }

        private void btnavatar_Click(object? sender, EventArgs eventArgs)
        {
            frmCreateUpdateAccount frm = new frmCreateUpdateAccount();
            frm.isEdit = true;
            frm.username = mdlMain.App.currentUser.username;
            frm.isAvatarClick = true;
            frm.ShowDialog(this);
        }

        private void ClockTimer_Tick(object? sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy");
            lbltime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnproductmanagement_Click(object sender, EventArgs e)
        {
            frmProductManagement frm = new frmProductManagement();
            frm.Show();

            this.Hide();
        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.Show();

            this.Hide();
        }

        private void btndebtmanagement_Click(object sender, EventArgs e)
        {
            frmDebtManagement frm = new frmDebtManagement();
            frm.Show();

            this.Hide();
        }

        private void btnsearchbilljournal_Click(object sender, EventArgs e)
        {
            frmSearchBillJournal frm = new frmSearchBillJournal();
            frm.Show();

            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();

            this.Hide();
        }

        private void btnaccountmanagement_Click(object sender, EventArgs e)
        {
            frmAccountManagement frm = new frmAccountManagement();

            frm.Show();

            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmLogin.Show();

            this.Hide();
        }

        private void btngetallnote_Click(object sender, EventArgs e)
        {
            isViewAllNote = !isViewAllNote;

            if (isViewAllNote)
            {
                lblallnote.ForeColor = Color.LimeGreen;
                initGrdNoteAll();
            }
            else
            {
                lblallnote.ForeColor = SystemColors.ControlText;
                initGrdNote();
            }
        }

        private void dpkreminddateto_ValueChanged(object? sender, EventArgs e)
        {
            initGrdNote();
        }

        private void dpkreminddatefrom_ValueChanged(object? sender, EventArgs e)
        {
            initGrdNote();
        }

        private void grdnote_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
            (grdnote.Columns[e.ColumnIndex].Name == "btndone" || grdnote.Columns[e.ColumnIndex].Name == "btndelete") && e.RowIndex >= 0)
            {
                // Suppress the default cell painting
                e.Handled = true;

                // Paint the background
                e.PaintBackground(e.ClipBounds, true);

                Color textColor = (grdnote.Columns[e.ColumnIndex].Name == "btndone") ? Color.LimeGreen : Color.Red;

                // Draw the button without borders
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString(), // Get the button text
                    e.CellStyle.Font,
                    e.CellBounds,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void grdnote_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                // Get the name of the clicked column
                string columnName = grdnote.Columns[e.ColumnIndex].Name;
                string id = grdnote[0, e.RowIndex].Value.ToString();

                if (columnName == "btndone")
                {
                    if (clsController.markNoteDone(id))
                    {
                        mdlMain.updateMDIMainMessage("Note done!", Color.LimeGreen);
                        initGrdNote();
                        return;
                    }
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                }
                else if (columnName == "btndelete")
                {
                    if (clsController.markNoteDeleted(id))
                    {
                        mdlMain.updateMDIMainMessage("Note deleted!", Color.LimeGreen);
                        initGrdNote();
                        return;
                    }
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                }
            }
        }

        private void grdnote_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmCreateUpdateNotes frm = new frmCreateUpdateNotes();
                frm.isEdit = true;
                frm.noteId = grdnote.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.ShowDialog(this);

                isViewAllNote = false;
                initGrdNote();
            }
        }

        private void btnaddnotes_Click(object? sender, EventArgs e)
        {
            frmCreateUpdateNotes frm = new frmCreateUpdateNotes();
            frm.ShowDialog(this);

            isViewAllNote = false;
            initGrdNote();
        }

        private void btnadjustment_Click(object sender, EventArgs e)
        {
            frmAdjustment frm = new frmAdjustment();
            frm.Show();

            this.Hide();
        }
    }
}
