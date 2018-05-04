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
    public partial class frmCheckRelationship : Form
    {
        public frmCheckRelationship()
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //CHECK RELATIONSHIP
        }
    }
}
