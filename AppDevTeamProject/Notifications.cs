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
    public partial class Notifications : Form
    {
        private HelperClass h;
        public Notifications(HelperClass h)
        {
            InitializeComponent();
            this.h = h;

        }

        private void notificationsViewBtn_Click(object sender, EventArgs e)
        {
            if(h.getTotalMatch() > 0)
            {
                this.Hide();
                listOfMatched listofMactch = new listOfMatched(h);
                listofMactch.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No Match found, Be Patient! You'll get mmatch soon", "NO MATCH FOUND!!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            
        }

        private void notificationsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            notifMatchCounLabel.Text = h.getTotalMatch().ToString();
        }
    }
}
