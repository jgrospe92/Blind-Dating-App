using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTeamProject
{
    public partial class matchProfile : Form
    {

        USER currentUser;
        public matchProfile(USER user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void mpReportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for reporting.Proper action is now taken in place", "REPORTED" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void thumbsDownBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You accepted the match up! Enjoy your date!", "ACCPET MATCH!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void matchedProfSendBtnNow(object sender, EventArgs e)
        {
            SendMessage s = new SendMessage();
            s.ShowDialog();
           
        }

        private void thumbsUpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You declined the match up! Check out your other match up", "DECLINED MATCH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
            
        }

        private void matchProfile_Load(object sender, EventArgs e)
        {
            InstantiateUserMatchUp();
        }

        private void InstantiateUserMatchUp()
        {
            // Retrieve photos in the resources 
            matchedPictureBox.Image =
               (Image)(Properties.Resources.ResourceManager.GetObject(currentUser.Avatar));


            matchedFirstNameTextBox.Text = currentUser.FirstName;
            matchedLastNameTextBox.Text = currentUser.LastName;
            matchedAgeTextBox.Text = currentUser.Age.ToString();
            matchedGenderTextBox.Text = currentUser.Gender;
            matchedLocationTextBox.Text = currentUser.Location;
            foreach (string trait in currentUser.Traits)
            {
                matchedTraitsTextBox.Text += trait.ToUpper() + Environment.NewLine;
            }
            foreach (string like in currentUser.Likes)
            {
                matchedLikesTextBox.Text += like.ToUpper() + Environment.NewLine;
            }
            bioTextBox.Text = currentUser.Bio;
        }
    }
}
