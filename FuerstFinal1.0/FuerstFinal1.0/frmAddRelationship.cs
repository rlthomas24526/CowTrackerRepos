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
    public partial class frmAddRelationship : Form
    {
        bool PARENTSEL = false;
        bool CHILDSEL = false;

        public frmAddRelationship()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SAVE RELATIONSHIP
            string parentID = Convert.ToString(lstParent.SelectedItem);
            string childID = Convert.ToString(lstChild.SelectedItem);
            RelationClass relationship = new RelationClass(Int32.Parse(parentID), Int32.Parse(childID));

            //LOAD THE FILES
            List<RelationClass> RelationList = new List<RelationClass>();
            RelationList = RelationClass.RetrieveRelationInfo();

            //Save the relationship
            RelationClass.AddRelation(RelationList, relationship);
        }

        private void frmAddRelationship_Load(object sender, EventArgs e)
        {
            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            lstParent.Items.Clear();
            lstChild.Items.Clear();

            for(var i = 0; i < CowList.Count; i++)
            {
                lstParent.Items.Add((CowList[i].ID).ToString());
                lstChild.Items.Add((CowList[i].ID).ToString());
            }
        }

        private void lstParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            PARENTSEL = true;

            if(CHILDSEL == true)
            {
                btnSave.Enabled = true;
            }
        }

        private void lstChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            CHILDSEL = true;

            if(PARENTSEL == true)
            {
                btnSave.Enabled = true;
            }
        }
    }
}
