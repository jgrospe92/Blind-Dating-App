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
    public partial class Profile : Form
    {

        public HelperClass h;
        public USER currentUser;
        public Profile(USER usr, HelperClass h)
        {
            InitializeComponent();
            currentUser = usr;
            this.h = h;


        }

        private void profileLogoutBtn_Click(object sender, EventArgs e)
        {
            h.AddnewUserToDB();
            MessageBox.Show("Thank you for using our App!, The Database is updated");
            Application.Exit();
        }

        private void profileNotificationsBtn_Click(object sender, EventArgs e)
        {
            // Clears the list of Matches
            h.clearMatches();
            
            if (h.addMatchUserToList())
            {
                Notifications notif = new Notifications(h);
                notif.ShowDialog();
            }
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(profileSearchTextbox.Text != "" && h.VerifiySearch(profileSearchTextbox.Text.ToLower()))
            {
                h.clearFilter();
                h.Tag = profileSearchTextbox.Text.ToUpper();
                string lookForTrait = profileSearchTextbox.Text.ToLower();
                h.FilteredSearchByTraits(lookForTrait);
                try
                {
                    FilteredSearch f = new FilteredSearch(h);
                    f.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("User does not exist, Try different traits"
                  , "NO USER EXIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            }
            else
            {
                MessageBox.Show("Please enter one of the traits you are looking for"
                    , "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }        
        }

        private void Profile_Load(object sender, EventArgs e)
        {
        

            // Retrieve photos in the resources 
            profilePhotoPictureBox.Image =
               (Image)(Properties.Resources.ResourceManager.GetObject(currentUser.Avatar));


            firstNameTextBox.Text = currentUser.FirstName;
            lastNameTextBox.Text = currentUser.LastName;
            ageTextBox.Text = currentUser.Age.ToString();
            genderTextBox.Text = currentUser.Gender;
            locationTextBox.Text = currentUser.Location;
            foreach( string trait in currentUser.Traits)
            {
                traitsTextBox.Text += trait.ToUpper() + Environment.NewLine;
            }
            foreach (string like in currentUser.Likes)
            {
                likesTextBox.Text += like.ToUpper() + Environment.NewLine;
            }
            bioTextBox.Text = currentUser.Bio;
            currentLoginLabel.Text = currentUser.Username;
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            // show current time
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
