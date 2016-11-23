using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIBaseDeDatos
{
    public partial class UIIngreso_Datos : Form
    {
        public UIIngreso_Datos()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejemplo1DataSet);

        }

        private void UIIngreso_Datos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejemplo1DataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.ejemplo1DataSet.Persona);

        }
    }
}
