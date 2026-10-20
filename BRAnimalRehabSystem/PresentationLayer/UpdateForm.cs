using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAnimalRehabSystem.ApplicationLogic;

namespace BRAnimalRehabSystem.PresentationLayer
{
    public partial class UpdateForm : Form
    {
        UpdateLogic logic = new UpdateLogic();
        Animal editAnimal = null;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            editAnimal = logic.FillData(txtID.Text);
            if (editAnimal != null)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtAge.Visible = true;
                txtAnimal.Visible = true;
                txtName.Visible = true;
                txtRecoveryScore.Visible = true;
                txtName.Text = editAnimal.AnimalName;
                txtAnimal.Text = editAnimal.AnimalSpecies;
                txtAge.Text = editAnimal.AnimalAge.ToString();
                txtRecoveryScore.Text = editAnimal.AnimalRecoveryScore.ToString();
            }
            else
            {
                MessageBox.Show("ID not found, please enter an ID that exists in the table");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Animal old = editAnimal;
            editAnimal.AnimalAge = int.Parse(txtAge.Text);
            editAnimal.AnimalSpecies = txtAnimal.Text;
            editAnimal.AnimalName = txtName.Text;
            editAnimal.AnimalRecoveryScore = int.Parse(txtRecoveryScore.Text);
            if (logic.Update(old, editAnimal))
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtAge.Visible = true;
                txtAnimal.Visible = true;
                txtName.Visible = true;
                txtRecoveryScore.Visible = true;
                txtID.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();

            frm.Show();
            this.Close();
        }
    }
}
