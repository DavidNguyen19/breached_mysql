using System;

namespace LIbrary
{
    public abstract class MasterNOSQLDAO<T>
    {
        // HACK: Change this to your specific password
        protected static readonly string ConnectionString = "mysqlx://root:****@localhost:33060";

        protected static readonly string Schema = "corrupted_passwords";

        public abstract void Create(string password);

    }
}
