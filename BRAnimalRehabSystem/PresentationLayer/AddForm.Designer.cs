namespace BRAnimalRehabSystem.PresentationLayer
{
    partial class AddForm
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtRecoveryScore = new TextBox();
            txtAge = new TextBox();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            btnAdd = new Button();
            lblRecoveryScore = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblName = new Label();
            lblAnimalID = new Label();
            btnAddBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-7, 43);
            label2.Name = "label2";
            label2.Size = new Size(813, 20);
            label2.TabIndex = 3;
            label2.Text = "--------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(460, 34);
            label1.TabIndex = 2;
            label1.Text = "Baobab Ridge Adding an Animal";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(375, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(409, 353);
            dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRecoveryScore);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtAnimalID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtSpecies);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblRecoveryScore);
            groupBox1.Controls.Add(lblAge);
            groupBox1.Controls.Add(lblSpecies);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblAnimalID);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 353);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Animal";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(139, 237);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(170, 27);
            txtRecoveryScore.TabIndex = 26;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(139, 187);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(170, 27);
            txtAge.TabIndex = 25;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(139, 31);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(170, 27);
            txtAnimalID.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 23;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(139, 132);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(170, 27);
            txtSpecies.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 289);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 59);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(6, 240);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(113, 20);
            lblRecoveryScore.TabIndex = 20;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(6, 190);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(90, 20);
            lblAge.TabIndex = 19;
            lblAge.Text = "Animal Age:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(6, 135);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(113, 20);
            lblSpecies.TabIndex = 18;
            lblSpecies.Text = "Animal Species:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(103, 20);
            lblName.TabIndex = 17;
            lblName.Text = "Animal Name:";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(6, 34);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(78, 20);
            lblAnimalID.TabIndex = 16;
            lblAnimalID.Text = "Animal ID:";
            // 
            // btnAddBack
            // 
            btnAddBack.Location = new Point(710, 9);
            btnAddBack.Name = "btnAddBack";
            btnAddBack.Size = new Size(78, 29);
            btnAddBack.TabIndex = 12;
            btnAddBack.Text = "Back";
            btnAddBack.UseVisualStyleBackColor = true;
            btnAddBack.Click += btnAddBack_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddBack);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            FormClosed += AddForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtRecoveryScore;
        private TextBox txtAge;
        private TextBox txtAnimalID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private Button btnAdd;
        private Label lblRecoveryScore;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblName;
        private Label lblAnimalID;
        private Button btnAddBack;
    }
}