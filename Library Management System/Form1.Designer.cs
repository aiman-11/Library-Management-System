namespace Library_Management_System
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
            label1 = new Label();
            BooksTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)BooksTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 23);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // BooksTable
            // 
            BooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksTable.Location = new Point(12, 74);
            BooksTable.Name = "BooksTable";
            BooksTable.Size = new Size(601, 321);
            BooksTable.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 407);
            Controls.Add(BooksTable);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Library Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BooksTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView BooksTable;
    }
}
