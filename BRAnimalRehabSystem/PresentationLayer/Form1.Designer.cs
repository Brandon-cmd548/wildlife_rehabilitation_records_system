namespace BRAnimalRehabSystem
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
            lblTitle = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            lblSearchAnimalID = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            btnStatistics = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(169, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 80);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 84);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(145, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 84);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update Animal";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(272, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 84);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(673, 77);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(127, 20);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search for Animal";
            // 
            // lblSearchAnimalID
            // 
            lblSearchAnimalID.AutoSize = true;
            lblSearchAnimalID.Location = new Point(589, 112);
            lblSearchAnimalID.Name = "lblSearchAnimalID";
            lblSearchAnimalID.Size = new Size(78, 20);
            lblSearchAnimalID.TabIndex = 16;
            lblSearchAnimalID.Text = "Animal ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(673, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(806, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(399, 80);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(121, 84);
            btnStatistics.TabIndex = 22;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-7, 44);
            label1.Name = "label1";
            label1.Size = new Size(957, 20);
            label1.TabIndex = 23;
            label1.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 192);
            Controls.Add(label1);
            Controls.Add(btnStatistics);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(lblSearchAnimalID);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private Label lblSearchAnimalID;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnStatistics;
        private Label label1;
    }

}
