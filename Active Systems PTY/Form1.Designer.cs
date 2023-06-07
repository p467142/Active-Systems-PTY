namespace Active_Systems_PTY
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listRegos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            labelRegoControls = new Label();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            txtAdd = new TextBox();
            btnReset = new Button();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            radioBtnSearchBinary = new RadioButton();
            radioBtnSearchLinear = new RadioButton();
            groupBoxSearchType = new GroupBox();
            txtSearch = new TextBox();
            labelSearch = new Label();
            txtOutput = new TextBox();
            groupBoxSearchType.SuspendLayout();
            SuspendLayout();
            // 
            // listRegos
            // 
            listRegos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listRegos.Location = new Point(214, 12);
            listRegos.Name = "listRegos";
            listRegos.Size = new Size(331, 426);
            listRegos.TabIndex = 0;
            listRegos.UseCompatibleStateImageBehavior = false;
            listRegos.View = View.Details;
            listRegos.SelectedIndexChanged += listRegos_SelectedIndexChanged;
            listRegos.Click += listRegos_Click;
            listRegos.DoubleClick += listRegos_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Rego";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tag";
            columnHeader2.Width = 35;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(12, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(112, 44);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(112, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // labelRegoControls
            // 
            labelRegoControls.AutoSize = true;
            labelRegoControls.Location = new Point(56, 12);
            labelRegoControls.Name = "labelRegoControls";
            labelRegoControls.Size = new Size(103, 20);
            labelRegoControls.TabIndex = 4;
            labelRegoControls.Text = "Rego Controls";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 374);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(12, 409);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(94, 29);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(12, 46);
            txtAdd.Name = "txtAdd";
            txtAdd.PlaceholderText = "Rego to Add";
            txtAdd.Size = new Size(94, 27);
            txtAdd.TabIndex = 7;
            txtAdd.TextChanged += txtAdd_TextChanged;
            txtAdd.KeyPress += txtAdd_KeyPress;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(112, 409);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // radioBtnSearchBinary
            // 
            radioBtnSearchBinary.AutoSize = true;
            radioBtnSearchBinary.Location = new Point(6, 26);
            radioBtnSearchBinary.Name = "radioBtnSearchBinary";
            radioBtnSearchBinary.Size = new Size(71, 24);
            radioBtnSearchBinary.TabIndex = 10;
            radioBtnSearchBinary.TabStop = true;
            radioBtnSearchBinary.Text = "Binary";
            radioBtnSearchBinary.UseVisualStyleBackColor = true;
            radioBtnSearchBinary.CheckedChanged += radioBtnSearchBinary_CheckedChanged;
            // 
            // radioBtnSearchLinear
            // 
            radioBtnSearchLinear.AutoSize = true;
            radioBtnSearchLinear.Location = new Point(6, 56);
            radioBtnSearchLinear.Name = "radioBtnSearchLinear";
            radioBtnSearchLinear.Size = new Size(70, 24);
            radioBtnSearchLinear.TabIndex = 11;
            radioBtnSearchLinear.TabStop = true;
            radioBtnSearchLinear.Text = "Linear";
            radioBtnSearchLinear.UseVisualStyleBackColor = true;
            radioBtnSearchLinear.CheckedChanged += radioBtnSearchLinear_CheckedChanged;
            // 
            // groupBoxSearchType
            // 
            groupBoxSearchType.Controls.Add(radioBtnSearchLinear);
            groupBoxSearchType.Controls.Add(radioBtnSearchBinary);
            groupBoxSearchType.Location = new Point(12, 114);
            groupBoxSearchType.Name = "groupBoxSearchType";
            groupBoxSearchType.Size = new Size(115, 87);
            groupBoxSearchType.TabIndex = 12;
            groupBoxSearchType.TabStop = false;
            groupBoxSearchType.Text = "Search Type";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 207);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(115, 27);
            txtSearch.TabIndex = 12;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(133, 210);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(53, 20);
            labelSearch.TabIndex = 13;
            labelSearch.Text = "Search";
            // 
            // txtOutput
            // 
            txtOutput.Enabled = false;
            txtOutput.Location = new Point(12, 341);
            txtOutput.Name = "txtOutput";
            txtOutput.PlaceholderText = "Output...";
            txtOutput.Size = new Size(193, 27);
            txtOutput.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(txtOutput);
            Controls.Add(labelSearch);
            Controls.Add(txtSearch);
            Controls.Add(groupBoxSearchType);
            Controls.Add(btnReset);
            Controls.Add(txtAdd);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(labelRegoControls);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(listRegos);
            Name = "Form1";
            Text = "Active Systems PTY";
            Load += Form1_Load;
            groupBoxSearchType.ResumeLayout(false);
            groupBoxSearchType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listRegos;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label labelRegoControls;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private TextBox txtAdd;
        private Button btnReset;
        private ColorDialog colorDialog1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioBtnSearchBinary;
        private RadioButton radioBtnSearchLinear;
        private GroupBox groupBoxSearchType;
        private TextBox txtSearch;
        private Label labelSearch;
        private TextBox txtOutput;
    }
}