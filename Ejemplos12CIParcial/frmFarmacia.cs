using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos12CIParcial
{
    public partial class frmFarmacia : Form
    {
        public frmFarmacia()
        {
            InitializeComponent();
        }

        private void farmaciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.farmaciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalmedykalsystemDataSet);

        }

        private void frmFarmacia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalmedykalsystemDataSet.Farmacia' Puede moverla o quitarla según sea necesario.
            this.farmaciaTableAdapter.Fill(this.hospitalmedykalsystemDataSet.Farmacia);

        }
    }
}
