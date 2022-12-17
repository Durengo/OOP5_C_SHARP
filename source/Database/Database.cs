using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://morgantechspace.com/2014/05/How-to-Store-and-Retrieve-Image-in-SQL-Server-Database.html
// https://stackoverflow.com/questions/3548401/how-to-save-image-in-database-using-c-sharp
// https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/create-sql-server-database-programmatically

// https://zetcode.com/csharp/sqlite/
// https://www.devart.com/dotconnect/sqlite/docs/Devart.Data.SQLite~Devart.Data.SQLite.SQLiteDataReader.html

// NOT ABSTRACT IMPLEMENTATION.

namespace OOP5.source.Database
{
    using System.Data.SQLite;

    public class Database
    {
        // master_sqlite db name
        private String DbName;

        // sqlite instance
        private SQLiteConnection Connection = null;
        private bool ConnectionStatus = false;

        // Debugging variable
        private String ConnectionSuccessText = "OK!";

        // Debugging variable
        private Exception ConnectionError = null;

        // Debugging variable
        private string SQLVersion = "";

        public Database(string dbName)
        {
            DbName = dbName;
            SQLiteConnection.CreateFile(dbName);
            //string ConnectionParameters = "Data Source=:memory:";
            string ConnectionParameters = "Data Source=" + dbName + ".sqlite";

            try
            {
                Connection = new SQLiteConnection(ConnectionParameters);
                GenerateVersion();
                ConnectionStatus = true;
                ConnectionSuccessText = "CONNECTION ESTABLISHED!";
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
            }
        }

        ~Database()
        {
            // TODO: If(DeleteDatabase)
            // Connection.Dispose();
            // System.Data.SQLite.SQLiteConnection.ClearAllPools();
            // File.Delete(DbName);
        }

        // Simple implementation of executing an sql statement
        public void ExecuteStatement(string stmt)
        {
            SQLiteCommand cmd = Connection.CreateCommand();
            try
            {
                OpenConnection();
                cmd.CommandText = stmt;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
        }

        public void CreateTable(string tableName, string stmt)
        {
            string newStmt = "CREATE TABLE IF NOT EXISTS " + tableName + "(" + stmt + ");";
            //string newStmt = "CREATE TABLE " + DbName + "." + tableName + "(" + stmt + ");";

            ExecuteStatement(newStmt);
        }

        public void InsertItem(string tableName, string tableValues, string stmt)
        {
            string newStmt =
                "INSERT INTO "
                + tableName
                + "("
                + tableValues
                + ")"
                + " VALUES "
                + "("
                + stmt
                + ");";
            ExecuteStatement(newStmt);
        }

        // Selects a record (object) and returns a list of string. The amount of elements in the string depend on the 'tableValues' argument.
        public List<string> SelectItem(string tableName, string tableValues, string stmt)
        {
            List<string> selection = new List<string>();
            SQLiteCommand cmd = Connection.CreateCommand();
            SQLiteDataReader reader;
            try
            {
                cmd.CommandText =
                    "SELECT " + tableValues + " FROM " + tableName + " WHERE " + stmt + ";";
                OpenConnection();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item = reader.GetValue(i).ToString();

                        selection.Add(item);
                    }
                }

                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return selection;
        }

        // Selects a single variable from every record.
        public List<string> SelectAllOneValue(string tableName, string tableValue)
        {
            List<string> selection = new List<string>();
            SQLiteCommand cmd = Connection.CreateCommand();
            SQLiteDataReader reader;
            try
            {
                cmd.CommandText = "SELECT " + tableValue + " FROM " + tableName + ";";
                OpenConnection();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item = reader.GetValue(i).ToString();

                        selection.Add(item);
                    }
                }

                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return selection;
        }

