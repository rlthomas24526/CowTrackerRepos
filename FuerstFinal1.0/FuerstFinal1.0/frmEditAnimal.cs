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
    public partial class frmEditAnimal : Form
    {
        public frmEditAnimal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ALLOW USER TO DELETE THIS ANIMAL
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ALLOW USER TO SAVE CHANGES TO ANIMAL
        }
    }
}
