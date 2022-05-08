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
    public partial class TestControl : Form
    {
        public TestControl()
        {
            InitializeComponent();
        }

        private void TestControl_Load(object sender, EventArgs e)
        {
            HelperClass h = new HelperClass();
            h.loadDataToProfile(textBoxTest);
            
        }
    }
}
