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
    public partial class MasterDetailApplicationUsingTypeDataSet : Form
    {
        public MasterDetailApplicationUsingTypeDataSet()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northWindDS);

        }

        private void MasterDetailApplicationUsingTypeDataSet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northWindDS.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northWindDS.Products);
            // TODO: esta línea de código carga datos en la tabla 'northWindDS.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northWindDS.Categories);

        }
    }
}
