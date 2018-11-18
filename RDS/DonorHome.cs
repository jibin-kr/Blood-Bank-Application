using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDS
{
    public partial class DonorHome : Form
    {
        public DonorHome()
        {
            InitializeComponent();
        }

        private void donorMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.MdiParent = this;
            hm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void donatedHistoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histories hst = new Histories();
            hst.MdiParent = this;
            hst.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.MdiParent = this;
            st.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
