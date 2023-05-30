using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Active_Systems_PTY
{
    public partial class DeleteRegoDialog : Form
    {

        public DeleteRegoDialog()
        {
            InitializeComponent();
            AcceptButton = BtnDeleteRegoDialogOK;
            CancelButton = BtnDeleteRegoDialogCancel;
        }
        public void setDeleteRegoList(IEnumerable regos)
        {
            foreach (ListViewItem rego in regos)
            { listDeleteRegos.Items.Add(rego.Text); }
        }

        private void BtnDeleteRegoDialogOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
