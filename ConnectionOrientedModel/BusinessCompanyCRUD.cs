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

namespace ConnectionOrientedModel
{
    public partial class BusinessCompanyCRUD : Form
    {
        SqlConnection cn;
        SqlCommand cmd;

        public BusinessCompanyCRUD()
        {
            InitializeComponent();            
        }

        private void BusinessCompanyCRUD_Load(object sender, EventArgs e)
        {
            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=ADONETDemo1;Data Source=.";
            cn = new SqlConnection(cs);

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            recargarDataGridChart();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = txtName.Text;
            decimal revenue = Convert.ToDecimal(txtRevenue.Text);

            cmd.Parameters.Clear();
            cmd.CommandText = "insert into BusinessCompany values(@cname,@revenue)";
            cmd.Parameters.AddWithValue("@cname", cname);
            cmd.Parameters.AddWithValue("@revenue", revenue);
            AbrirConexion();
            cmd.ExecuteNonQuery();
            cn.Close();
            recargarDataGridChart();
            MessageBox.Show("Se añadio correctamente","Mensaje");
        }

        void AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        void recargarDataGridChart()
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select * from BusinessCompany";
            AbrirConexion();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgCompany.DataSource = dt;
            chartCompany.DataSource = dt;
            chartCompany.Series[0].XValueMember = "BCName";
            chartCompany.Series[0].YValueMembers = "BCRevenue";
            chartCompany.DataBind();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select BCRevenue from BusinessCompany where BCName = @cname";
            cmd.Parameters.AddWithValue("@cname", txtName.Text.Trim());
            AbrirConexion();
            decimal revenue; 
            revenue = Convert.ToDecimal(cmd.ExecuteScalar());
            txtRevenue.Text = revenue.ToString();
            cn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cname = txtName.Text;
            decimal revenue = Convert.ToDecimal(txtRevenue.Text);
            cmd.Parameters.Clear();
            cmd.CommandText = "update BusinessCompany set BCRevenue=@revenue where BCName=@cname";
            cmd.Parameters.AddWithValue("@revenue",revenue);
            cmd.Parameters.AddWithValue("@cname",cname);
            AbrirConexion();
            cmd.ExecuteNonQuery();
            cn.Close();
            recargarDataGridChart();
            MessageBox.Show("Se actualizo correctamente", "Mensaje");            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cname = txtName.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "delete from BusinessCompany where BCName = @cname";
            cmd.Parameters.AddWithValue("@cname", cname);
            AbrirConexion();
            cmd.ExecuteNonQuery();
            cn.Close();
            recargarDataGridChart();
            MessageBox.Show("Se elimino correctamente", "Mensaje");
        }
    }
}
