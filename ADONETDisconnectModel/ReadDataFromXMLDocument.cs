using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETDisconnectModel
{
    public partial class ReadDataFromXMLDocument : Form
    {
        public ReadDataFromXMLDocument()
        {
            InitializeComponent();
        }

        private void ReadDataFromXMLDocument_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("~/../Products.xml");
            dtgXML.DataSource = ds.Tables[0];
        }
    }
}
