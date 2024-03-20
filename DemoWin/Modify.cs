using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DemoWin
{
    internal class Modify
    {
        public Modify() 
        { 
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }
        //public List<Person> Persons(string query)
        //{
        //    List<Person> persons = new List<Person>();
        //    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        //    {
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        dataReader = sqlCommand.ExecuteReader();
        //        while (dataReader.Read())
        //        {
        //            persons.Add(new Person(dataReader.GetString(0), dataReader.GetString(1)));
        //        }
        //        sqlConnection.Close();
        //    }
        //    return persons;
        //}
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
