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
    public partial class Settings : Form
    {
        RDSEntities rd = new RDSEntities();
        public Settings()
        {
            InitializeComponent();
       
            var query = (from gg in rd.Users
                         where gg.Active == true
                         select new { gg.Id, gg.UserName, gg.Password });
            Griduser.DataSource = query.ToList();          
            gridArea.DataSource = rd.GetallArea().ToList();
            gridArea.ClearSelection();
            Griduser.ClearSelection();
        }

        private void btnsetarea_Click(object sender, EventArgs e)
        {
            if (txtsetarea.Text == "")
            {
                lblsetareaError.Text = "Please privide area Name";
                lblsetareaError.Show();
            }
            else
            {
                lblsetareaError.Visible = false;
                var chk = rd.GetallArea().Where(x => x.Area_Name.ToLower() == (txtsetarea.Text).ToLower()).FirstOrDefault();
                if (chk == null)
                {
                    rd.CreateArea(txtsetarea.Text);
                    gridArea.DataSource = rd.GetallArea().ToList();
                    //cmbareasearch.DataSource = rd.Areas.ToList();
                    //cmbareasearch.ValueMember = "Id";
                    //cmbareasearch.DisplayMember = "Title";
                    //Create_Donor cs = new Create_Donor();
                    //cs.Refresh();
                    txtsetarea.Text = "";
                }
                else
                {
                    lblsetareaError.Text = "Area Allready Exists !";
                    lblsetareaError.Show();
                }
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            if (txtsetpass.Text == "" || txtreguser.Text == "")
            {
                lblerrorsetuser.Text = "Please fill all details";
                lblerrorsetuser.Show();
            }
            else
            {
                lblerrorsetuser.Visible = false;
                var chk1 = rd.Users.Where((x => x.UserName.ToLower() == txtreguser.Text.ToLower() && x.Password.ToLower() == txtsetpass.Text.ToLower())).FirstOrDefault();
                var chk2 = rd.Users.Where(x => x.UserName.ToLower() == txtreguser.Text.ToLower()).FirstOrDefault();
                if (chk1 == null || chk2 == null)
                {
                    User us = new User();
                    us.UserName = txtreguser.Text;
                    us.Password = txtsetpass.Text;
                    us.IsAdmin = true;
                    us.Active = true;
                    rd.Users.Add(us);
                    rd.SaveChanges();
                    txtreguser.Text = "";
                    txtsetpass.Text = "";
                    var query = (from t in rd.Users
                                 where t.Active == true
                                 select new { t.Id, t.UserName, t.Password });
                    Griduser.DataSource = query.ToList();

                }
                else
                {
                    lblerrorsetuser.Text = "User Name or Password All ready exists";
                    lblerrorsetuser.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (gridArea.SelectedRows.Count != 0)
            //{
            //    lblsetareaError.Visible = false;
            //    int ok = 0;
            //    var Result = MessageBox.Show("Do you want to Delete this ?", "Delete Confirm", MessageBoxButtons.YesNo);
            //    if (Result == DialogResult.Yes)
            //    {
            //        for (int i = 0; i < gridArea.SelectedRows.Count; i++)
            //        {
            //            var Name = gridArea.SelectedRows[i].Cells["Area_Name"].Value;

            //            var chk = rd.DeleteArea(Name.ToString());
            //            int flag = Convert.ToInt32(chk);
            //            rd.Deletedonor((Name));
            //            if (gridArea.SelectedRows.Count == 1)

            //            {
            //                if (flag == 1)
            //                {
            //                    MessageBox.Show("" + Name + " " + " Successfully Deleted from to Donor List");
            //                }
            //            }
            //            else
            //            {
            //                if (flag == 1)
            //                {
            //                    ok = ok + 1;

            //                }
            //            }
            //            gridArea.DataSource = rd.getallDonor().ToList();

            //        }
            //        if (ok > 0)
            //        {
            //            MessageBox.Show("" + ok + " " + "Area are deleted from Donor list");
            //        }
            //    }
            //}
            //else
            //{
            //    lblsetareaError.Show();
            //    lblsetareaError.Text = "You cannot delete Area without select !";
            //}
            //gridArea.ClearSelection();
        }
    }
}
