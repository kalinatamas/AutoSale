using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSale
{
    public class Connenct
    {
        public MySqlConnection Connection;
        private string Host;
        private string Database;
        private string User;
        private string Password;
        private string ConnectionString;

        public Connenct()
        {
            Host = "127.0.0.1";
            Database = "autos";
            User = "root";
            Password = "";
            
                
            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";
            Connection = new MySqlConnection(ConnectionString);
        }
        
    }
}
