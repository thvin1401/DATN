using SalesManagement.model;

namespace SalesManagement
{
    public partial class frmCreateUpdateNotes : Form
    {
        public bool isEdit = false;

        public string noteId = string.Empty;

        public frmCreateUpdateNotes()
        {
            InitializeComponent();

            cmbisdone.Items.Clear();
            cmbisdeleted.Items.Clear();

            cmbisdone.Items.Add("");
            cmbisdone.Items.Add("Done");

            cmbisdeleted.Items.Add("");
            cmbisdeleted.Items.Add("Delete");

            cmbisdone.SelectedIndex = 0;
            cmbisdeleted.SelectedIndex = 0;
        }

        private void FrmCreateUpdateNotes_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var data = clsController.getNoteEdit(noteId);

                if (data is null)
                {
                    mdlMain.updateMDIMainMessage("No note to show", Color.Red);

                    clearForm();

                    this.Close();
                }
                else
                {
                    dpkreminddatetime.Value = data.reminddatetime;
                    cmbisdone.SelectedIndex = data.isdone ? 1 : 0;
                    cmbisdeleted.SelectedIndex = data.isdeleted ? 1 : 0;
                    txtmessage.Text = data.message;
                }

                lbltitle.Text = "Note update screen";
            }
            else
            {
                lbltitle.Text = "Note creation screen";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var creationTime = DateTime.Now;

            if (string.IsNullOrEmpty(txtmessage.Text))
            {
                mdlMain.updateMDIMainMessage("Please enter message", Color.Red);
                return;
            }

            mdlNote note = new mdlNote();
            note.reminddatetime = dpkreminddatetime.Value;
            note.message = txtmessage.Text;
            note.isdone = cmbisdone.SelectedIndex == 1;
            note.isdeleted = cmbisdeleted.SelectedIndex == 1;
            note.createdatetime = creationTime;
            note.updatedatetime = creationTime;

            if (isEdit)
            {
                note.id = Guid.Parse(noteId);

                if (clsController.updateNote(note))
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageUpdateSuccessfully, Color.LimeGreen);
                }
                else
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                }
            }
            else
            {
                if (clsController.createNote(note))
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageCreateSuccessfully, Color.LimeGreen);
                }
                else
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                }
            }

            clearForm();

            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            clearForm();

            this.Close();
        }

        private void clearForm()
        {
            cmbisdone.Items.Clear();
            cmbisdeleted.Items.Clear();
            dpkreminddatetime.Value = DateTime.Now;
            txtmessage.Clear();
        }

        private void cmbisdone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbisdone.SelectedIndex == 1)
            {
                cmbisdeleted.Enabled = false;
            }
            else
            {
                cmbisdeleted.Enabled = true;
            }
        }

        private void cmbisdeleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbisdeleted.SelectedIndex == 1)
            {
                cmbisdone.Enabled = false;
            }
            else
            {
                cmbisdone.Enabled = true;
            }
        }
    }
}
