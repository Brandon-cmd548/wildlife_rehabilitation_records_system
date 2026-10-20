namespace BRAnimalRehabSystem.PresentationLayer
{
    partial class MainForm
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
            btnAddAnimal = new Button();
            label3 = new Label();
            btnUpdateAnimal = new Button();
            btnSearchAnimal = new Button();
            btnDeleteAnimal = new Button();
            btnStatistics = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(731, 34);
            label1.TabIndex = 0;
            label1.Text = "Baobab Ridge Wildlife Rehabilitation Records System ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-10, 43);
            label2.Name = "label2";
            label2.Size = new Size(813, 20);
            label2.TabIndex = 1;
            label2.Text = "--------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(12, 120);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(134, 83);
            btnAddAnimal.TabIndex = 2;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 63);
            label3.Name = "label3";
            label3.Size = new Size(273, 28);
            label3.TabIndex = 3;
            label3.Text = "What would you like to do?";
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.Location = new Point(169, 120);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(134, 83);
            btnUpdateAnimal.TabIndex = 4;
            btnUpdateAnimal.Text = "Update Animal";
            btnUpdateAnimal.UseVisualStyleBackColor = true;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // btnSearchAnimal
            // 
            btnSearchAnimal.Location = new Point(333, 120);
            btnSearchAnimal.Name = "btnSearchAnimal";
            btnSearchAnimal.Size = new Size(134, 83);
            btnSearchAnimal.TabIndex = 5;
            btnSearchAnimal.Text = "Search Animal";
            btnSearchAnimal.UseVisualStyleBackColor = true;
            btnSearchAnimal.Click += btnSearchAnimal_Click;
            // 
            // btnDeleteAnimal
            // 
            btnDeleteAnimal.Location = new Point(497, 120);
            btnDeleteAnimal.Name = "btnDeleteAnimal";
            btnDeleteAnimal.Size = new Size(134, 83);
            btnDeleteAnimal.TabIndex = 6;
            btnDeleteAnimal.Text = "Delete Animal";
            btnDeleteAnimal.UseVisualStyleBackColor = true;
            btnDeleteAnimal.Click += btnDeleteAnimal_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(654, 120);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(134, 83);
            btnStatistics.TabIndex = 7;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 230);
            Controls.Add(btnStatistics);
            Controls.Add(btnDeleteAnimal);
            Controls.Add(btnSearchAnimal);
            Controls.Add(btnUpdateAnimal);
            Controls.Add(label3);
            Controls.Add(btnAddAnimal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAddAnimal;
        private Label label3;
        private Button btnUpdateAnimal;
        private Button btnSearchAnimal;
        private Button btnDeleteAnimal;
        private Button btnStatistics;
    }
}