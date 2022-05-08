using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
        
            Database db = new Database();
            db.LoadDb();
            User user = (User)db.members[0];
            foreach (User x in db.members)
            {
                if (x.ID == 1)
                {
                    MessageContainer.Text = x.FirstName;
                    break;
                }
            }
           
        }
    }
}
