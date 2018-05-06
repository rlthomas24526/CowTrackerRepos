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
    public partial class frmAddAnimal : Form
    {
        bool ID = false;

        public frmAddAnimal()
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
            //ADD THIS LATER TO WRITE TO TEXT FILE
            CowClass newCow = new CowClass();
            newCow.ID = Int32.Parse(Convert.ToString(txtID.Text));
            
            if(radFemale.Checked == true)
            {
                newCow.gender = 'F';
            }
            else
            {
                newCow.gender = 'M';
            }

            if(radMine.Checked == true)
            {
                newCow.herd = 'M';
            }
            else
            {
                newCow.herd = 'N';
            }

            newCow.birthday = Convert.ToDateTime(txtDate.Text);

            if(txtBirthWeight.Text == "")
            {
                newCow.birthweight = 0;
            }
            else
            {
                newCow.birthweight = Int32.Parse(txtBirthWeight.Text);
            }

            if(txtNotes.Text == "")
            {
                newCow.notes = "N/A";
            }
            else
            {
                newCow.notes = txtNotes.Text;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(txtID.Text, out int n);
            if(isNumeric == true)
            {
                btnSave.Enabled = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
