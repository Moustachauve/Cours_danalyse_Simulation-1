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
        private string m_Telephone;
        public string Telephone
        {
            get { return m_Telephone; }
            set { m_Telephone = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        ///retourne le numéro de Rue de la personne
        /// </summary>
        private int m_numeroRue;
        public int NumeroRue
        {
            get { return m_numeroRue; }
            set { NumeroRue = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        ///retourne le nom de la rue de la personne
        /// </summary>
        private string m_rue;
        public string Rue
        {
            get { return m_rue; }
            set { m_rue = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retourne le nom de la ville de la personne 
        /// </summary>
        private string m_ville;
        public string ville
        {
            get { return m_ville; }
            set { m_ville = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retoune une adresse courriel (facultatif) d'une personne en cas de besoin
        ///</summary>
        private string m_Courriel;
        public string Courriel
        {
            get { return m_Courriel; }
            set { m_Courriel = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        /// retourne le mot de passe de la personne pour se connecter 
        /// </summary>
        private string m_motDePasse;
        public string MotDePasse
        {
            get { return m_motDePasse; }
            set { m_motDePasse = value; }
        }
        ///------------------------------------------------------------------------
        ///<summary>
        ///retourne le nom d'utilisateur de la personne pour se connecter
        /// </summary>
        private string m_nomUtilisateur;
        public string NomUtilisateur
        {
            get { return m_nomUtilisateur; }
            set { m_nomUtilisateur = value; }
        }
        #endregion

        #region CONSTRUCTEUR 
        ///<summary>
        /// retourne les données nécessaires pour instancier un objet abstrait Personne 
        /// avec un prénom,Nom, NumTel, une adresse courriel et une adresse physique 
        ///</summary>
        public Personne(string pPrenom, string pNom, string pTelephone, int pNumeroRue, string pRue,string pVille,string pCourriel, string pMotDePasse,string pNomUtilisateur)
        {
            m_prenom = pPrenom;
            m_nom = pNom;
            m_Telephone = pTelephone;
            m_numeroRue = pNumeroRue;
            m_rue = pRue;
            m_ville = pVille;
            m_Courriel = pCourriel;
            m_motDePasse = pMotDePasse;
            m_nomUtilisateur = pNomUtilisateur;
        }
        #endregion
    }
}
