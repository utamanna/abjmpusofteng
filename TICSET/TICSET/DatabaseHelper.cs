using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gamePlay;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    class DatabaseHelper
    {
        // Instace variables
        private string connectionString = @"Data Source=C:\Users\Usman\Documents\GitHub\abjmpusofteng\TICSET\TICSET\Users.sdf";
        private SqlCeConnection connection;
        private SqlCeCommand command;
        private SqlCeDataReader reader;

        public DatabaseHelper()
        {
            try
            {
                connection = new SqlCeConnection(connectionString);
                connection.Open();
            }
            catch (Exception error)
            {
                errorConnecting(error);
            }
        }

        private string errorConnecting(Exception e)
        {
            return "Error connecting to the database.\nHere is the Error:\n" + e.ToString();
        }

        public bool CheckLogin(string username, string password)
        {
            command = new SqlCeCommand("SELECT * FROM [user] WHERE username='" +
                                                   username + "' AND password='" +
                                                   password + "'", connection);
            reader = null;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            int isThereAMatchingRow = dataTable.Rows.Count;
            if (isThereAMatchingRow == 1)
            {
                return true;
            }
            return false;
        }

        public string getUsersFullName(string username)
        {
            string users_full_name = "";
            command = new SqlCeCommand("SELECT first_name, last_name FROM [user] WHERE username='" +
                                                            username + "'", connection);

            reader = null;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            int isThereAMatchingRow = dataTable.Rows.Count;
            if (isThereAMatchingRow == 1)
            {
                DataRow row = dataTable.Rows[0];
                users_full_name = row["first_name"].ToString();
                users_full_name += " " + row["last_name"].ToString();
                return users_full_name;
            }
            else
            {
                return "User not found";
            }

        }

        public bool insertUserinUserTable(string first_name, string last_name, string username, string password)
        {
            try
            {
                using (SqlCeCommand command = new SqlCeCommand("INSERT INTO [user] (first_name, last_name, username, password) VALUES (@first_name, @last_name, @username, @password)", connection))
                {
                    command.Parameters.AddWithValue("@first_name", first_name);
                    command.Parameters.AddWithValue("@last_name", last_name);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool insertUserinStatisticTable(string username)
        {
            try
            {
                using (SqlCeCommand command = new SqlCeCommand("INSERT INTO [statistics] (username, wins, losses) VALUES (@username, @wins, @losses)", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@wins", 0);
                    command.Parameters.AddWithValue("@losses", 0);

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception error)
            {
                return false;
            }
        }

        //nt isThereAMatchingRow = dataTable.Rows.Count;
        //    if (isThereAMatchingRow == 1)
        //    {
        //        DataRow row = dataTable.Rows[0];
        //        users_full_name = row["first_name"].ToString();
        //        users_full_name += " " + row["last_name"].ToString();
        //        return users_full_name;
        //    }
        public string Leaderboard()
        {
            string leaderboard_string = "";
            try
            {
                using( SqlCeCommand command = new SqlCeCommand("SELECT username, wins, losses FROM [statistics] ORDER BY wins ASC", connection))
                {
                    reader = null;
                    reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    DataTable sortedTable = new DataTable();
                    dataTable.Load(reader);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        leaderboard_string = "\t\t";
                        leaderboard_string += row["username"].ToString();
                        leaderboard_string += "\t\t";
                        leaderboard_string += row["wins"].ToString();
                        leaderboard_string += "\t\t";
                        leaderboard_string += row["losses"].ToString();
                        leaderboard_string += "\n";

                    }

                    return leaderboard_string;
                   
                }
            }
            catch(Exception e)
            {
                return "No Data Available.";
            }
            
        }

        public void score(Player player_one, Player player_two, char who_won)
        {
            string player_one_username, player_two_username;
            player_one_username = player_one.getID(); // Get player one username
            player_two_username = player_two.getID(); // Get player two username

            // Update player one wins/losses based
            // on if they won or lost
            if (player_one.getGamePiece() == who_won)
            {
                // Code to increment player one's wins
            }
            else
            {
                // Code to increment player one's losses
            }

            // Update player one wins/losses based
            // on if they won or lost
            if (player_two.getGamePiece() == who_won)
            {
                // Code to imcrement player two's wins
            }
            else
            {
                // Code to increment player two's losses
            }
        }

        public void Close()
        {
            connection.Close();
        }



    }

    
}
