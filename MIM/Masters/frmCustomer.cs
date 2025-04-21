using MIM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIM.Masters
{
    public partial class frmCustomer: Form
    {
        DbHelper db=new DbHelper();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrWhiteSpace(txtName.Text)||
                string.IsNullOrWhiteSpace(txtAddress.Text)||
                string.IsNullOrWhiteSpace(txtEmail.Text)||
                string.IsNullOrWhiteSpace(txtBirthDate.Text)||
                string.IsNullOrWhiteSpace(txtMobileNo.Text) )
            {
                MessageBox.Show("Please Fill all fields...");
                return;
            }

            //save to db
            db.cmd.Parameters.Clear();
            db.cmd.CommandText = "Proc_saveCustomer";
            db.cmd.CommandType = CommandType.StoredProcedure;

            //adding parameters
            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "Id";
            pId.SqlDbType = SqlDbType.Int;
            pId.Value =string.IsNullOrEmpty(txtId.Text)?0: Convert.ToInt32(txtId.Text);
            db.cmd.Parameters.Add(pId);

            SqlParameter pName = new SqlParameter();
            pName.ParameterName = "Name";
            pName.SqlDbType = SqlDbType.NVarChar;
            pName.Size = 200;
            pName.Value=txtName.Text;
            db.cmd.Parameters.Add(pName);

            SqlParameter pAddress = new SqlParameter();
            pAddress.ParameterName = "Address";
            pAddress.SqlDbType = SqlDbType.NVarChar;
            pAddress.Size = 50;
            pAddress.Value = txtAddress.Text;
            db.cmd.Parameters.Add(pAddress);

            SqlParameter pBirthDate = new SqlParameter();
            pBirthDate.ParameterName = "BirthDate";
            pBirthDate.SqlDbType = SqlDbType.DateTime;
           
            pBirthDate.Value = txtBirthDate.Text;
            db.cmd.Parameters.Add(pBirthDate);

            string Gender = "Male";
            if (rdoFemale.Checked)
            {
                Gender = "FeMale";
            }
            SqlParameter pGender = new SqlParameter();
            pGender.ParameterName = "Gender";
            pGender.SqlDbType = SqlDbType.NVarChar;
            pGender.Size = 50;
            pGender.Value = Gender;
            db.cmd.Parameters.Add(pGender);

            SqlParameter pMobileNo = new SqlParameter();
            pMobileNo.ParameterName = "MobileNo";
            pMobileNo.SqlDbType = SqlDbType.NVarChar;
            pMobileNo.Size = 50;
            pMobileNo.Value = txtMobileNo.Text;
            db.cmd.Parameters.Add(pMobileNo);

            SqlParameter pEmail = new SqlParameter();
            pEmail.ParameterName = "Email";
            pEmail.SqlDbType = SqlDbType.NVarChar;
            pEmail.Size = 50;
            pEmail.Value = txtEmail.Text;
            db.cmd.Parameters.Add(pEmail);



            SqlParameter pCity = new SqlParameter();
            pCity.ParameterName = "CityId";
            pCity.SqlDbType = SqlDbType.Int;
            pCity.Value = Convert.ToInt32(comboCity.SelectedValue);
            db.cmd.Parameters.Add(pCity);

            SqlParameter pCode = new SqlParameter();
            pCode.ParameterName = "Code";
            pCode.SqlDbType = SqlDbType.Int;
            pCode.Direction = ParameterDirection.Output;            db.cmd.Parameters.Add(pCode);


            SqlParameter pMessage = new SqlParameter();
            pMessage.ParameterName = "Message";
            pMessage.SqlDbType = SqlDbType.VarChar;
            pMessage.Size = 8000;
            pMessage.Direction = ParameterDirection.Output;
            db.cmd.Parameters.Add(pMessage);

            db.cmd.ExecuteNonQuery();
            MessageBox.Show(pMessage.Value.ToString());
            LoadData();
            ClearForm();

        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobileNo.Clear();
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            
            comboCity.DataSource = db.GetDataSet("Select Id,Name from tblCity");
            comboCity.DisplayMember = "Name";
            comboCity.ValueMember = "Id";
            LoadData();
        }

        private void LoadData()
        {
            db.cmd.Parameters.Clear();
            db.cmd.CommandText = "getAllCustomers";
            db.cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter dt = new SqlDataAdapter(db.cmd);
            DataSet ds = new DataSet();
             dt.Fill(ds, "MyTable");

            CustomerGrid.DataSource = null;
            CustomerGrid.DataSource = ds.Tables["MyTable"];
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseConnection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            db.cmd.Parameters.Clear();
            db.cmd.CommandText = "getAllCustomers";
            db.cmd.CommandType = CommandType.StoredProcedure;

            //adding parameter
            SqlParameter pSearchKey = new SqlParameter();
            pSearchKey.ParameterName = "SearchKey";
            pSearchKey.SqlDbType = SqlDbType.NVarChar;
            pSearchKey.Value = txtSearch.Text;
            pSearchKey.Size = 100;
            db.cmd.Parameters.Add(pSearchKey);



            SqlDataAdapter dt = new SqlDataAdapter(db.cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds, "MyTable");

            CustomerGrid.DataSource = null;
            CustomerGrid.DataSource = ds.Tables["MyTable"];
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                return;
            }
            getCustomerById(Convert.ToInt32(txtId.Text));
        }

        void getCustomerById(int _id)
        {
            db.cmd.Parameters.Clear();
            db.cmd.CommandText = "getCustomerById";
            db.cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "Id";
            pId.SqlDbType = SqlDbType.Int;
            pId.Value= _id;
            db.cmd.Parameters.Add(pId);

            var dr = db.cmd.ExecuteReader();

            if (dr.Read())
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text= dr["Name"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtBirthDate.Text = dr["BirthDate"].ToString();
                txtEmail.Text = dr["Email"].ToString() ;
                txtMobileNo.Text = dr["MobileNo"].ToString();
                comboCity.SelectedValue = dr["CityId"].ToString();
                rdoMale.Checked = true;
                if (dr["Gender"].ToString().Trim().ToLower() == "FeMale".ToLower())
                {
                    rdoFemale.Checked = true;
                }


            }
            else
            {
                MessageBox.Show("Not found");
            }
            dr.Close();

        }

        int _cId = 0;
        private void CustomerGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                _cId = Convert.ToInt32(CustomerGrid.Rows[e.RowIndex].Cells["Id"].Value);

            }
            catch (Exception)
            {

                
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cId>0)
            {
                getCustomerById(_cId);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cId > 0)
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteCustomerById( _cId );
                }
              
            }
        }

        private void DeleteCustomerById(int cId)
        {
            db.cmd.Parameters.Clear();
            db.cmd.CommandText = "deleteCustomerById";
            db.cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "Id";
            pId.SqlDbType = SqlDbType.Int;
            pId.Value = _cId;
            db.cmd.Parameters.Add(pId);

            db.cmd.ExecuteNonQuery();
            LoadData();
        }
    }
}
