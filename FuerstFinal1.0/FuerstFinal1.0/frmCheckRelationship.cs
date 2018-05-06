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
        bool COW1SEL = false;
        bool COW2SEL = false;

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
            bool canTheyBreed = true;

            //LOAD THE FILES
            List<RelationClass> RelationList = new List<RelationClass>();
            RelationList = RelationClass.RetrieveRelationInfo();

            //Get the necessary ID's
            string cow1ID = Convert.ToString(lstCow1.SelectedItem);
            string cow2ID = Convert.ToString(lstCow2.SelectedItem);

            //Check relationship
            canTheyBreed = RelationClass.SearchForRelation(RelationList, Int32.Parse(cow1ID), Int32.Parse(cow2ID));

            if(canTheyBreed == false)
            {
                lblSafe.Visible = true;
                lblNotSafe.Visible = false;
            }
            else
            {
                lblSafe.Visible = false;
                lblNotSafe.Visible = true;
            }
        }

        private void frmCheckRelationship_Load(object sender, EventArgs e)
        {
            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            lstCow1.Items.Clear();
            lstCow2.Items.Clear();

            for (var i = 0; i < CowList.Count; i++)
            {
                lstCow1.Items.Add((CowList[i].ID).ToString());
                lstCow2.Items.Add((CowList[i].ID).ToString());
            }
        }

        private void lstCow1_SelectedIndexChanged(object sender, EventArgs e)
        {
            COW1SEL = true;

            if (COW2SEL == true)
            {
                btnCheck.Enabled = true;
            }
        }

        private void lstCow2_SelectedIndexChanged(object sender, EventArgs e)
        {
            COW2SEL = true;

            if (COW1SEL == true)
            {
                btnCheck.Enabled = true;
            }
        }
    }
}
