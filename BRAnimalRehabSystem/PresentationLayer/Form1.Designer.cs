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
            lblSeperate1 = new Label();
            lblAnimalID = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblRecoveryScore = new Label();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtRecoveryScore = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            lblSearchAnimalID = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            lblAnimalRecords = new Label();
            lblSeperate2 = new Label();
            dataGridView1 = new DataGridView();
            lblStatistics = new Label();
            lblSeperate3 = new Label();
            lblStatisticTotalAnimals = new Label();
            lblStatisticAverageAge = new Label();
            lblStatisticAverageRecoveryScore = new Label();
            outputStatisticTotalAnimals = new Label();
            outputStatisticAverageAge = new Label();
            outputStatisticAverageScore = new Label();
            btnGenerateSummary = new Button();
            outputAnimalID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // lblSeperate1
            // 
            lblSeperate1.AutoSize = true;
            lblSeperate1.Location = new Point(1, 44);
            lblSeperate1.Name = "lblSeperate1";
            lblSeperate1.Size = new Size(957, 20);
            lblSeperate1.TabIndex = 1;
            lblSeperate1.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(12, 64);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(78, 20);
            lblAnimalID.TabIndex = 2;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(12, 128);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 162);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(12, 198);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(113, 20);
            lblRecoveryScore.TabIndex = 6;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(169, 125);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(125, 27);
            txtSpecies.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(169, 159);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 10;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(169, 195);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(125, 27);
            txtRecoveryScore.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(683, 61);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(127, 20);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search for Animal";
            // 
            // lblSearchAnimalID
            // 
            lblSearchAnimalID.AutoSize = true;
            lblSearchAnimalID.Location = new Point(599, 96);
            lblSearchAnimalID.Name = "lblSearchAnimalID";
            lblSearchAnimalID.Size = new Size(78, 20);
            lblSearchAnimalID.TabIndex = 16;
            lblSearchAnimalID.Text = "Animal ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(683, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(816, 91);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblAnimalRecords
            // 
            lblAnimalRecords.AutoSize = true;
            lblAnimalRecords.Font = new Font("Segoe UI", 15F);
            lblAnimalRecords.Location = new Point(384, 288);
            lblAnimalRecords.Name = "lblAnimalRecords";
            lblAnimalRecords.Size = new Size(188, 35);
            lblAnimalRecords.TabIndex = 19;
            lblAnimalRecords.Text = "Animal Records";
            // 
            // lblSeperate2
            // 
            lblSeperate2.AutoSize = true;
            lblSeperate2.Location = new Point(1, 323);
            lblSeperate2.Name = "lblSeperate2";
            lblSeperate2.Size = new Size(957, 20);
            lblSeperate2.TabIndex = 20;
            lblSeperate2.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(570, 191);
            dataGridView1.TabIndex = 21;
            // 
            // lblStatistics
            // 
            lblStatistics.AutoSize = true;
            lblStatistics.Font = new Font("Segoe UI", 15F);
            lblStatistics.Location = new Point(419, 549);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(110, 35);
            lblStatistics.TabIndex = 22;
            lblStatistics.Text = "Statistics";
            // 
            // lblSeperate3
            // 
            lblSeperate3.AutoSize = true;
            lblSeperate3.Location = new Point(1, 584);
            lblSeperate3.Name = "lblSeperate3";
            lblSeperate3.Size = new Size(957, 20);
            lblSeperate3.TabIndex = 23;
            lblSeperate3.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------";

            // 
            // lblStatisticTotalAnimals
            // 
            lblStatisticTotalAnimals.AutoSize = true;
            lblStatisticTotalAnimals.Location = new Point(12, 617);
            lblStatisticTotalAnimals.Name = "lblStatisticTotalAnimals";
            lblStatisticTotalAnimals.Size = new Size(102, 20);
            lblStatisticTotalAnimals.TabIndex = 24;
            lblStatisticTotalAnimals.Text = "Total Animals:";
            // 
            // lblStatisticAverageAge
            // 
            lblStatisticAverageAge.AutoSize = true;
            lblStatisticAverageAge.Location = new Point(14, 664);
            lblStatisticAverageAge.Name = "lblStatisticAverageAge";
            lblStatisticAverageAge.Size = new Size(98, 20);
            lblStatisticAverageAge.TabIndex = 25;
            lblStatisticAverageAge.Text = "Average Age:";
            // 
            // lblStatisticAverageRecoveryScore
            // 
            lblStatisticAverageRecoveryScore.AutoSize = true;
            lblStatisticAverageRecoveryScore.Location = new Point(14, 710);
            lblStatisticAverageRecoveryScore.Name = "lblStatisticAverageRecoveryScore";
            lblStatisticAverageRecoveryScore.Size = new Size(172, 20);
            lblStatisticAverageRecoveryScore.TabIndex = 26;
            lblStatisticAverageRecoveryScore.Text = "Average Recovery Score:";
            // 
            // outputStatisticTotalAnimals
            // 
            outputStatisticTotalAnimals.AutoSize = true;
            outputStatisticTotalAnimals.Location = new Point(232, 617);
            outputStatisticTotalAnimals.Name = "outputStatisticTotalAnimals";
            outputStatisticTotalAnimals.Size = new Size(17, 20);
            outputStatisticTotalAnimals.TabIndex = 27;
            outputStatisticTotalAnimals.Text = "0";
            // 
            // outputStatisticAverageAge
            // 
            outputStatisticAverageAge.AutoSize = true;
            outputStatisticAverageAge.Location = new Point(232, 664);
            outputStatisticAverageAge.Name = "outputStatisticAverageAge";
            outputStatisticAverageAge.Size = new Size(17, 20);
            outputStatisticAverageAge.TabIndex = 28;
            outputStatisticAverageAge.Text = "0";
            // 
            // outputStatisticAverageScore
            // 
            outputStatisticAverageScore.AutoSize = true;
            outputStatisticAverageScore.Location = new Point(232, 710);
            outputStatisticAverageScore.Name = "outputStatisticAverageScore";
            outputStatisticAverageScore.Size = new Size(17, 20);
            outputStatisticAverageScore.TabIndex = 29;
            outputStatisticAverageScore.Text = "0";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(14, 742);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(235, 29);
            btnGenerateSummary.TabIndex = 30;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            // 
            // outputAnimalID
            // 
            outputAnimalID.AutoSize = true;
            outputAnimalID.Location = new Point(169, 64);
            outputAnimalID.Name = "outputAnimalID";
            outputAnimalID.Size = new Size(150, 20);
            outputAnimalID.TabIndex = 31;
            outputAnimalID.Text = "{ID will Appear Here}";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 783);
            Controls.Add(outputAnimalID);
            Controls.Add(btnGenerateSummary);
            Controls.Add(outputStatisticAverageScore);
            Controls.Add(outputStatisticAverageAge);
            Controls.Add(outputStatisticTotalAnimals);
            Controls.Add(lblStatisticAverageRecoveryScore);
            Controls.Add(lblStatisticAverageAge);
            Controls.Add(lblStatisticTotalAnimals);
            Controls.Add(lblSeperate3);
            Controls.Add(lblStatistics);
            Controls.Add(dataGridView1);
            Controls.Add(lblSeperate2);
            Controls.Add(lblAnimalRecords);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(lblSearchAnimalID);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblAge);
            Controls.Add(lblSpecies);
            Controls.Add(lblName);
            Controls.Add(lblAnimalID);
            Controls.Add(lblSeperate1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSeperate1;
        private Label lblAnimalID;
        private Label lblName;
        private Label lblSpecies;
        private Label lblAge;
        private Label lblRecoveryScore;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtRecoveryScore;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private Label lblSearchAnimalID;
        private TextBox textBox1;
        private Button btnSearch;
        private Label lblAnimalRecords;
        private Label lblSeperate2;
        private DataGridView dataGridView1;
        private Label lblStatistics;
        private Label lblSeperate3;
        private Label lblStatisticTotalAnimals;
        private Label lblStatisticAverageAge;
        private Label lblStatisticAverageRecoveryScore;
        private Label outputStatisticTotalAnimals;
        private Label outputStatisticAverageAge;
        private Label outputStatisticAverageScore;
        private Button btnGenerateSummary;
        private Label outputAnimalID;
    }

}
