﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Club_de_go_Senthé
{
    public class Joueur : Personne
    {
        static public Joueur AjouterUnJoueur(string pPrenom, string pNom, string pTelephone, int pNumeroRue, string pRue, string pVille, string pCourriel, string pMotDePasse, string pNomUtilisateur, string pRang, string pNoMembre)
        {
            int idPersonne = Personne.AjouterUnePersonne(pPrenom, pNom, pTelephone, pNumeroRue, pRue, pVille, pCourriel, pMotDePasse, pNomUtilisateur);

            SqlConnection Connection = BaseDeDonnee.SqlConnection;

            SqlCommand CommandeSQL = Connection.CreateCommand();
            CommandeSQL.CommandText = "INSERT INTO [dbo].[Joueur] ([noMembreCGA], [rang], [FK_personneID], [FK_employeID])" +
                                      "VALUES ('" + pNoMembre + "','" + pRang + "'," + idPersonne + ", 100);";
            CommandeSQL.ExecuteNonQuery();

            return new Joueur(pPrenom, pNom, pTelephone, pNumeroRue, pRue, pVille, pCourriel, pMotDePasse, pNomUtilisateur, pRang, pNoMembre);
        }

        #region CHAMPS ET PROPRIÉTÉ

        private string m_rang;
        public string Rang
        {
            get { return m_rang; }
            set
            {
                m_rang = value;
            }
        }
        private string m_noMembre;
        public string NoMembre
        {
            get { return m_noMembre; }
            set { m_noMembre = value; }
        }
        #endregion

        #region CONTRUCTEUR

        /// <summary>
        /// Instancie un nouveau joueur depuis la base de donnée
        /// </summary>
        public Joueur(string pPrenom, string pNom, string pTelephone, int pNumeroRue, string pRue, string pVille, string pCourriel, string pMotDePasse, string pNomUtilisateur, string pRang, string pNoMembre) :
            base(pPrenom, pNom, pTelephone, pNumeroRue, pRue, pVille, pCourriel, pMotDePasse, pNomUtilisateur)
        {
            m_rang = pRang;
            m_noMembre = pNoMembre;
        }



        #endregion

        #region MÉTHODE

        public static List<Joueur> ChargerTousLesJoueurs()
        {
            List<Joueur> listeJoueur = new List<Joueur>();
            SqlConnection Connection = BaseDeDonnee.SqlConnection;

            SqlCommand CommandeSQL = Connection.CreateCommand();
            CommandeSQL.CommandText = "SELECT *FROM [dbo].[Joueur] J INNER JOIN [dbo].[Personne] P ON J.FK_personneID = P.PK_personneID";
            SqlDataReader resultatSQL = CommandeSQL.ExecuteReader();

            while (resultatSQL.Read())
            {
                Joueur joueurCourant = new Joueur(resultatSQL["prenom"].ToString(), resultatSQL["nom"].ToString(), resultatSQL["telephone"].ToString(), (int)resultatSQL["numeroRue"], resultatSQL["rue"].ToString(), resultatSQL["ville"].ToString(), resultatSQL["courriel"].ToString(), resultatSQL["motDePasse"].ToString(), resultatSQL["nomUtilisateur"].ToString(), resultatSQL["rang"].ToString(), resultatSQL["noMembreCGA"].ToString());
                listeJoueur.Add(joueurCourant);
            }
            resultatSQL.Close();
            return listeJoueur;
        }

        #endregion
    }
}
