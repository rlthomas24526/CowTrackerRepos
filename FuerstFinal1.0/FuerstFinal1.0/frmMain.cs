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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Form AddAnimal = new frmAddAnimal();
            AddAnimal.Owner = this;
            AddAnimal.Show();
            this.Hide();
        }

        private void btnEditAnimal_Click(object sender, EventArgs e)
        {
            Form SearchAnimal = new frmSearch();
            SearchAnimal.Owner = this;
            SearchAnimal.Show();
            this.Hide();
        }

        private void btnAddRelationship_Click(object sender, EventArgs e)
        {
            Form AddRelationship = new frmAddRelationship();
            AddRelationship.Owner = this;
            AddRelationship.Show();
            this.Hide();
        }

        private void btnCheckRelationship_Click(object sender, EventArgs e)
        {
            Form CheckRelationship = new frmCheckRelationship();
            CheckRelationship.Owner = this;
            CheckRelationship.Show();
            this.Hide();
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            //CREATE FILES WITH THE NAME DATE TIME AND INDICATE BACKUP
        }
    }
}
