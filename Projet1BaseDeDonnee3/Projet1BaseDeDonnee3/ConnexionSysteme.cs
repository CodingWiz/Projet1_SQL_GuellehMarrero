﻿using System;
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
    public partial class ConnexionSysteme : Form
    {
        MenuAdmin menuAdmin = new MenuAdmin();
        MenuPrepose menuPrepose = new MenuPrepose();

        public ConnexionSysteme()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection maConnexion = new SqlConnection();
            SqlCommand maCommande;

            maConnexion.ConnectionString = Projet1BaseDeDonnee3.Properties.Settings.Default.BDVoyagesGuellehConnectionString; //maChaineDeConnexion;
            maConnexion.Open();
            
            string strRequeteNoTypeUSer = "select NoTypeUtilisteur from Utilisateur where NomUtilisateur='" + tbUtilisateur.Text + "' and MotDePasse ='" + tbMotDePasse.Text + "'";

            maCommande = new SqlCommand(strRequeteNoTypeUSer, maConnexion);

            dynamic dynNoTypeUser = maCommande.ExecuteScalar();

            string strNoTypeUser = Convert.ToString(dynNoTypeUser);


            if (tbUtilisateur.Text == "" && tbMotDePasse.Text == "")
            {
                MessageBox.Show("Vous devez inserer un utilisateur et un mot de passe pour continuer");
            }

            else if (tbUtilisateur.Text == "")
            {
                MessageBox.Show("Vous devez inserer un utilisateur pour continuer");
            }
            else if (tbMotDePasse.Text == "")
            {
                MessageBox.Show("Vous devez inserer un mot de passe pour continuer");
            }
            else
            {
                if (strNoTypeUser == null)
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe n'existe pas dans la base de données");
                }
                else
                {
                    if (dynNoTypeUser == 1)
                    {
                        this.Hide();
                        menuAdmin.ShowDialog();
                        this.Show();
                    }
                    else if (dynNoTypeUser == 2)
                    {
                        this.Hide();
                        menuPrepose.ShowDialog();
                        this.Show();
                    }
                }
            }

            maConnexion.Close();
        }
    }
}