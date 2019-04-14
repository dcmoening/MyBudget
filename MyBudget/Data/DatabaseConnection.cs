using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyBudget
{
    public class DatabaseConnection
    {
        #region fields
        public MySqlConnection conn;
        public MySqlCommand cmd;
        private ErrorNotify errorNotify;
        private String connStr;
        #endregion
        private static String ReturnConnectionString()
        {
            //Connect Timeout=30
            string connString = "server=" + ConfigurationManager.AppSettings["server"].ToString() + ";" +
                                     "user=" + ConfigurationManager.AppSettings["user"].ToString() + ";" +
                                     "database=" + ConfigurationManager.AppSettings["database"].ToString() + ";" +
                                     "port=" + ConfigurationManager.AppSettings["port"].ToString() + ";" +
                                     "password=" + ConfigurationManager.AppSettings["password"] + ";"+
                                     "Connect Timeout=" + ConfigurationManager.AppSettings["timeout"] + ";";
            return connString;
        }

        public int OpenDBConnection()
        {
            
            int errNbr = 0;
            try
            {
                connStr = ReturnConnectionString();
                conn = new MySqlConnection(connStr);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                //TODO add better error catching.
                errNbr = 1;
            }
            return errNbr;
        }
        public int CheckDBConnection()
        {
            bool isConnected = false;
            int errNbr = -1;
            const int tryNbrTimes = 3;
            int nbrTimesTried = 0;
            
            while ((nbrTimesTried < tryNbrTimes) || !isConnected)
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        OpenDBConnection();
                    }
                    else
                    {
                        isConnected = true;
                        errNbr = 0;
                    }
                }
                catch
                {
                    OpenDBConnection();
                }
                    
                nbrTimesTried++;
            }
            if(isConnected == false)
            {
                errNbr = -1;
            }
            
            return errNbr;
        }

        public void CloseConnection()
       {
            conn.Close();
        }
    }
}
