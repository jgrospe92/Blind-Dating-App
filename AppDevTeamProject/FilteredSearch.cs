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
    public partial class FilteredSearch : Form
    {

        // Classhelper Reference
        private HelperClass h;

        private static int counter = 0;

        private static int index; // For now, we are not allowing unmatched visit

        public FilteredSearch(HelperClass h)
        {
            InitializeComponent();
            this.h = h;
                   
                InstantiateDataFilter(h.filteredUsers[0]);
            
               

        }


        private void InstantiateDataFilter(USER user)
        {
            matchProfilePictureBox.Image =
              (Image)(Properties.Resources.ResourceManager.GetObject(user.Avatar));

            filteredTag.Text = h.Tag;

            matchNameLabel.Text = user.FirstName + " " + user.LastName;

        }

        private void matchNextBtn_Click(object sender, EventArgs e)
        {
            if (counter >= h.getFilterListSize() - 1)
            {
                counter = -1;

            }
            else
            {
                InstantiateDataFilter(h.filteredUsers[++counter]);
                index = counter;
            }
        }

        private void matchPrevBtn_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                counter = h.getFilterListSize();
            }
            else
            {
                InstantiateDataFilter(h.filteredUsers[--counter]);
                index = counter;
            }
        }

       
    }
}
