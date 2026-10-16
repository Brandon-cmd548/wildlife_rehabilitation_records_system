namespace BRAnimalRehabSystem.PresentationLayer
{
    partial class Search
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
            label1 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            btnExit = new Button();
            dgvSearch = new DataGridView();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(279, 21);
            label1.TabIndex = 0;
            label1.Text = "Please enter the ID being searched for: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 144);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "ID: ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(145, 364);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(409, 364);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 38);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(25, 250);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.Size = new Size(727, 68);
            dgvSearch.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(158, 141);
            txtID.Name = "txtID";
            txtID.Size = new Size(142, 23);
            txtID.TabIndex = 5;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(dgvSearch);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearch;
        private Button btnExit;
        private DataGridView dgvSearch;
        private TextBox txtID;
    }
}