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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void Read_Load(object sender, EventArgs e)
        {
            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=NORTHWIND;Data Source=.";

            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DataSetEmpleados");
            dtgEmployees.DataSource = ds.Tables[0];
        }
    }
}
