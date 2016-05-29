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
    public partial class SearchEmployee : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;

        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=NORTHWIND;Data Source=.";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            ds = new DataSet();
            da.Fill(ds, "DataSEmpleados");
            ds.Tables["DataSEmpleados"].Constraints.Add("Emp_PK", ds.Tables["DataSEmpleados"].Columns[0], true);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(txtEmpno.Text);

            if (ds.Tables[0].Rows.Contains(idempleado) == true)
            {
                DataRow row;
                row = ds.Tables[0].Rows.Find(idempleado);
                txtEname.Text = row["FirstName"].ToString();
                txtEmpLastName.Text = row["LastName"].ToString();
                txthiredate.Text = row["HireDate"].ToString();
            }
            else
            {
                MessageBox.Show("La busqueda no obtuvo resultados");
                txtEmpLastName.Clear();
                txtEname.Clear();
                txthiredate.Clear();
            }

        }

     
    }
}
