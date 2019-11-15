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
    public partial class frmAjoutModificationTypesChambres : Form
    {
        public int intChoix;

        public string strNo, strDescription, strPrixBas, strPrixHaut, strPrixMoyen;

        public frmAjoutModificationTypesChambres()
        {
            InitializeComponent();
        }

        private void frmAjoutModificationTypesChambres_Load(object sender, EventArgs e)
        {
            if (intChoix == 1)
            {
                this.Text = "Ajout d'un nouveau type";

                label1.Text = "Ajout d'un nouveau type";

                gbPlaceholder.Text = "Ajouter le nouveau type";

                btnPlaceholderEnregistrer.Text = "Ajouter le type";

                tbNo.Text = strNo;
            }
            else if (intChoix == 2)
            {
                this.Text = "Modification du type";

                label1.Text = "Modification du type";

                gbPlaceholder.Text = "Modifier ce type";

                btnPlaceholderEnregistrer.Text = "Modifier ce type";

                tbNo.Text = strNo;
                tbDescription.Text = strDescription;
                numPrixBas.Value = Convert.ToDecimal(strPrixBas);
                numPrixMoyen.Value = Convert.ToDecimal(strPrixMoyen);
                numPrixHaut.Value = Convert.ToDecimal(strPrixHaut);
            }
        }


        private void btnPlaceholderEnregistrer_Click(object sender, EventArgs e)
        {
            errMsgTypes.Clear();

            bool blnError = false;

            if (tbDescription.Text.Trim() == "")
            {
                errMsgTypes.SetError(tbDescription, "Ce champ ne peut pas être vide");

                blnError = true;
            }

            // aucune erreur
            if (!blnError)
            {
                if (intChoix == 1)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        // insert into TypeChambre values (3, 'test', 10, 10, 10)

                        String maRequeteSQL = "insert into TypeChambre values (" +
                                                tbNo.Text.Trim() + ", '" +
                                                tbDescription.Text.Trim() + "', '" +
                                                numPrixHaut.Value.ToString().Replace(",", ".") + "', '" +
                                                numPrixMoyen.Value.ToString().Replace(",", ".") + "', '" +
                                                numPrixBas.Value.ToString().Replace(",", ".") + "')";

                        SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                        maCommande.Transaction = maTransaction;

                        maCommande.ExecuteNonQuery();
                        maTransaction.Commit();
                    }
                    catch
                    {
                        maTransaction.Rollback();
                        MessageBox.Show("Transaction échouée");
                    }

                    maConnexion.Close(); // Fermer la connexion

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
                else if (intChoix == 2)
                {
                    String maChaineDeConnexion = Projet1BaseDeDonnee3.Properties.Settings.Default.BDTP1Guelleh_MarreroConnectionString;
                    SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                    maConnexion.Open();

                    SqlTransaction maTransaction = maConnexion.BeginTransaction();

                    try
                    {
                        // update TypeChambre set Description='test2', PrixHaut=100, PrixBas=100, PrixMoyen=100 where NoTypeChambre=3

                        String maRequeteSQL = "update TypeChambre set Description='" + tbDescription.Text.Trim() +
                                                "',PrixHaut='" + numPrixHaut.Value.ToString().Replace(",", ".") +
                                                "',PrixBas='" + numPrixBas.Value.ToString().Replace(",", ".") +
                                                "',PrixMoyen='" + numPrixMoyen.Value.ToString().Replace(",", ".") +
                                                "' where NoTypeChambre='" + tbNo.Text.Trim() + "'";

                        MessageBox.Show(maRequeteSQL);

                        SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                        maCommande.Transaction = maTransaction;

                        maCommande.ExecuteNonQuery();
                        maTransaction.Commit();
                    }
                    catch
                    {
                        maTransaction.Rollback();
                        MessageBox.Show("Transaction échouée");
                    }

                    maConnexion.Close(); // Fermer la connexion

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
