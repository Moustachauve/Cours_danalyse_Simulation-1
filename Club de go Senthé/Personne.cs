using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_de_go_Senthé
{
    public abstract class Personne
    {
        // retourne un objet abstrait personne qui peut être un Employé ou un joueur 

        #region CHAMPS & PROPRIÉTÉ
        ///------------------------------------------------------------------------
        ///<summary>
        /// retourne le prénom d'une personne 
        ///</summary>
        private string m_prenom;
        public string Prenom
        {
            get { return m_prenom; }
            set { m_prenom = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retourne le nom d'une personne 
        ///</summary>
        private string m_nom;
        public string nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retourne le numéro de téléphone de la personne pour la contacter en cas de besoin
        ///</summary>
        private string m_numTelephone;
        public string NumTelephone
        {
            get { return m_numTelephone; }
            set { m_numTelephone = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retoune une adresse courriel (facultatif) d'une personne en cas de besoin
        ///</summary>
        private string m_addCourriel;
        public string AddCourriel
        {
            get { return m_addCourriel; }
            set { m_addCourriel = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retoune l'adresse de la personne 
        ///</summary>
        private string m_adresse;
        public string Adresse
        {
            get { return m_adresse; }
            set { m_adresse = value; }
        }
        #endregion

        #region CONSTRUCTEUR 
        ///<summary>
        /// retourne les données nécessaires pour instancier un objet abstrait Personne 
        /// avec un prénom,Nom, NumTel, une adresse courriel et une adresse physique 
        ///</summary>
        public Personne(string pPrenom, string pNom, string pNumTelephone, string pAdCourriel, string pAdresse)
        {
            m_prenom = pPrenom;
            m_nom = pNom;
            m_numTelephone = pNumTelephone;
            m_addCourriel = pAdCourriel;
            m_adresse = pAdresse;
        }
        #endregion
    }
}
