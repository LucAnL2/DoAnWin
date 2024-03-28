using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Markup;
using System.IO;
namespace DemoWin
{
    public class Connection
    {
        //private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DemoWin;Integrated Security=True";
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=theGioiTho;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        public DataTable Load(string sqlStr)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                    DataTable dtperson = new DataTable();
                    adapter.Fill(dtperson);
                    return dtperson;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return null;
        }
        public void ThucThi(string sqlStr, string successMessage, Person newperson)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, connection);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(successMessage);
                        CreateFileData(newperson.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại: " + ex.Message);
            }
            finally
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Close();
                }    
                    
            }
        }
        
        public void ThucThi(string sqlStr)
        {
            try
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, connection);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thao tác thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại: " + ex.Message);
            }
            finally
            {
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Close();
                }

            }
        }
        public void CreateFileData(string id)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            try
            {
                string defaultFolderPath = root + "\\DataUser\\";
                string defaultFilePath = Path.Combine(defaultFolderPath, id + ".txt");
                if (File.Exists(defaultFilePath))
                {
                    MessageBox.Show("Default file already exists.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                using (StreamWriter writer = new StreamWriter(defaultFilePath))
                {
                    //writer.WriteLine("");
                }
                MessageBox.Show("Default text file created successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
