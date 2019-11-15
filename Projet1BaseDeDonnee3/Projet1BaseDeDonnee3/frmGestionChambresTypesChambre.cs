using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1BaseDeDonnee3
{
    public partial class frmGestionChambresTypesChambre : Form
    {
        public frmGestionChambresTypesChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionChambresTypesChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeChambre);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Chambre);

        }

        private void btnGestionChambres_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionDesChambres gestionDesChambres = new frmGestionDesChambres();
            gestionDesChambres.ShowDialog();
            this.Show();
        }

        private void btnGestionTypes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionTypeChambre gestionTypeChambre = new frmGestionTypeChambre();
            gestionTypeChambre.ShowDialog();
            this.Show();
        }

        /*private void chambreBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }*/
    }
}
