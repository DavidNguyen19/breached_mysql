using System;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.CRUD;
//HACK: to use MySQL.Data nuget, install Connector/NET here: https://dev.mysql.com/downloads/connector/net/

namespace LIbrary
{
    public class DataStoreLoggingDAO : MasterNOSQLDAO<string>
    {

        public override void Create(string password)
        {
            Session session = MySQLX.GetSession(ConnectionString);

            Schema schema = session.GetSchema(Schema);

            var collection = schema.CreateCollection("passwords", ReuseExistingObject: true);

            // Created anon type to represent json in document store.
            var document = new
            {
                password = password
            };

            collection.Add(document).Execute();
            session.Close();
        }
    }
}