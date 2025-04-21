using MIM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIM.Masters
{
    
    public partial class frmCity: Form
    {
        DbHelper db = new DbHelper();
        public frmCity()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please Fill City Name");
                return;
            }
            //Save data
            //Insert data
            string Msg = "";
            int ret = 0;
            var dr = db.GetData($"select Name from tblCity where Id={txtId.Text}");
            if (dr.Read())
            {
                dr.Close();
                ret = db.DoUpdate($"update tblCity set Name='{txtName.Text}' where Id={txtId.Text}", out Msg);
            }
            else
            {
                dr.Close();
                ret = db.DoUpdate($"Insert into tblCity(Name) values('{txtName.Text}')", out Msg);
            }
            if (ret > 0)
            {
                MessageBox.Show("Saved Successfully..");
                ClearForm();
                LoadData();
            }
            else
            {
                MessageBox.Show("Unable to save  ...Error" + Msg);
            }
          

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CityGrid.DataSource = null;
            CityGrid.DataSource=db.GetDataSet($"select Id,Name from tblCity");
        }

        private void frmCity_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }

        int Vid = 0;
        private void CityGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                Vid = Convert.ToInt32(CityGrid.Rows[e.RowIndex].Cells["Id"].Value);
            }
            catch (Exception)
            {

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Id required...");
                return;
            }
            FindCity(Convert.ToInt32(txtId.Text));
        }

        private void FindCity(int v)
        {
            ClearForm();
          var dr= db.GetData($"select Id,Name from tblCity where Id={v}");
            try
            {
                if (dr.Read())
                {
                    txtId.Text = dr["Id"].ToString();
                    txtName.Text = dr["Name"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found..");
                }
            }
            catch (Exception er)
            {

            }
            finally
            {
                dr.Close();
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CityGrid.DataSource = null;
            CityGrid.DataSource = db.GetDataSet($"select Id,Name from tblCity where  Name like '%{txtSearch.Text}%'");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Vid > 0)
            {
                FindCity(Vid);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Vid > 0)
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) 
                {
                    return;
                }
                string Msg = "";
                int ret=db.DoUpdate($"Delete  from tblCity where Id={Vid}",out Msg);
                if (ret > 0)
                {
                    MessageBox.Show("Record Deleted successfully...");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Unable to delete.."+Msg);
                }
            }
        }
    }
}
