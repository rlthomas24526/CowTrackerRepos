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
        public int COWID;

        public frmEditAnimal()
        {
            InitializeComponent();
        }

        public frmEditAnimal(string cowID)
        {
            InitializeComponent();
            lblAnimalIDInfo.Text = cowID;
            COWID = Int32.Parse(cowID);
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
            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            CowList = CowClass.DeleteCow(CowList, COWID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ALLOW USER TO SAVE CHANGES TO ANIMAL
            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            //Reflect the changes in the list
            int indexToChange = 99;
            for (var i = 0; i < CowList.Count; i++)
            {
                CowClass currentCow = CowList[i];

                if (currentCow.ID == COWID)
                {
                    indexToChange = i;
                    CowList[i].notes = tbNotes.Text;
                }
            }

            //Save list to the file
            CowClass.SaveCows(CowList);
        }
    }
}
