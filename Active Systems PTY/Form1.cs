using System.Security;
using System.Windows.Forms;

namespace Active_Systems_PTY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text.Length > 0)
            { btnAdd.Enabled = true; }
            else
            { btnAdd.Enabled = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRego();
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddRego();
            }
        }

        private void AddRego()
        {
            if (listRegos.Items.Count == 0 || listRegos.FindItemWithText(txtAdd.Text, true, 0, false) == null)
            {
                listRegos.Items.Add(txtAdd.Text);
                txtAdd.Text = null;
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // if data is already there, prompt to save, save and refresh before adding data, or add data without saving
            OpenFileDialog openDataFile = new OpenFileDialog();

            if (openDataFile.ShowDialog() == DialogResult.OK)
            {
                List<string> RegoList = File.ReadAllLines(openDataFile.FileName).ToList();

                foreach (string Rego in RegoList)
                {
                    if (listRegos.FindItemWithText(Rego) == null)
                    {
                        listRegos.Items.Add(Rego);
                    }
                }
            }
        }

        private void listRegos_DoubleClick(object sender, EventArgs e)
        {
            DeleteRegoDialog deleteRegos = new DeleteRegoDialog();

            deleteRegos.setDeleteRegoList(listRegos.SelectedItems);

            if (deleteRegos.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem Rego in listRegos.SelectedItems)
                {
                    listRegos.Items.Remove(Rego);
                }
            }
        }

        private void listRegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRegos.SelectedItems.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Rego in listRegos.SelectedItems)
            {
                listRegos.Items.Remove(Rego);
            }
            txtAdd.Text = "";
            txtAdd.Focus();
        }
    }
}