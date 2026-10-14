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
        UpdateLogic logic=new UpdateLogic();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            Animal editAnimal = null;
            editAnimal = logic.FillData(txtID.Text);
            if (editAnimal != null)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtAge.Visible = true;
                txtAge.Text = editAnimal.AnimalAge.ToString();
                txtAnimal.Visible = true;
                txtAnimal.Text = editAnimal.AnimalSpecies;
                txtName.Visible = true;
                txtName.Text = editAnimal.AnimalName;
                txtRecoveryScore.Visible = true;
                txtRecoveryScore.Text = editAnimal.AnimalRecoveryScore.ToString();
            }
            else
            {
                MessageBox.Show("ID not found, please enter an ID that exists in the table");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
