using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            List<Employé> listeEmployé = new List<Employé>();
            SqlConnection Connection = BaseDeDonnee.SqlConnection;
            Connection.Open();

            SqlCommand CommandeSQL = Connection.CreateCommand();
            CommandeSQL.CommandText = "SELECT * FROM dbo.Personne";
            SqlDataReader resultatSQL = CommandeSQL.ExecuteReader();
            listeEmployé.Clear();
            while (resultatSQL.Read())
            {
                Employé employe = new Employé(resultatSQL["prenom"].ToString(), resultatSQL["nom"].ToString(), resultatSQL["numTelephone"].ToString(), resultatSQL["Adresse Courriel "].ToString(), resultatSQL["Adresse"].ToString());
                listeEmployé.Add(employe);
                resultatSQL.Close();
            }
            return listeEmployé;
        }

        #endregion
    }
}
