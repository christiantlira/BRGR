using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace freelaProject.Class.Connection
{
    class Connectionsql
    {
        public static string vStrConnection = string.Empty;

        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;

        public static string v_server = string.Empty;
        public static string v_port = string.Empty;
        public static string v_username = string.Empty;
        public static string v_password = string.Empty;
        public static string v_dbname = string.Empty;

        public string ReadXml()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.StartupPath + "\\connection.xml");

            XmlNode Node;
            Node = xmlDoc.DocumentElement;

            foreach (XmlNode n in Node.ChildNodes)
            {
                if (n.Name == "server")
                {
                    v_server = n.InnerText;
                }
                else if (n.Name == "port")
                {
                    v_port = n.InnerText;
                }
                else if (n.Name == "user")
                {
                    v_username = n.InnerText;
                }
                else if (n.Name == "password")
                {
                    v_password = n.InnerText;
                }
                else if (n.Name == "dbname")
                {
                    v_dbname = n.InnerText;
                }


            }

            vStrConnection = $"Server= {v_server}; port= {v_port}; user id={v_username}; password= {v_password}; database= {v_dbname}";

            return vStrConnection;
        }

        private void Connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;
            if (vCon.State == System.Data.ConnectionState.Closed)
            {
                vCon.Open();
            }
        }

        public DataTable getData(string sql)
        {
            ReadXml();
            DataTable dt = new DataTable();
            Connection();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
    }
}