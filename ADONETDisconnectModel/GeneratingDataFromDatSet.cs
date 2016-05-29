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
    public partial class GeneratingDataFromDatSet : Form
    {
        public GeneratingDataFromDatSet()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northWindDS);

        }

        private void GeneratingDataFromDatSet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northWindDS.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northWindDS.Employees);

        }
    }
}
