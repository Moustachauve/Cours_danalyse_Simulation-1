using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_de_go_Senthé
{
    public class Employé:Personne
    {
      
        #region CHAMPS & PROPRIÉTÉ
        
        private bool m_estSuperEmploye;
        
        public bool EstSuperEmploye
        {
            get { return m_estSuperEmploye; }
        }
        
        #endregion

        #region CONSTRUCTEUR 
        public Employé(string pPrenom, string pNom, string pNumTelephone, string pAdCourriel, string pAdresse)
            : base(pPrenom, pNom, pNumTelephone, pAdCourriel, pAdresse)
        {

        }
              
        #endregion

        #region MÉTHODE
        public static List<Employé> ChargerTousLesEmployes()
        {

        }

        #endregion
    }
}
