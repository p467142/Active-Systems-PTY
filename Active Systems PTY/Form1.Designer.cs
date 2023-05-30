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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
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
    }
}