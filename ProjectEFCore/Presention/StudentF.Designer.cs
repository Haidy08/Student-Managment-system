namespace ProjectEFCore.Presention
{
    partial class StudentF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Phontxt = new TextBox();
            LNtxt = new TextBox();
            FNtxt = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            idtxt = new TextBox();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // Phontxt
            // 
            Phontxt.BackColor = SystemColors.ActiveCaption;
            Phontxt.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phontxt.ForeColor = Color.Navy;
            Phontxt.Location = new Point(772, 401);
            Phontxt.Margin = new Padding(3, 2, 3, 2);
            Phontxt.Multiline = true;
            Phontxt.Name = "Phontxt";
            Phontxt.PlaceholderText = "Phone";
            Phontxt.Size = new Size(277, 39);
            Phontxt.TabIndex = 31;
            // 
            // LNtxt
            // 
            LNtxt.BackColor = SystemColors.ActiveCaption;
            LNtxt.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNtxt.ForeColor = Color.Navy;
            LNtxt.Location = new Point(772, 295);
            LNtxt.Margin = new Padding(3, 2, 3, 2);
            LNtxt.Multiline = true;
            LNtxt.Name = "LNtxt";
            LNtxt.PlaceholderText = "LName";
            LNtxt.Size = new Size(277, 39);
            LNtxt.TabIndex = 30;
            // 
            // FNtxt
            // 
            FNtxt.BackColor = SystemColors.ActiveCaption;
            FNtxt.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNtxt.ForeColor = Color.Navy;
            FNtxt.Location = new Point(772, 181);
            FNtxt.Margin = new Padding(3, 2, 3, 2);
            FNtxt.Multiline = true;
            FNtxt.Name = "FNtxt";
            FNtxt.PlaceholderText = "FName";
            FNtxt.Size = new Size(277, 39);
            FNtxt.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MidnightBlue;
            btnDelete.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(542, 562);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(266, 562);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.CornflowerBlue;
            btnInsert.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.Navy;
            btnInsert.Location = new Point(21, 562);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(149, 40);
            btnInsert.TabIndex = 26;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // idtxt
            // 
            idtxt.BackColor = SystemColors.ActiveCaption;
            idtxt.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idtxt.ForeColor = Color.Navy;
            idtxt.Location = new Point(772, 78);
            idtxt.Multiline = true;
            idtxt.Name = "idtxt";
            idtxt.PlaceholderText = "St_Id";
            idtxt.Size = new Size(277, 39);
            idtxt.TabIndex = 32;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.GridColor = SystemColors.ActiveCaption;
            dataGrid.Location = new Point(21, 20);
            dataGrid.Margin = new Padding(3, 2, 3, 2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(685, 484);
            dataGrid.TabIndex = 25;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.RowHeaderMouseClick += dataGrid_RowHeaderMouseClick;
            // 
            // StudentF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(idtxt);
            Controls.Add(Phontxt);
            Controls.Add(LNtxt);
            Controls.Add(FNtxt);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentF";
            Size = new Size(1063, 642);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Phontxt;
        private TextBox LNtxt;
        private TextBox FNtxt;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox idtxt;
        private DataGridView dataGrid;
    }
}
