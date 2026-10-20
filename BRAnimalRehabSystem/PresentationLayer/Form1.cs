using BRAnimalRehabSystem.ApplicationLogic;
using BRAnimalRehabSystem.DataLayer;
using BRAnimalRehabSystem.PresentationLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BRAnimalRehabSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteForm DeleteForm = new frmDeleteForm();

            this.Hide();
            DeleteForm.Show();   
        }
    }
}