        // Selects a single variable from every record where a stmt equals to a specified value.
        public List<string> SelectAllOneValueWhere(string tableName, string tableValue, string stmt)
        {
            List<string> selection = new List<string>();
            SQLiteCommand cmd = Connection.CreateCommand();
            SQLiteDataReader reader;
            try
            {
                cmd.CommandText =
                    "SELECT " + tableValue + " FROM " + tableName + " WHERE " + stmt + ";";
                OpenConnection();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item = reader.GetValue(i).ToString();

                        selection.Add(item);
                    }
                }

                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return selection;
        }

        public List<string> SelectAllOneValueWhereAndOrderBy(
            string tableName,
            string tableValue,
            string stmt,
            string orderBy
        )
        {
            List<string> selection = new List<string>();
            SQLiteCommand cmd = Connection.CreateCommand();
            SQLiteDataReader reader;
            try
            {
                cmd.CommandText =
                    "SELECT "
                    + tableValue
                    + " FROM "
                    + tableName
                    + " WHERE "
                    + stmt
                    + " ORDER BY "
                    + orderBy
                    + ";";
                OpenConnection();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        item = reader.GetValue(i).ToString();

                        selection.Add(item);
                    }
                }

                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return selection;
        }

        // TODO: remove DeleteWhere function
        public void DeleteWhere(string tableName, string tableValue, string stmt)
        {
            string newStmt =
                "DELETE FROM " + tableName + " WHERE " + tableValue + " = '" + stmt + "';";
            ExecuteStatement(newStmt);
        }

        // Better implementation of Delete Where
        public void DeleteMultipleWhere(string tableName, string stmt)
        {
            string newStmt = "DELETE FROM " + tableName + " WHERE " + stmt + ";";
            ExecuteStatement(newStmt);
        }

        // Updates a record's value.
        public void UpdateItem(string tableName, string values, string where)
        {
            string newStmt = "UPDATE " + tableName + " SET " + values + " WHERE " + where + ";";
            ExecuteStatement(newStmt);
        }

        // Count the amount of records in a table.
        public int Count(string tableName)
        {
            int count = 0;
            SQLiteCommand cmd = Connection.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM " + tableName + ";";
                OpenConnection();
                count = Convert.ToInt32(cmd.ExecuteScalar());
                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return count;
        }

        // Count the amount of records in a table where a stmt equals to a specified value.
        public int CountWhere(string tableName, string tableValue)
        {
            int count = 0;
            SQLiteCommand cmd = Connection.CreateCommand();
            try
            {
                cmd.CommandText =
                    "SELECT COUNT(*) FROM " + tableName + " WHERE " + tableValue + ";";
                OpenConnection();
                count = Convert.ToInt32(cmd.ExecuteScalar());
                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return count;
        }

        // Returns the amount of times a value repeats by specified argument.
        public int CountWhereTimes(string tableName, string tableValue, int amount)
        {
            int count = 0;
            SQLiteCommand cmd = Connection.CreateCommand();
            try
            {
                cmd.CommandText =
                    "SELECT COUNT("
                    + amount.ToString()
                    + ") FROM "
                    + tableName
                    + " WHERE "
                    + tableValue
                    + ";";
                OpenConnection();
                count = Convert.ToInt32(cmd.ExecuteScalar());
                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
            return count;
        }

        // Generates the version of the currently used sqlite version.
        private void GenerateVersion()
        {
            try
            {
                OpenConnection();
                SQLiteCommand cmd = Connection.CreateCommand();
                cmd.CommandText = "SELECT SQLITE_VERSION()";
                SQLVersion = "SQLite version: " + cmd.ExecuteScalar().ToString();
                CloseConnection();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
        }

        // Opens connection to the sqlite database.
        private void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
        }

        // Closes connection to the sqlite database.
        private void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (SQLiteException e)
            {
                ConnectionError = e;
                MessageBox.Show(ConnectionError.ToString());
            }
        }

        // Getters:
        public bool ConnectionState
        {
            get { return ConnectionStatus; }
        }
        public Exception ConnectionErr
        {
            get { return ConnectionError; }
        }
        public String ConnectionSuc
        {
            get { return ConnectionSuccessText; }
        }
        public String Version
        {
            get { return SQLVersion; }
        }
        public String Name
        {
            get { return DbName; }
        }
    }
}
