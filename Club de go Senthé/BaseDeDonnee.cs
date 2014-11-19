using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Club_de_go_Senthé
{
    static public class BaseDeDonnee
    {

        private static SqlConnection m_sqlConnection;

        static public SqlConnection SqlConnection
        {
            get
            {
                if (BaseDeDonnee.m_sqlConnection == null)
                    m_sqlConnection = new SqlConnection("Data Source=ed4sql2.laboratoire.collegeem.qc.ca; Initial Catalog=e306_A14_Sim_e02;User ID=vduval;Pwd=speciale4_");

                return m_sqlConnection;
            }
        }
    }
}
