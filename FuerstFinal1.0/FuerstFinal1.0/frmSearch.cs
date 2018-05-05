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

        private void frmSearch_Load(object sender, EventArgs e)
        {
            
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
            Form EditAnimal = new frmEditAnimal(Convert.ToString(lstCowList.SelectedItem));
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            int TheCow;

            string tbText = textBox1.Text;
            TheCow = CowClass.SearchForCow(CowList, Int32.Parse(tbText));

            if(TheCow != 666)
            {
                lstCowList.Items.Clear();
                lstCowList.Items.Add(tbText);
            }
            else
            {
                lstCowList.Items.Clear();
                lstCowList.Items.Add("No cows match this, sorry :(");
            }
        }

        private void lstCowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditThisCow.Enabled = true;
            btnViewCow.Enabled = true;
        }
    }
}
