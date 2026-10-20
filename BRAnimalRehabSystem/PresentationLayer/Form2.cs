using BRAnimalRehabSystem.ApplicationLogic;
using BRAnimalRehabSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAnimalRehabSystem.PresentationLayer
{
    public partial class frmDeleteForm : Form
    {

        AnimalFileHandler animalFileHandler = new AnimalFileHandler();
        List<Animal> animals;
        string animalDataPath = @"C:\Users\Cactu\OneDrive - belgiumcampus.ac.za\Belgium College Work\2nd Year 120 Credits\Semester 2\PRG282\Project\BRAnimalRehabSystem\DataLayer\animals.txt";

        int indexRow;
        public frmDeleteForm()
        {
            InitializeComponent();
            animals = animalFileHandler.LoadAnimalList(animalDataPath);
        }
        public void ClearLabels()
        {
            lblDeleteAnimalID.Text = "[ ]";
            lblDeleteAnimalName.Text = "[ ]";
            lblDeleteAnimalSpecies.Text = "[ ]";
            lblDeleteAnimalAge.Text = "[ ]";
            lblDeleteAnimalRecoveryScore.Text = "[ ]";
            lblDeleteAnimalStatus.Text = "[ ]";
            lblDeleteAnimalHousing.Text = "[ ]";
        }

        public void LoadDataGridView()
        {
            BindingSource dgvSource = new BindingSource();
            dgvSource.DataSource = animals;
            dgvDeleteSelectedAnimal.DataSource = dgvSource;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            MainForm frm1 = new MainForm();

            this.Hide();
            frm1.Show();
        }

        private void dgvDeleteSelectedAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvDeleteSelectedAnimal.Rows[indexRow];

            lblDeleteAnimalID.Text = row.Cells[0].Value.ToString();
            lblDeleteAnimalName.Text = row.Cells[1].Value.ToString();
            lblDeleteAnimalSpecies.Text = row.Cells[2].Value.ToString();
            lblDeleteAnimalAge.Text = row.Cells[3].Value.ToString();
            lblDeleteAnimalRecoveryScore.Text = row.Cells[4].Value.ToString();
            lblDeleteAnimalStatus.Text = row.Cells[5].Value.ToString();
            lblDeleteAnimalHousing.Text = row.Cells[6].Value.ToString();
        }

        private void btnDeleteSelectedAnimal_Click(object sender, EventArgs e)
        {
            if (lblDeleteAnimalID.Text.Length <= 3)
            {
                MessageBox.Show("No animal record is selected.");
                return;
            }
            DialogResult userChoiceYesNo = MessageBox.Show($"Are you sure you want to delete {lblDeleteAnimalID.Text}, {lblDeleteAnimalName.Text} from storage? \nThis action is irreversable.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (userChoiceYesNo == DialogResult.No)
            {
                MessageBox.Show("Animal was not deleted.");
                return;
            }
            try
            {
                Animal animal = animals.Find(a => a.AnimalID == lblDeleteAnimalID.Text && a.AnimalName == lblDeleteAnimalName.Text);
                animals.Remove(animal);

                LoadDataGridView();
                animalFileHandler.SaveAnimalList(animalDataPath, animals);

                ClearLabels();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An unexpected error occured and the animal was not deleted: \n" + exc.Message);
                ClearLabels();
            }
        }

        private void frmDeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm frm = new MainForm();

            frm.Show();
        }
    }
}
