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
    public partial class Welcome : Form
    {

        // Main HelperClass reference
        HelperClass h = new HelperClass();
        public Welcome()
        {
            InitializeComponent();
          
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            newUserRegistration newUserForm = new newUserRegistration(h);
            newUserForm.ShowDialog();
            this.Close();
        }

        private void alreadyMemberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(h);
            login.ShowDialog();
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //languageComboBox.SelectedIndex = 0;
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languageComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;

                case 3:
                    changeLanguage.UpdateConfig("language", "fil");
                    Application.Restart();
                    break;

            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is made by Jeffrey Grospe & Md Saqliyan Islam, Under the license of MIT"
             , "About us", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
