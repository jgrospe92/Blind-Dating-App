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
    public partial class newUserRegistration : Form
    {
        HelperClass h;

        public newUserRegistration(HelperClass h)
        {
            InitializeComponent();
            this.h = h;
        }

        private void userRegistrationApplyBtn_Click(object sender, EventArgs e)
        {
            AddNewUserTODB();
            this.Hide();
            Login login = new Login(h);
            login.ShowDialog();
            this.Close();
        }

        private void newUserRegistration_Load(object sender, EventArgs e)
        {
            userRegistrationPictureBox.Image =
          (Image)(Properties.Resources.ResourceManager.GetObject("_default"));
        }

        // Add the newly created user to the database;
        private void AddNewUserTODB()
        {
            USER newUser = new USER();
            newUser.Id = (h.CountTotalUsers());
            newUser.FirstName = newUserFirstNameTextBoxt.Text;
            newUser.LastName = newUserLastNameTextBoxt.Text;
            newUser.Age = (int)newUserAgeUpAndDownNum.Value;
            newUser.Gender = newUserGenderComboBox.SelectedItem.ToString();
            newUser.Location = newUserLocationTextBox.Text;
            newUser.Bio = newUserBioTextBox.Text;
            h.SetUserTraits(newUserTraitsCheckBox, newUser);
            h.SetUserLikes(newUserLikeCheckBox, newUser);
            newUser.Avatar = "_default"; // For now it takes default image
            newUser.Username = newUserUserNameTextBoxt.Text;
            newUser.Password = newUserPasswordTextBoxt.Text;

            h.users.Add(newUser);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adding your own photo is not yet available, this is just an optional feature!", "READ!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void userRegistrationClearBtn_Click(object sender, EventArgs e)
        {
            newUserFirstNameTextBoxt.Clear();
            newUserLastNameTextBoxt.Clear();
            newUserAgeUpAndDownNum.Value = 18;
            newUserGenderComboBox.Text = "Use the dropddown";
            newUserLocationTextBox.Clear();
            newUserBioTextBox.Clear();
            h.UncheckedList(newUserTraitsCheckBox);
            h.UncheckedList(newUserLikeCheckBox);
            newUserUserNameTextBoxt.Clear();
            newUserPasswordTextBoxt.Clear();

        }

        private void newUserGenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
