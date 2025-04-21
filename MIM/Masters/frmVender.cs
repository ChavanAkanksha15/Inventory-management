using MIM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIM.Masters
{
    public partial class frmVender: Form
    {
        DbHelper db = new DbHelper();

        public frmVender()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //validation
            string Gender = "Male";
            if (!rdoMale.Checked)
            {
                Gender = "Female";
            }

            List<string> catList=new List<string>();
            if (chkDairy.Checked) 
            {
                catList.Add("Dairy");
            }
            if (ChkElectronics.Checked)
            {
                catList.Add("Electronics");
            }
            if (ChkCloths.Checked)
            {
                catList.Add("Cloths");
            }
            if (ChkGrocery.Checked)
            {
                catList.Add("Grocery");
            }
            string Categories = string.Join("", catList);
            //save to db
           
            //insert vender
            string Msg = "";
            int ret = 0;
            var dr = db.GetData($"select * from tblVender where Id={txtId.Text}");
            if (dr.Read())
            {
                dr.Close();
                ret = db.DoUpdate($"Update tblVender set Name='{txtName.Text}',Address='{txtAddress.Text}',MobileNo='{txtMobileNo.Text}',Email='{txtEmail.Text}',BirthDate='{txtBirthDate.Text}',Gender='{Gender}',GSTN='{txtGSTN.Text}',CityId='{comboCity.SelectedValue}',Category='{Categories}',CreatedOn=getdate() where Id={txtId.Text}", out Msg);

            }
            else
            {
                dr.Close();
                ret = db.DoUpdate($"insert into tblVender(Name,Address,MobileNo,Email,BirthDate,Gender,GSTN,CityId,Category,CreatedOn) values('{txtName.Text}','{txtAddress.Text}','{txtMobileNo.Text}','{txtEmail.Text}','{txtBirthDate.Text}','{Gender}','{txtGSTN.Text}','{comboCity.SelectedValue}','{Categories}',getdate())", out Msg);

            }
           
            if (ret > 0)
            {
                MessageBox.Show("Saved");
                ClearForm();
                LoadData();

            }
            
            else
            {
                MessageBox.Show($"Unable to save ...Error:"+Msg);
            }
               
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtGSTN.Clear();
            
        }

        private void frmVender_Load(object sender, EventArgs e)
        {
            LoadData();

            comboCity.DataSource = db.GetDataSet("Select Id,Name from tblCity");
            comboCity.DisplayMember = "Name";
            comboCity.ValueMember = "Id";
        }

        private void LoadData()
        {
          
            VenderDataGrid.DataSource = null;
            VenderDataGrid.DataSource = db.GetDataSet($"Select V.Id,V.Name,V.Address,V.MobileNo,V.Email,V.BirthDate,V.Gender,V.GSTN,C.Name as City,V.Category,V.CreatedOn from tblVender as V,tblCity as C where C.Id=V.CityId");
          
        }

        private void frmVender_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }

 

        private void find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Id required");
                return;
            }
        FindVender(Convert.ToInt32(txtId.Text));
        }

        private void FindVender(int v)
        {
            ClearForm();
            var dr = db.GetData($"select Id,Name,Address,MobileNo,Email,BirthDate,Gender,GSTN,CityId,Category,CreatedOn from tblvender where Id={v}");
           
            try
            {
                if (dr.Read())
                {
                    txtId.Text = dr["Id"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    txtMobileNo.Text = dr["MobileNO"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtGSTN.Text = dr["GSTN"].ToString();
                    txtBirthDate.Text = dr["BirthDate"].ToString();

                    if (dr["Gender"].ToString() == "Male")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    string catString = dr["Category"].ToString();
                    chkDairy.Checked = false;
                    ChkElectronics.Checked = false;
                    ChkGrocery.Checked = false;
                    ChkCloths.Checked = false;
                    foreach (var item in catString.Split(','))
                    {
                        if (item == "Dairy")
                        {
                            chkDairy.Checked = true;
                        }
                        if (item == "Electronics")
                        {
                            ChkElectronics.Checked = true;
                        }
                        if (item == "Grocery")
                        {
                            ChkGrocery.Checked = true;
                        }
                        if (item == "Cloths")
                        {
                            ChkCloths.Checked = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            catch(Exception er)
            {

            }
            finally
            {
                dr.Close();
            }
          
        }

        int Vid = 0;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Vid > 0)
            {
            FindVender(Vid);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void VenderDataGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                Vid = Convert.ToInt32(VenderDataGrid.Rows[e.RowIndex].Cells["Id"].Value);
            }
            catch (Exception)
            {

            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            VenderDataGrid.DataSource = null;
            VenderDataGrid.DataSource = db.GetDataSet($"Select V.Id,V.Name,V.Address,V.MobileNo,V.Email,V.BirthDate,V.Gender,V.GSTN,C.Name as City,V.Category,V.CreatedOn from tblVender as V,tblCity as C where C.Id=V.CityId and V.Name like '%{Search.Text}%'");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (Vid > 0)
            {
                string Msg = "";
                int ret = db.DoUpdate($"Delete from tblVender where Id={Vid}", out Msg);
                if (ret > 0)
                {
                    MessageBox.Show("Deleted");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Unable to delete"+Msg);
                }
            }
        }
    }
}
