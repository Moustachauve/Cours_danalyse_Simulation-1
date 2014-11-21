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
    public partial class FrmAjouterJoueur : Form
    {

        public EventHandler<EventArgs> JoueurAjouter;

        public FrmAjouterJoueur()
        {
            InitializeComponent();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                Joueur.AjouterUnJoueur(txtPrenom.Text, txtNom.Text, txtTelephone.Text, int.Parse(txtNoCivique.Text), txtRue.Text, txtVille.Text, txtCourriel.Text, txtMotDePasse.Text, txtNomUtilisateur.Text, txtRang.Text, txtNoMembre.Text);

                if (JoueurAjouter != null)
                    JoueurAjouter(this, null);

                this.Close();
            }
        }

        private bool ValidateInput()
        {
            int nbValide = 0;

            foreach (var item in this.Controls[0].Controls)
            {
                if(item is UserControl1)
                {
                    if (((UserControl1)item).ValiderTexte())
                        nbValide++;
                }
            }

            if (txtTelephone.MaskFull)
                nbValide++;
            else
                errorProvider1.SetError(txtTelephone, "Le téléphone ne peut pas être vide.");

            return nbValide == 10;
        }
    }
}
