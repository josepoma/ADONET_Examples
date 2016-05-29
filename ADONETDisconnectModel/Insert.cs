using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETDisconnectModel
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=NORTHWIND;Data Source=.";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "DataSetEmployees");
            ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);

            DataRow row;
            row = ds.Tables[0].NewRow();
            row["EmployeeID"] = txtEmpno.Text;
            row["FirstName"] = txtEname.Text;
            row["LastName"] = txtEmpLastName.Text;
            row["Extension"] = txtSalary.Text;
            row["HireDate"] = dtpHireDate.Text;

            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);

        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
