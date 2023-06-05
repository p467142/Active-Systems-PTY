namespace Active_Systems_PTY
{
    public partial class Form1 : Form
    {
        #region boilerplate
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBtnSearchBinary.Checked = true;
        }
        #endregion boilerplate

        private static List<string> Regos = new List<string>();
        private void refreshRegosView()
        {
            listRegos.Items.Clear();
            foreach (string rego in Regos)
            { listRegos.Items.Add(rego); }
            refreshRegoButtons();
        }
        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text.Length > 0)
            { btnAdd.Enabled = true; }
            else
            { btnAdd.Enabled = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e) { AddRego(); }

        private void btnEdit_Click(object sender, EventArgs e) { EditRego(); }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (btnEdit.Enabled)
                { EditRego(); }
                else
                { AddRego(); }
            }
        }

        private void AddRego()
        {
            if (AddRego(txtAdd.Text))
            { txtAdd.Text = null; }
        }
        private bool AddRego(string rego)
        {
            // return true if added, false if already there
            if (!Regos.Contains(rego))
            {
                Regos.Add(rego);
                Regos.Sort();
                refreshRegosView();
                return true;
            }
            else { return false; }
        }
        private void EditRego()
        {
            Regos[listRegos.SelectedItems[0].Index] = txtAdd.Text;
            txtAdd.Text = null;
            Regos.Sort();
            refreshRegosView();
            listRegos.SelectedItems.Clear();
        }
        private void RemoveRego(string rego)
        {
            Regos.Remove(rego);
            refreshRegosView();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //TODO: if data is already there, prompt to save, save and refresh before adding data, or add data without saving
            OpenFileDialog openDataFile = new OpenFileDialog();

            if (openDataFile.ShowDialog() == DialogResult.OK)
            {
                List<string> RegoList = File.ReadAllLines(openDataFile.FileName).ToList();

                foreach (string Rego in RegoList)
                {
                    AddRego(Rego);
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
                    RemoveRego(Rego.Text);
                }
            }
        }

        private void listRegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshRegoButtons();
        }

        private void refreshRegoButtons()
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

                txtAdd.Text = listRegos.SelectedItems[0].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Rego in listRegos.SelectedItems)
            {
                RemoveRego(Rego.Text);
            }
            txtAdd.Text = "";
            txtAdd.Focus();
        }

        private void listRegos_Click(object sender, EventArgs e)
        {
            btnEdit.Focus();
            txtAdd.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Regos.Clear();
            refreshRegosView();
        }

        private static bool SearchBinary = true; // binary btn is set in Form1_Load()
        private void radioBtnSearchBinary_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnSearchBinary.Checked) { SearchBinary = true; }
            else { SearchBinary = false; }
        }

        private void radioBtnSearchLinear_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnSearchLinear.Checked) { SearchBinary = false; }
            else { SearchBinary = true; }
        }

        public void RegoBinarySearch()
        {
            listRegos.SelectedItems.Clear();
            int i = Regos.BinarySearch(txtSearch.Text);
            if (i > 0)
            {
                listRegos.Items[i].Selected = true;
                txtOutput.Text = "Search found at index: " + i;
                txtAdd.Focus();
            } else { txtOutput.Text = "Search failed... returned " + i; }
        }

        public void RegoLinearSearch()
        {
            listRegos.SelectedItems.Clear();
            foreach (string Rego in Regos) // linear search loop
            {
                if (txtSearch.Text == Rego)
                {
                    int i = Regos.IndexOf(Rego);
                    listRegos.Items[i].Selected = true;
                    txtOutput.Text = "Search found at index: " + i;
                    txtAdd.Focus();
                    break;
                }
            }
            if (listRegos.SelectedItems == null) { txtOutput.Text = "Search failed..."; }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (radioBtnSearchBinary.Checked)
                { RegoBinarySearch(); }
                if (radioBtnSearchLinear.Checked)
                { RegoLinearSearch(); }
            }
        }
    }
}