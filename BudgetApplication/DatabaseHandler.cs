using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BudgetApplication
{
    class DatabaseHandler
    {
        // Holds our connection with the database
        SQLiteConnection m_dbConnection;


        public DatabaseHandler()
        {
            connectToDatabase();

        }

        // Creates an empty database file
        public void createNewDatabase()
        {
            SQLiteConnection.CreateFile("budgetdatabase.sqlite");
        }

        // Creates a connection with our database file.
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection = new SQLiteConnection("Data Source=budgetdatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }
        public void createTable(string nameoftable,string tablecolumns)
        {
            string sql = String.Format("create table {0} ({1})",nameoftable, tablecolumns );
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        public void insertdata(string nameoftable, string columns, string values)
        {
            string sql = String.Format("insert into {0} ({1}) values ({2})", nameoftable, columns, values);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
         }

        public void retrivedata(string tablename)
        {
            string sql = String.Format("select * from {0}", tablename);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["number"]);
            Console.ReadLine();
        }
    }
}
