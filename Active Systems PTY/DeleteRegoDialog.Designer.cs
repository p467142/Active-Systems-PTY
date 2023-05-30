namespace Active_Systems_PTY
{
    partial class DeleteRegoDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelDeleteRegoDialog = new Label();
            BtnDeleteRegoDialogCancel = new Button();
            BtnDeleteRegoDialogOK = new Button();
            listDeleteRegos = new ListView();
            SuspendLayout();
            // 
            // LabelDeleteRegoDialog
            // 
            LabelDeleteRegoDialog.AutoSize = true;
            LabelDeleteRegoDialog.Location = new Point(12, 9);
            LabelDeleteRegoDialog.Name = "LabelDeleteRegoDialog";
            LabelDeleteRegoDialog.Size = new Size(108, 20);
            LabelDeleteRegoDialog.TabIndex = 0;
            LabelDeleteRegoDialog.Text = "Delete Rego(s)";
            // 
            // BtnDeleteRegoDialogCancel
            // 
            BtnDeleteRegoDialogCancel.Location = new Point(154, 200);
            BtnDeleteRegoDialogCancel.Name = "BtnDeleteRegoDialogCancel";
            BtnDeleteRegoDialogCancel.Size = new Size(94, 29);
            BtnDeleteRegoDialogCancel.TabIndex = 1;
            BtnDeleteRegoDialogCancel.Text = "Cancel";
            BtnDeleteRegoDialogCancel.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteRegoDialogOK
            // 
            BtnDeleteRegoDialogOK.Location = new Point(254, 200);
            BtnDeleteRegoDialogOK.Name = "BtnDeleteRegoDialogOK";
            BtnDeleteRegoDialogOK.Size = new Size(94, 29);
            BtnDeleteRegoDialogOK.TabIndex = 2;
            BtnDeleteRegoDialogOK.Text = "OK";
            BtnDeleteRegoDialogOK.UseVisualStyleBackColor = true;
            BtnDeleteRegoDialogOK.Click += BtnDeleteRegoDialogOK_Click;
            // 
            // listDeleteRegos
            // 
            listDeleteRegos.Location = new Point(12, 44);
            listDeleteRegos.Name = "listDeleteRegos";
            listDeleteRegos.Size = new Size(336, 150);
            listDeleteRegos.TabIndex = 3;
            listDeleteRegos.UseCompatibleStateImageBehavior = false;
            listDeleteRegos.View = View.List;
            // 
            // DeleteRegoDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 249);
            Controls.Add(listDeleteRegos);
            Controls.Add(BtnDeleteRegoDialogOK);
            Controls.Add(BtnDeleteRegoDialogCancel);
            Controls.Add(LabelDeleteRegoDialog);
            Name = "DeleteRegoDialog";
            Text = "DeleteRegoDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label LabelDeleteRegoDialog;
        private Button BtnDeleteRegoDialogCancel;
        private Button BtnDeleteRegoDialogOK;
        private ListView listDeleteRegos;
        private ColumnHeader Regos;
        private DataGridView dataGridView1;
    }
}