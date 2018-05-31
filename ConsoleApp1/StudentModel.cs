using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    public class StudentModel
    {
        private const string ServerName = "localhost";
        private const string DatabaseName = "student_manager";
        private const string Username = "root";
        private const string Password = "";

        public void Save(Student student)
        {
            var cnnString = $"Server={ServerName};Database={DatabaseName};Uid={Username};Pwd={Password};SslMode=none";
            MySqlConnection connection = new MySqlConnection(cnnString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(
                "insert into students (rollNumber, name, email, phone) values (@val1, @val2, @val3, @val4)",
                connection);
            cmd.Parameters.AddWithValue("@val1", "A0024");
            cmd.Parameters.AddWithValue("@val2", "Xuan Dao");
            cmd.Parameters.AddWithValue("@val3", "Linh Dao");
            cmd.Parameters.AddWithValue("@val4", "Xuan Dao");

            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Chạy đến đây rồi");
        }

        public List<Student> GetList()
        {
            var list = new List<Student>();
            return list;
        }
    }
}