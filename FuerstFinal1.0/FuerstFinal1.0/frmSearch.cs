using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuerstFinal1._0
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditThisCow_Click(object sender, EventArgs e)
        {
            Form EditAnimal = new frmEditAnimal();
            EditAnimal.Owner = this;
            EditAnimal.Show();
            this.Hide();
        }

        private void btnViewCow_Click(object sender, EventArgs e)
        {
            Form ViewAnimal = new frmViewAnimal();
            ViewAnimal.Owner = this;
            ViewAnimal.Show();
            this.Hide();
        }
    }
}
