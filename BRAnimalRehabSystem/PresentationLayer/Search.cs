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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchLogic handler= new SearchLogic();
            Animal list = null;
            list=handler.Search(txtID.Text);
            BindingSource source= new BindingSource();
            source.DataSource=list;
            dgvSearch.DataSource=source;
        }
    }
}
