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
        public FrmEmploye()
        {
            InitializeComponent();
            RemplirListView();
        }

        private void RemplirListView()
        {
            List<Employé> lstEmploye = Employé.ChargerTousLesEmployes();

            foreach (Employé employeCourant in lstEmploye)
            {
                ListViewItem nouvItem = new ListViewItem(employeCourant.nom + ", " + employeCourant.Prenom);
                nouvItem.SubItems.Add("");
                nouvItem.SubItems.Add("");
                nouvItem.SubItems.Add(employeCourant.Courriel);
                nouvItem.SubItems.Add(employeCourant.Telephone);
                
                string adresse = employeCourant.NumeroRue + " " + employeCourant.Rue + ", " + employeCourant.ville;
                nouvItem.SubItems.Add(adresse);

                lsvListeJoueur.Items.Add(nouvItem);
            }
        }
    }
}
