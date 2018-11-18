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
    public partial class Histories : Form
    {
        RDSEntities rd = new RDSEntities();
        public Histories()
        {
            InitializeComponent();
            cmbhistoryBlood.DataSource = rd.BloodGroups.ToList();
            cmbhistoryBlood.ValueMember = "BloodGroup1";
            cmbhistoryBlood.DisplayMember = "Title";
            GriddonatedHistories1.DataSource = rd.GetAllDonatedHistories().OrderBy(x => x.Days_After_Donate).GroupBy(s => s.Name).SelectMany(d => d).ToList();
            
        }

        private void Histories_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblsearchError.Visible = false;
            GriddonatedHistories1.Visible = true;
            if (cmbhistoryBlood.SelectedIndex == 0 && txthistoeyname.Text != "")
            {
                GriddonatedHistories1.DataSource = rd.GetAllDonatedHistories().Where(s => s.Name.ToLower().Contains(txthistoeyname.Text.ToLower())).OrderBy(d => d.Days_After_Donate).GroupBy(a => a.Name).SelectMany(o => o).ToList();
                if (GriddonatedHistories1.RowCount == 0)
                {
                    lblsearchError.Visible = true;
                    GriddonatedHistories1.Visible = false;
                }
            }
            else if (cmbhistoryBlood.SelectedIndex > 0 && txthistoeyname.Text == "")
            {
                GriddonatedHistories1.DataSource = rd.GetAllDonatedHistories().Where(s => s.Blood_Group.ToLower().Contains(cmbhistoryBlood.Text.ToLower())).OrderBy(d => d.Days_After_Donate).GroupBy(a => a.Name).SelectMany(o => o).ToList();
                if (GriddonatedHistories1.RowCount == 0)
                {
                    lblsearchError.Visible = true;
                    GriddonatedHistories1.Visible = false;
                }
            }

            else if (cmbhistoryBlood.SelectedIndex > 0 && txthistoeyname.Text != "")
            {
                GriddonatedHistories1.DataSource = rd.GetAllDonatedHistories().Where(s => s.Name.ToLower().Contains(txthistoeyname.Text.ToLower()) && s.Blood_Group.ToLower().Contains(cmbhistoryBlood.Text.ToLower())).OrderBy(d => d.Days_After_Donate).GroupBy(a => a.Name).SelectMany(o => o).ToList();
                if (GriddonatedHistories1.RowCount == 0)
                {
                    lblsearchError.Visible = true;
                    GriddonatedHistories1.Visible = false;
                }
            }
            else
            {
                lblsearchError.Visible = true;
                GriddonatedHistories1.Visible = false;
            }
        }

        private void btnGetall_Click(object sender, EventArgs e)
        {
            GriddonatedHistories1.DataSource = rd.GetAllDonatedHistories().OrderBy(x => x.Days_After_Donate).GroupBy(s => s.Name).SelectMany(d => d).ToList();
            lblsearchError.Visible = false;
            GriddonatedHistories1.Visible = true;
            txthistoeyname.Text = "";
            cmbhistoryBlood.SelectedIndex = 0;
        }

        private void btnhistoryCancel_Click(object sender, EventArgs e)
        {
            txthistoeyname.Text = "";
            cmbhistoryBlood.SelectedIndex = 0;
            GriddonatedHistories1.DataSource = null;
            GriddonatedHistories1.Visible = false;
        }
    }
}
