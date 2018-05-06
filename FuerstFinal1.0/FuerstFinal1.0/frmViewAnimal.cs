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
    public partial class frmViewAnimal : Form
    {
        int COWID;

        public frmViewAnimal()
        {
            InitializeComponent();
        }

        public frmViewAnimal(string cowID)
        {
            InitializeComponent();
            lblIDInfo.Text = cowID;
            COWID = Int32.Parse(cowID);

            //LOAD THE FILES
            List<CowClass> CowList = new List<CowClass>();
            CowList = CowClass.RetrieveCowInfo();

            //Find the cow in question to populate the form
            int index = 99;
            for (var i = 0; i < CowList.Count; i++)
            {
                CowClass currentCow = CowList[i];

                if (currentCow.ID == COWID)
                {
                    index = i;
                }
            }

            string gen;
            if (CowList[index].gender == 'F')
            {
                gen = "Female";
            }
            else
            {
                gen = "Male";
            }
            lblGenderInfo.Text = gen;

            string hherd;
            if (CowList[index].herd == 'N')
            {
                hherd = "Not Mine";
            }
            else
            {
                hherd = "Mine";
            }
            lblHerdInfo.Text = hherd;

            string year, month, day;
            year = (CowList[index].birthday.Year).ToString();
            month = (CowList[index].birthday.Month).ToString();
            day = (CowList[index].birthday.Day).ToString();
            lblBirthDateInfo.Text = month + "/" + day + "/" + year;

            lblBirthWeightInfo.Text = (CowList[index].birthweight).ToString();

            rtbNotes.Text = CowList[index].notes;
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

        private void frmViewAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
