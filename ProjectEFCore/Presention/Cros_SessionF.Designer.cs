namespace ProjectEFCore.Presention
{
    partial class Cros_SessionF
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
            Id = new TextBox();
            Ins_Id = new TextBox();
            Date = new TextBox();
            Title = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dataGrid = new DataGridView();
            Crs_Id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // Id
            // 
            Id.BackColor = SystemColors.ActiveCaption;
            Id.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id.ForeColor = Color.Navy;
            Id.Location = new Point(755, 49);
            Id.Margin = new Padding(3, 4, 3, 4);
            Id.Multiline = true;
            Id.Name = "Id";
            Id.PlaceholderText = "Id";
            Id.Size = new Size(277, 48);
            Id.TabIndex = 40;
            // 
            // Ins_Id
            // 
            Ins_Id.BackColor = SystemColors.ActiveCaption;
            Ins_Id.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ins_Id.ForeColor = Color.Navy;
            Ins_Id.Location = new Point(755, 344);
            Ins_Id.Margin = new Padding(3, 2, 3, 2);
            Ins_Id.Multiline = true;
            Ins_Id.Name = "Ins_Id";
            Ins_Id.PlaceholderText = "Ins_Id";
            Ins_Id.Size = new Size(277, 48);
            Ins_Id.TabIndex = 39;
            // 
            // Date
            // 
            Date.BackColor = SystemColors.ActiveCaption;
            Date.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.ForeColor = Color.Navy;
            Date.Location = new Point(755, 233);
            Date.Margin = new Padding(3, 2, 3, 2);
            Date.Multiline = true;
            Date.Name = "Date";
            Date.PlaceholderText = "Date ";
            Date.Size = new Size(277, 48);
            Date.TabIndex = 38;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.ActiveCaption;
            Title.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Navy;
            Title.Location = new Point(755, 135);
            Title.Margin = new Padding(3, 2, 3, 2);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.PlaceholderText = "Title";
            Title.Size = new Size(277, 48);
            Title.TabIndex = 37;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MidnightBlue;
            btnDelete.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(558, 565);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 50);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(318, 565);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 50);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.CornflowerBlue;
            btnInsert.Font = new Font("Mistral", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.Navy;
            btnInsert.Location = new Point(69, 565);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(149, 50);
            btnInsert.TabIndex = 34;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
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
            dataGrid.Location = new Point(46, 40);
            dataGrid.Margin = new Padding(3, 2, 3, 2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(685, 484);
            dataGrid.TabIndex = 33;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.RowHeaderMouseClick += dataGrid_RowHeaderMouseClick;
            // 
            // Crs_Id
            // 
            Crs_Id.BackColor = SystemColors.ActiveCaption;
            Crs_Id.Font = new Font("Microsoft Uighur", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crs_Id.ForeColor = Color.Navy;
            Crs_Id.Location = new Point(755, 441);
            Crs_Id.Margin = new Padding(3, 2, 3, 2);
            Crs_Id.Multiline = true;
            Crs_Id.Name = "Crs_Id";
            Crs_Id.PlaceholderText = "Crs_Id";
            Crs_Id.Size = new Size(277, 48);
            Crs_Id.TabIndex = 41;
            // 
            // Cros_SessionF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(Crs_Id);
            Controls.Add(Id);
            Controls.Add(Ins_Id);
            Controls.Add(Date);
            Controls.Add(Title);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cros_SessionF";
            Size = new Size(1063, 642);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Id;
        private TextBox Ins_Id;
        private TextBox Date;
        private TextBox Title;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dataGrid;
        private TextBox Crs_Id;
    }
}
