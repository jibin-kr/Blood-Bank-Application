using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDS;

namespace RDS
{
    public partial class Home : Form
    {
        RDSEntities rd = new RDSEntities();
        private Timer tm = new Timer();
        public Home()
        {

            InitializeComponent();
            combobloodGrpSearch.DataSource = rd.BloodGroups.ToList();
            combobloodGrpSearch.ValueMember = "BloodGroup1";
            combobloodGrpSearch.DisplayMember = "Title";
            cmbareasearch1.DataSource = rd.Areas.ToList();
            cmbareasearch1.ValueMember = "Id";
            cmbareasearch1.DisplayMember = "Title";
            GridDonor.DataSource = rd.getallDonor().ToList();
            LoadAllData();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        public void LoadAllData()
        {
            GridDonor.DataSource = rd.getallDonor().ToList();
        }
        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            lblErrorselction1.Visible = false;

        }




        private void Home_Load(object sender, EventArgs e)
        {
            GridDonor.ClearSelection();
       
        }

     



        private void btnAdddonor_Click(object sender, EventArgs e)
        {
            int i = 0;
            Create_Donor cd = new Create_Donor(i);
            cd.ShowDialog();
            GridDonor.DataSource = rd.getallDonor().ToList();
            GridDonor.ClearSelection();
            lblErrorselction1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (GridDonor.SelectedRows.Count > 0)
            {


                lblErrorselction1.Visible = false;
                int ok = 0;
                int notOk = 0;
                var Result = MessageBox.Show("Do you want to add donors to Donated list?", "Blood Donation Confirm !", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    for (int i = 0; i < GridDonor.SelectedRows.Count; i++)
                    {
                        var Member = GridDonor.SelectedRows[i].Cells["Donor_ID"].Value;
                        var Name = GridDonor.SelectedRows[i].Cells["Name"].Value;
                        var Donor_Status = GridDonor.SelectedRows[i].Cells["Donor_Status"].Value;
                        if (Donor_Status.ToString() == "Eligible")
                        {

                            rd.SetDonatedhistory(Convert.ToInt32(Member));
                            if (GridDonor.SelectedRows.Count == 1)
                            { MessageBox.Show("" + Name + " " + " Successfully added to Donated List"); }
                            else
                            {
                                ok = ok + 1;
                            }
                            GridDonor.DataSource = rd.getallDonor().ToList();




                        }
                        else
                        {
                            if (GridDonor.SelectedRows.Count == 1)
                            {
                                MessageBox.Show("" + Name + " " + "is not eligible for donate blood");
                            }
                            else
                            {
                                notOk = notOk + 1;
                            }

                        }


                    }
                    if (ok > 0)
                    {
                        MessageBox.Show("" + ok + " " + "Donors are added to the Donated list");
                    }
                    if (notOk > 0)
                    {
                        MessageBox.Show("" + notOk + " " + "Donors are not eligible for donate blood");
                    }
                }
            }
            else
            {
                lblErrorselction1.Show();
                lblErrorselction1.Text = "You cannot add to donors list without select any donor !!";
            }
            GridDonor.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridDonor.ClearSelection();
            lblErrorselction1.Visible = false;
        }

     

