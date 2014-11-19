using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_de_go_Senthé
{
    public partial class FrmEmploye : Form
    {

        private FrmAjouterJoueur frmAjouterJoueur;

        public FrmEmploye()
        {
            InitializeComponent();
            RemplirListView();
        }

        private void RemplirListView()
        {
            lsvListeJoueur.Items.Clear();
            List<Joueur> lstJoueurs = Joueur.ChargerTousLesJoueurs();

            foreach (Joueur joueurCourant in lstJoueurs)
            {
                ListViewItem nouvItem = new ListViewItem(joueurCourant.nom + ", " + joueurCourant.Prenom);
                nouvItem.SubItems.Add(joueurCourant.NoMembre);
                nouvItem.SubItems.Add(joueurCourant.Rang);
                nouvItem.SubItems.Add(joueurCourant.Courriel);
                nouvItem.SubItems.Add(joueurCourant.Telephone);
                
                string adresse = joueurCourant.NumeroRue + " " + joueurCourant.Rue + ", " + joueurCourant.ville;
                nouvItem.SubItems.Add(adresse);

                lsvListeJoueur.Items.Add(nouvItem);
            }
        }

        private void ajouterUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterJoueur = new FrmAjouterJoueur();
            frmAjouterJoueur.JoueurAjouter += MembreAjouter_frmAjouterMembre;
            frmAjouterJoueur.ShowDialog();
        }

        private void MembreAjouter_frmAjouterMembre(object sender, EventArgs e)
        {
            RemplirListView();
        }
    }
}
