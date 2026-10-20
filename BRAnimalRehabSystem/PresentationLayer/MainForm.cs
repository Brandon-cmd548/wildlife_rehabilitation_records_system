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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();

            this.Hide();
            addForm.Show();
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();

            this.Hide();
            updateForm.Show();
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            Search SearchForm = new Search();

            this.Hide();
            SearchForm.Show();
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            frmDeleteForm DeleteForm = new frmDeleteForm();

            this.Hide();
            DeleteForm.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            SummaryForm SummaryForm = new SummaryForm();

            this.Hide();
            SummaryForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