        private void GridDonor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrorselction1.Visible = false;
        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridDonor.SelectedRows.Count == 1)
            {
                lblErrorselction1.Visible = false;
                var Member = GridDonor.SelectedRows[0].Cells["Donor_ID"].Value;
                var Name = GridDonor.SelectedRows[0].Cells["Name"].Value;
                var Donor_Status = GridDonor.SelectedRows[0].Cells["Donor_Status"].Value;
                Create_Donor cd = new Create_Donor(Convert.ToInt32(Member));
                cd.ShowDialog();
                GridDonor.DataSource = rd.getallDonor().ToList();
                GridDonor.ClearSelection();
            }
            else if (GridDonor.SelectedRows.Count>1)
            {
                lblErrorselction1.Show();
                lblErrorselction1.Text = "Only one donor can View/edit at a time !!";
            }
            else
            {
                lblErrorselction1.Show();
                lblErrorselction1.Text = " You cannot View/edit without select any donor !!";
            }
        }

        private void GridDonor_SelectionChanged(object sender, EventArgs e)
        {
            lblErrorselction1.Visible = false;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridDonor.SelectedRows.Count != 0)
            {


                lblErrorselction1.Visible = false;
                int ok = 0;
                var Result = MessageBox.Show("Do you want to Delete this ?", "Delete Confirm", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    for (int i = 0; i < GridDonor.SelectedRows.Count; i++)
                    {
                        var Member = GridDonor.SelectedRows[i].Cells["Donor_ID"].Value;
                        var Name = GridDonor.SelectedRows[i].Cells["Name"].Value;
                        
                            rd.Deletedonor(Convert.ToInt32(Member));
                            if (GridDonor.SelectedRows.Count == 1)
                            { MessageBox.Show("" + Name + " " + " Successfully Deleted from to Donor List"); }
                            else
                            {
                                ok = ok + 1;
                            }
                            GridDonor.DataSource = rd.getallDonor().ToList();

                    }
                    if (ok > 0)
                    {
                        MessageBox.Show("" + ok + " " + "Donors are deleted from Donor list");
                    }
                }
            }
            else
            {
                lblErrorselction1.Show();
                lblErrorselction1.Text = "You cannot delete donor without select !";
            }
            GridDonor.ClearSelection();
        }
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            lblErrorselction1.Visible = false;
            GridDonor.Visible = true;
            if (cmbareasearch1.SelectedIndex == 0 && txtnamesearch1.Text != "" && combobloodGrpSearch.SelectedIndex == 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Name.ToLower().Contains(txtnamesearch1.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else if (combobloodGrpSearch.SelectedIndex > 0 && txtnamesearch1.Text == "" && cmbareasearch1.SelectedIndex == 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Blood_group.ToLower().Contains(combobloodGrpSearch.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }

            else if (combobloodGrpSearch.SelectedIndex == 0 && txtnamesearch1.Text == "" && cmbareasearch1.SelectedIndex > 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Area.ToLower().Contains(cmbareasearch1.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else if (cmbloodGroupSearch.SelectedIndex > 0 && txtnamesearch1.Text != "" && cmbareasearch1.SelectedIndex > 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Name.ToLower().Contains(txtnamesearch1.Text.ToLower()) && s.Blood_group.ToLower().Contains(combobloodGrpSearch.Text.ToLower()) && s.Area.ToLower().Contains(cmbareasearch1.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else if (combobloodGrpSearch.SelectedIndex > 0 && txtnamesearch1.Text != "" && cmbareasearch1.SelectedIndex == 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Name.ToLower().Contains(txtnamesearch1.Text.ToLower()) && s.Blood_group.ToLower().Contains(combobloodGrpSearch.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else if (combobloodGrpSearch.SelectedIndex > 0 && txtnamesearch1.Text== "" && cmbareasearch1.SelectedIndex > 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Blood_group.ToLower().Contains(combobloodGrpSearch.Text.ToLower()) && s.Area.ToLower().Contains(cmbareasearch1.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else if (combobloodGrpSearch.SelectedIndex == 0 && txtnamesearch1.Text != "" && cmbareasearch1.SelectedIndex > 0)
            {
                GridDonor.DataSource = rd.getallDonor().Where(s => s.Name.ToLower().Contains(txtnamesearch1.Text.ToLower()) && s.Area.ToLower().Contains(cmbareasearch1.Text.ToLower())).OrderBy(d => d.Donor_Status).GroupBy(a => a.Blood_group).SelectMany(o => o).ToList();
                if (GridDonor.RowCount == 0)
                {
                    lblErrorselction1.Visible = true;
                    lblErrorselction1.Text = "No search result";
                    GridDonor.Visible = false;
                }
            }
            else
            {
                lblErrorselction1.Visible = true;
                lblErrorselction1.Text = "No search result";
                GridDonor.Visible = false;
            }
            GridDonor.ClearSelection();
        }

        private void btnGetAlldonor1_Click_1(object sender, EventArgs e)
        {
            lblErrorselction1.Visible = false;
            GridDonor.Visible = true;
            GridDonor.DataSource = rd.getallDonor().ToList();
        }

        private void BtnCancel1_Click_1(object sender, EventArgs e)
        {
            txtnamesearch1.Text = "";
            cmbareasearch1.SelectedIndex = 0;
            combobloodGrpSearch.SelectedIndex = 0;

        }
    }
}
