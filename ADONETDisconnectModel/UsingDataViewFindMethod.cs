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
    public partial class UsingDataViewFindMethod : Form
    {

        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        DataView dv;

        public UsingDataViewFindMethod()
        {
            InitializeComponent();
        }

        private void UsingDataViewFindMethod_Load(object sender, EventArgs e)
        {

        }
    }
}
