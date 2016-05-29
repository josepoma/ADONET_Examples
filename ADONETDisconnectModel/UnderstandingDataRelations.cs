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
    public partial class UnderstandingDataRelations : Form
    {
        SqlConnection cn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataSet ds;

        public UnderstandingDataRelations()
        {
            InitializeComponent();
        }

        private void UnderstandingDataRelations_Load(object sender, EventArgs e)
        {
            string cs = "Password=sql123;Persist Security Info=True;User ID=sa;Initial Catalog=NORTHWIND;Data Source=.";
            cn = new SqlConnection(cs);
            da1 = new SqlDataAdapter("select * from categories", cn);
            da2 = new SqlDataAdapter("select * from products", cn);

            ds = new DataSet();
            da1.Fill(ds, "Categorias");
            da2.Fill(ds, "Productos");

            ds.Tables[0].Constraints.Add("ConstraintID_PK", ds.Tables["Categorias"].Columns["CategoryID"], true);

            //Creando la relacion entre la tabla productos y categorias dentro en el DataSet
            ds.Relations.Add("Categories_Products", 
                ds.Tables["Categorias"].Columns["CategoryID"],
                ds.Tables["Productos"].Columns["CategoryID"]);

            dtgParent.DataSource = ds.Tables["Categorias"];

            CargarProductosporCategoria(0);

        }

        private void CargarProductosporCategoria(int v)
        {
            var parentRow = ds.Tables["Categorias"].Rows[v];
            var childRows = parentRow.GetChildRows("Categories_Products");

            DataTable childtable = ds.Tables["Productos"].Clone();
            foreach (var row in childRows)
            {
                childtable.ImportRow(row);
            }
            dtgChild.DataSource = childtable;

        }

        private void dtgChild_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarProductosporCategoria(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgParent_SelectionChanged(object sender, EventArgs e)
        {
            CargarProductosporCategoria(dtgParent.CurrentRow.Index);
        }
    }
}
