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

namespace Projet1BaseDeDonnee3
{
    public partial class frmGestionTypeChambre : Form
    {
        public frmGestionTypeChambre()
        {
            InitializeComponent();
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

        }

        private void frmGestionTypeChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.Chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.Chambre);
            // TODO: This line of code loads data into the 'bDTP1Guelleh_MarreroDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bDTP1Guelleh_MarreroDataSet.TypeChambre);

        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            int intNoType = 0;
            bool blnIntNoTypeTrouve = true;
            List<Int32> lstIntNoType = new List<Int32>();

            // requete sql
            String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String maRequeteSQL = "select NoTypeChambre from TypeChambre";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();

            if (monReader.HasRows) // monreader n'est pas vide
            {
                while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
                {
                    // L'index peut être un numéro de colonne ou le nom d'une colonne
                    //Console.WriteLine(monReader["empNo"] + ", " + monReader["empNom"] + ", " + monReader[2]);

                    lstIntNoType.Add(monReader.GetInt32(0));
                }
            }
            else // monreader est vide
            {
                blnIntNoTypeTrouve = false;
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            maConnexion.Close();
            // fin de la requete sql

            if (blnIntNoTypeTrouve)
            {
                lstIntNoType.Sort();

                int intStartingValue = 1,
                    intEndingValue = lstIntNoType[lstIntNoType.Count - 1],
                    intIncrement = 1;

                var intMissing = Enumerable.
                                    Range(0, (intEndingValue - intStartingValue) / intIncrement + 1).
                                    Select(i => i * intIncrement + intStartingValue).
                                    Except(lstIntNoType);

                if (intMissing.Count() != 0) // get le premier nb qui manque
                    intNoType = intMissing.First();
                else // aucun nombre ne manque, so get le dernier nb + 1
                    intNoType = lstIntNoType[lstIntNoType.Count - 1] + 1;
            }
            else
                intNoType = 1;

            frmAjoutModificationTypesChambres ajoutModificationTypesChambres = new frmAjoutModificationTypesChambres();

            ajoutModificationTypesChambres.intChoix = 1;

            ajoutModificationTypesChambres.strNo = intNoType.ToString();

            //ajoutModificationTypesChambres.ShowDialog();

            if (ajoutModificationTypesChambres.ShowDialog() == DialogResult.OK)
            {
                DisplayData();

                //BDTP1Bergeron_KoumaDataSet.TypeChambreRow unTypeChambre = bDTP1Bergeron_KoumaDataSet.TypeChambre.NewTypeChambreRow();

                //bDTP1Bergeron_KoumaDataSet.TypeChambre.AddTypeChambreRow(unTypeChambre);
                //typeChambreBindingSource.MoveLast();


                //bDTP1Guelleh_MarreroDataSet.Reset();
                //tableAdapterManager.Fill //Fill(bDTP1Guelleh_MarreroDataSet.TypeChambre);

                /*typeChambreDataGridView.Rows.Add(new string[] { ajoutModificationTypesChambres.strNo,
                    ajoutModificationTypesChambres.strDescription,
                    ajoutModificationTypesChambres.strPrixHaut,
                    ajoutModificationTypesChambres.strPrixBas,
                    ajoutModificationTypesChambres.strPrixMoyen});*/

                /*DataGridViewRow row = (DataGridViewRow)typeChambreDataGridView.Rows[0].Clone();
                row.Cells[0].Value = ajoutModificationTypesChambres.strNo;
                row.Cells[1].Value = ajoutModificationTypesChambres.strDescription;
                row.Cells[2].Value = ajoutModificationTypesChambres.strPrixHaut;
                row.Cells[3].Value = ajoutModificationTypesChambres.strPrixBas;
                row.Cells[4].Value = ajoutModificationTypesChambres.strPrixMoyen;

                typeChambreDataGridView.Rows.Add(row);*/
            }
        }

        private void btnModifierType_Click(object sender, EventArgs e)
        {
            frmAjoutModificationTypesChambres ajoutModificationTypesChambres = new frmAjoutModificationTypesChambres();

            ajoutModificationTypesChambres.intChoix = 2;

            dynamic clientSelectionne = typeChambreBindingSource.Current;

            ajoutModificationTypesChambres.strNo = Convert.ToString(clientSelectionne["NoTypeChambre"]);
            ajoutModificationTypesChambres.strDescription = Convert.ToString(clientSelectionne["Description"]);
            ajoutModificationTypesChambres.strPrixBas = Convert.ToString(clientSelectionne["PrixBas"]);
            ajoutModificationTypesChambres.strPrixMoyen = Convert.ToString(clientSelectionne["PrixMoyen"]);
            ajoutModificationTypesChambres.strPrixHaut = Convert.ToString(clientSelectionne["PrixHaut"]);

            //ajoutModificationTypesChambres.ShowDialog();

            if (ajoutModificationTypesChambres.ShowDialog() == DialogResult.OK)
            {
                DisplayData();

                /*typeChambreDataGridView.CurrentRow.Cells[1].Value = ajoutModificationTypesChambres.strDescription;
                typeChambreDataGridView.CurrentRow.Cells[2].Value = ajoutModificationTypesChambres.strPrixHaut;
                typeChambreDataGridView.CurrentRow.Cells[3].Value = ajoutModificationTypesChambres.strPrixBas;
                typeChambreDataGridView.CurrentRow.Cells[4].Value = ajoutModificationTypesChambres.strPrixMoyen;*/

                /*typeChambreDataGridView.Rows.Add(new string[] { ajoutModificationTypesChambres.strNo,
                    ajoutModificationTypesChambres.strDescription,
                    ajoutModificationTypesChambres.strPrixHaut,
                    ajoutModificationTypesChambres.strPrixBas,
                    ajoutModificationTypesChambres.strPrixMoyen});*/
            }
        }

        private void btnSupprimerType_Click(object sender, EventArgs e)
        {
            bool blnTypeChambreHasChambre = Convert.ToBoolean(chambreTableAdapter.getTypeChambreHasChambre(int.Parse(typeChambreDataGridView.CurrentRow.Cells[0].Value.ToString())));

            //MessageBox.Show(blnTypeChambreHasChambre.ToString());

            if (!blnTypeChambreHasChambre)
            {
                dynamic typeSelectionne = typeChambreBindingSource.Current;

                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiement supprimer le type de chambre " + Convert.ToString(typeSelectionne["NoTypeChambre"]) + " ?\n\n!!! Cette opération est irréversible !!!", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK) // suppression du type chambre
                {
                    typeChambreBindingSource.RemoveCurrent();

                    this.Validate();
                    this.typeChambreBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bDTP1Guelleh_MarreroDataSet);

                    //this.typeChambreTableAdapter.Update()
                }
            }
            else
            {
                dynamic typeSelectionne = typeChambreBindingSource.Current;

                MessageBox.Show("Le type de chambre " + Convert.ToString(typeSelectionne["NoTypeChambre"]) + " sélectionné contient des chambres \n\n!!! Veuillez les supprimer d'abord !!!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            /*String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TypeChambre", maConnexion);

            sqlDataAdapter.Fill(dataTable);
            typeChambreDataGridView.DataSource = dataTable;*/

            /*BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            typeChambreDataGridView.DataSource = bindingSource;*/

            //typeChambreDataGridView.datab

            //maConnexion.Close();
            //typeChambreDataGridView.DataSource = bDTP1Guelleh_MarreroDataSet.Tables[0];

            /*typeChambreDataGridView.Update();
            typeChambreDataGridView.Refresh();
            typeChambreDataGridView.RefreshEdit();*/
        }
    }
}
