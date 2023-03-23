namespace CarPartsOnlineStore.Classes
{
    using MySql.Data.MySqlClient;
    using System;

    public  class DBConfiguration
    {
        private string ConnectionString = "Server=127.0.0.1;Database=estore;Uid=root;Pwd=mysql;";
        private MySqlConnection _connection;
        private static DBConfiguration _instance;

        private DBConfiguration()
        {
            _connection = new MySqlConnection(ConnectionString);
            try
            {
                _connection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Connection to the database failed, Please try again later.");
            }
        }
        public static DBConfiguration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DBConfiguration();
                return _instance;
            }
        }
        public MySqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }
    }
}