﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Windows.Data.Text;

namespace Educational_Software.Models
{
    internal class DatabaseHandler
    {
        private string connectionString = " Data Source = eduSoftwareDatabase.db ";
        public DatabaseHandler()
        {
            string createTableQuery0 = "CREATE TABLE IF NOT EXISTS " +
                        "User ( id INTEGER PRIMARY KEY, name TEXT, lastname TEXT, email TEXT, password TEXT )";
            string createTableQuery1 = "CREATE TABLE IF NOT EXISTS " +
                        "Answer ( studentId INTEGER, section INTEGER, question INTEGER, time INTEGER, rating REAL )";
            execute_query(connectionString, createTableQuery0);
            execute_query(connectionString, createTableQuery1);
        }

        public bool add_user(string name, string lastname, string email, string password)
        {
            string insertQuery = $"INSERT INTO User (name, lastname, email, password) VALUES ('{name}', '{lastname}', '{email}', '{password}')";
            return execute_query(connectionString, insertQuery);
        }

        public bool add_answer(int studentId, int section, int question, int time, double rating)
        {
            string insertQuery = $"INSERT INTO Answer (studentId, section, question, time, rating) VALUES ({studentId}, {section}, {question}, {time}, {rating})";
            return execute_query(connectionString, insertQuery);
        }

        private bool execute_query(string connectionString, string query){
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteCommand com = connection.CreateCommand();
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return false;
            }
        }

        public List<User> get_user(string email, string password)
        {
            string selectQuery = $"SELECT * FROM User WHERE email = '{email}' AND password = '{password}'";
            List<User> users = new List<User>();
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteCommand com = connection.CreateCommand();
                    com.CommandText = selectQuery;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        users.Add(
                            new User(
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["lastname"].ToString(),
                            reader["email"].ToString(),
                            reader["password"].ToString()
                            )
                        );
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
            return users;
        }

        public List<Answer> get_answers(int studentId)
        {
            string selectQuery = $"SELECT * FROM Answer WHERE studentId = {studentId}";
            List<Answer> answers = new List<Answer>();
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteCommand com = connection.CreateCommand();
                    com.CommandText = selectQuery;
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        answers.Add(
                            new Answer(
                            Convert.ToInt32(reader["studentId"]),
                            Convert.ToInt32(reader["section"]),
                            Convert.ToInt32(reader["question"]),
                            Convert.ToInt32(reader["time"]),
                            Convert.ToSingle(reader["rating"])
                            )
                        );
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"SQLite Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
            return answers;
        }
    }
}
