using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ADONETDisconnectModel
{
    public partial class DisplayingDataFromExcelSheets : Form
    {
        public DisplayingDataFromExcelSheets()
        {
            InitializeComponent();
        }

        private void DisplayingDataFromExcelSheets_Load(object sender, EventArgs e)
        {
            string cs = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=~/../Customer_Northwid.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'";
            OleDbConnection cn = new OleDbConnection(cs);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [Customers$]", cn);
            DataSet ds = new DataSet();
            da.Fill(ds,"customertbl");
            dtgExcel.DataSource = ds.Tables["customertbl"];
        }
    }
}
