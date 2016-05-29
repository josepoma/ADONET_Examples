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

namespace ADONETDisconnectModel
{
    public partial class ManageEmployee : Form
    {
        SqlConnection cn;
        public SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;

        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=NORTHWIND;Data Source=.";

            cn = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from Employees", cn);

            cmb = new SqlCommandBuilder(da);

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
                LimpiarControles();
            }
        }

        void LimpiarControles()
        {
            txtEmpLastName.Clear();
            txtEname.Clear();
            txthiredate.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int registro = Convert.ToInt16(txtEmpno.Text);

            DataRow row;
            row = ds.Tables["DataSEmpleados"].Rows.Find(registro);

            row.BeginEdit();
            row[2] = txtEname.Text;
            row[1] = txtEmpLastName.Text;
            row.EndEdit();

            da.Update(ds.Tables["DataSEmpleados"]);
            MessageBox.Show("Se actualizo el registro","Mensaje");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int registro = Convert.ToInt16(txtEmpno.Text);
            if (MessageBox.Show("¿Desea remover el item?","Delete",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {                
                ds.Tables["DataSEmpleados"].Rows.Find(registro).Delete();
                da.Update(ds.Tables[0]);
                MessageBox.Show("Se elimino el registro "+registro.ToString(), "Mensaje");
                LimpiarControles();
            }
        }
    }
}
