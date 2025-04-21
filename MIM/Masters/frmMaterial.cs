using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//1.include ADO.net packages
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MIM.Masters
{
    public partial class frmMaterial: Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Validation
            if(string.IsNullOrWhiteSpace(txtName.Text)||
                string.IsNullOrWhiteSpace(txtHSNCode.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                txtUOM.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            //Save to db
            //step 2 Create connection and command objects
            SqlConnection con = new SqlConnection();
            //step 5 create command object
            SqlCommand cmd = new SqlCommand();
            try
            {
                
                //step 3 pass connection string
                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                //step 4 Open connection
                con.Open();
                //step 6: Pass Active connection to command object
                cmd.Connection = con;  //assign connection to command object  
                                       //step7 pass ur sql command to command text

                int _id = 0;
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    _id=Convert.ToInt32(txtId.Text);
                }
                if (CheckIdExist(_id))
                {
                    cmd.CommandText = $"Update tblMaterial set  Name='{txtName.Text}',HSNCode='{txtHSNCode.Text}',Price='{txtPrice.Text}',UOM_ID='{txtUOM.SelectedValue}',CreatedOn=getDate() where Id={_id}";

                }
                else
                {
                    cmd.CommandText = $"insert into tblMaterial(Name,HSNCode,Price,UOM_ID,CreatedOn)values('{txtName.Text}','{txtHSNCode.Text}','{txtPrice.Text}','{txtUOM.SelectedValue}',GetDate())";

                }
                //step 8 execute the command
               int ret= cmd.ExecuteNonQuery();//insert update delete only
                if (ret > 0)
                {
                    MessageBox.Show("saved");
                }
                Load_data();
                ClearForm();
            }
            catch(Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        private bool CheckIdExist(int id)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {

                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                string sql = $"select Id,Name,HSNCode,Price,UOM_ID,CreatedOn from tblMaterial where Id={id}";
                cmd.CommandText = sql;

                // cmd.ExecuteScalar();//when select query output is single column
               
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
           

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            LoadDropDown();
            Load_data();
            ClearForm();
        }
        void ClearForm()
        {
            txtId.Clear();
            txtHSNCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            
        }
        private void LoadDropDown()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = "select Id,Name from tblUOM";


                DataSet ds = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(ds, "myTable");

                txtUOM.DataSource = ds.Tables["myTable"];
                txtUOM.DisplayMember = "Name";
                txtUOM.ValueMember = "Id";


            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void Load_data()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = "select M.Id, M.Name,M.HSNCode,M.Price,U.Name as UOM,M.CreatedOn from tblMaterial as M,tblUOM as U where U.Id=M.UOM_ID";
                DataSet ds = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(ds, "myTable");

                MaterialGrid.DataSource = null;
                MaterialGrid.DataSource = ds.Tables[0];


            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtSearchKey_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = "SELECT M.Id, M.Name, M.HSNCode, M.Price, U.Name as UOM, M.CreatedOn " +
                          "FROM tblMaterial AS M, tblUOM AS U " +
                          "WHERE U.Id = M.UOM_ID AND M.Name LIKE @search";

                cmd.Parameters.AddWithValue("@search", "%" + txtSearchKey.Text + "%");
                DataSet ds = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(ds, "myTable");

                MaterialGrid.DataSource = null;
                MaterialGrid.DataSource = ds.Tables[0];


            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please Fillout the Id Field");
                return;
            }
            int _id=Convert.ToInt32(txtId.Text);
            FindById(_id);

        }

      
        int MId = 0;
        private void MaterialGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                MId = Convert.ToInt32(MaterialGrid.Rows[e.RowIndex].Cells["Id"].Value);

            }
            catch(Exception){

            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MId > 0)
            {
                if(MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteMaterialById(MId);
                }
            }
        }

        private void DeleteMaterialById(int mId)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {

                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                string sql = $"Delete from tblMaterial where Id={mId}";
                cmd.CommandText = sql;

               int ret= cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Deleted");
                    Load_data();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MId > 0)
            {
                FindById(MId);
               
            }
        }

        private void FindById(int mId)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {

                con.ConnectionString = "Data Source=.\\MSSQLSERVER22;Initial Catalog=MIM;Persist Security Info=True;User ID=sa;Password=Sql123;Encrypt=False";
                con.Open();

                cmd.Connection = con;
                string sql = $"select Id,Name,HSNCode,Price,UOM_ID,CreatedOn from tblMaterial where Id={mId}";
                cmd.CommandText = sql;

                // cmd.ExecuteScalar();//when select query output is single column
                ClearForm();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtId.Text = dr["Id"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtHSNCode.Text = dr["HSNCode"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtUOM.SelectedValue = dr["UOM_ID"].ToString();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
                dr.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
