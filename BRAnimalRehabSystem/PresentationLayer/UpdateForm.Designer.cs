namespace BRAnimalRehabSystem.PresentationLayer
{
    partial class UpdateForm
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
            txtRecoveryScore = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnFill = new Button();
            btnExit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            txtAge = new TextBox();
            txtAnimal = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(405, 253);
            txtRecoveryScore.Margin = new Padding(5, 4, 5, 4);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(132, 27);
            txtRecoveryScore.TabIndex = 14;
            txtRecoveryScore.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 259);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 7;
            label5.Text = "Recovery Score";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 219);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            label4.Visible = false;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(162, 403);
            btnFill.Margin = new Padding(5, 4, 5, 4);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(129, 49);
            btnFill.TabIndex = 5;
            btnFill.Text = "Fill Information";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(489, 403);
            btnExit.Margin = new Padding(5, 4, 5, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 179);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Animal";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 139);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 99);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(321, 403);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 49);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRecoveryScore);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtAnimal);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnFill);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(885, 568);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(405, 213);
            txtAge.Margin = new Padding(5, 4, 5, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(132, 27);
            txtAge.TabIndex = 13;
            txtAge.Visible = false;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(405, 173);
            txtAnimal.Margin = new Padding(5, 4, 5, 4);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(132, 27);
            txtAnimal.TabIndex = 12;
            txtAnimal.Visible = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(405, 133);
            txtName.Margin = new Padding(5, 4, 5, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 27);
            txtName.TabIndex = 11;
            txtName.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(405, 93);
            txtID.Margin = new Padding(5, 4, 5, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(132, 27);
            txtID.TabIndex = 10;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateForm";
            Text = "UpdateForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtRecoveryScore;
        private Label label5;
        private Label label4;
        private Button btnFill;
        private Button btnExit;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private TextBox txtAge;
        private TextBox txtAnimal;
        private TextBox txtName;
        private TextBox txtID;
    }
}
