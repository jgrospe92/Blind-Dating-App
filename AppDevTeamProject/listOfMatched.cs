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
    public partial class listOfMatched : Form
    {
        // Classhelper Reference
        private HelperClass h;

        // Counter to control next and previoius value
        private static int counter = 0;
        private static int index;
       
        public listOfMatched(HelperClass h)
        {
            InitializeComponent();
            this.h = h;
        }

        private void ListOfMatched_Load(object sender, EventArgs e)
        {
            // Start form index 0
            InstantiateData(h.matchUsers[0]);

        }

        private void InstantiateData(USER user)
        {
            matchProfilePictureBox.Image =
              (Image)(Properties.Resources.ResourceManager.GetObject(user.Avatar));

            matchNameLabel.Text = user.FirstName + " " + user.LastName;

        }

        private void matchNextBtn_Click(object sender, EventArgs e)
        {
            if (counter >= h.getTotalMatch() - 1)
            {
                counter = -1;
               
            }
            else
            {
                InstantiateData(h.matchUsers[++counter]);
                index = counter;
            }
        }

        private void matchPrevBtn_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                counter = h.getTotalMatch();
            }
            else
            {
                InstantiateData(h.matchUsers[--counter]);
                index = counter;
            }
        }

        private void matchVisitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            matchProfile mp = new matchProfile(h.getUserByIndex(index));
            mp.ShowDialog();
            this.Close();
        }
    }
}
