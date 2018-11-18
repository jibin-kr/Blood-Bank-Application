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
    public partial class Create_Donor : Form
    {
        RDSEntities rd = new RDSEntities();
        public int glId = 0;
        public Create_Donor(int id)
        {
            glId = id;
            InitializeComponent();
            cmbArea.DataSource = rd.Areas.Where(x => x.Active == true).ToList();
            cmbArea.ValueMember = "Id";
            cmbArea.DisplayMember = "Title";
            var cmb = rd.BloodGroups.ToList();
            cmbBlood.DataSource = cmb;
            cmbBlood.ValueMember = "BloodGroup1";
            cmbBlood.DisplayMember = "Title";
            if(id>0)
            {
                var donor = rd.Donors.Where(x => x.Id == id && x.Active == true).FirstOrDefault();
                txtName.Text = donor.Name;
                txtsecondname.Text = donor.Second_Name;
                txtphone.Text = donor.Phone;
                txtAddress.Text = donor.Address;
                nmDropdown.Value = donor.Age;
                cmbArea.SelectedValue = donor.Area;
                cmbBlood.SelectedValue = donor.Blood_Group;
                if(donor.Gender=="Male")
                {
                    rdGender.Checked = true;
                }
                else
                {
                    rdGenderf.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || nmDropdown.Text == "" || txtphone.Text == "" ||
              Convert.ToInt32(cmbArea.SelectedValue) == 1 || Convert.ToInt32(cmbBlood.SelectedValue) == 1 ||
              (rdGender.Checked == false && rdGenderf.Checked == false))
            {
                lblError.Show();
            }
            else
            {
                var result = MessageBox.Show("Do you want to Save/Update ??", "Save/ Update Confirm !", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lblError.Visible = false;
                    string gender;
                    if (rdGender.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "female";
                    }
                    rd.CreateDonor(glId, txtName.Text.Trim(), txtphone.Text.Trim(), Convert.ToInt32(nmDropdown.Text), gender, Convert.ToInt32(cmbBlood.SelectedValue),
                        txtAddress.Text.Trim(), txtphone.Text.TrimStart(), Convert.ToInt32(cmbArea.SelectedValue));
                    this.Hide();
                    txtAddress.Text = "";
                    nmDropdown.Text = "";
                    txtphone.Text = "";
                    txtName.Text = "";
                    rdGender.Checked = false;
                    rdGenderf.Checked = false;
                    cmbArea.SelectedIndex = 0;
                    cmbBlood.SelectedIndex = 0;
                }
                else
                {

                    txtAddress.Text = "";
                    nmDropdown.Text = "";
                    txtphone.Text = "";
                    txtName.Text = "";
                    rdGender.Checked = false;
                    rdGenderf.Checked = false;
                    cmbArea.SelectedIndex = 0;
                    cmbBlood.SelectedIndex = 0;
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            nmDropdown.Text = "";
            txtphone.Text = "";
            txtName.Text = "";
            rdGender.Checked = false;
            rdGenderf.Checked = false;
            cmbArea.SelectedIndex = 0;
            cmbBlood.SelectedIndex = 0;
            this.Hide();
        }
    }
}
