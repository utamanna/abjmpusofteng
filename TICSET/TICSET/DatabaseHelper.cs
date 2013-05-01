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
        public string[] Leaderboard()
        {
            string[] leaderboard_string = new string[6];
            string[] leaderboard_error = new string[1];
            try
            {
                using (SqlCeCommand command = new SqlCeCommand("SELECT username, wins, losses FROM [statistics] ORDER BY wins DESC", connection))
                {
                    reader = null;
                    reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    DataTable sortedTable = new DataTable();
                    dataTable.Load(reader);
                    int i = 1;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        leaderboard_string[0] += i + ".";
                        leaderboard_string[1] += row["username"].ToString() + "\n";
                        leaderboard_string[2] += row["wins"].ToString() + "\n";
                        leaderboard_string[3] += row["losses"].ToString() + "\n";
                        i++;

                    }

                    return leaderboard_string;
                   
                }
            }
            catch(Exception e)
            {
                return leaderboard_error;
            }
            
        }

        public void score(Player player_one, Player player_two, char who_won)
        {
            string player_one_username, player_two_username;
            int player_one_wins, player_one_losses, player_two_wins, player_two_losses;
            player_one_username = player_one.getID(); // Get player one username
            player_two_username = player_two.getID(); // Get player two username

            // =============================================
            // GET player one information from the database
            // =============================================
            SqlCeCommand command_for_player_one = new SqlCeCommand("SELECT username, wins, losses FROM [statistics] WHERE username='" +
                                                           player_one_username + "'", connection);

            reader = null;
            reader = command_for_player_one.ExecuteReader();
            DataTable data_table_player_one = new DataTable();
            data_table_player_one.Load(reader);
            DataRow row = data_table_player_one.Rows[0];
            player_one_wins = Convert.ToInt16(row["wins"]);
            player_one_losses =  Convert.ToInt16(row["losses"]);
            // =============================================
            // END player one information from the database
            // =============================================

            // =============================================
            // GET player two information from the database
            // =============================================
            SqlCeCommand command_for_player_two = new SqlCeCommand("SELECT username, wins, losses FROM [statistics] WHERE username='" +
                                                           player_two_username + "'", connection);

            reader = null;
            reader = command_for_player_two.ExecuteReader();
            DataTable data_table_player_two = new DataTable();
            data_table_player_two.Load(reader);
            DataRow row1 = data_table_player_two.Rows[0];
            player_two_wins = Convert.ToInt16(row1["wins"]);
            player_two_losses = Convert.ToInt16(row1["losses"]);
            // =============================================
            // END player two information from the database
            // =============================================



            // Update player one wins/losses based
            // on if they won or lost
            if (player_one.getGamePiece() == who_won)
            {
                player_one_wins++;
                using(SqlCeCommand command = new SqlCeCommand("UPDATE [statistics] SET [wins] = @wins, [losses] = @losses" +
                    " WHERE username='" + player_one_username + "'", connection))
                {
                    command.Parameters.AddWithValue("@wins", player_one_wins);
                    command.Parameters.AddWithValue("@losses", player_one_losses);

                    int rows = command.ExecuteNonQuery();
                }
            }
            else
            {
                using (SqlCeCommand command = new SqlCeCommand("UPDATE [statistics] SET [wins] = @wins, [losses] = @losses" +
                   " WHERE username='" + player_one_username + "'", connection))
                {
                    player_one_losses++;
                    command.Parameters.AddWithValue("@wins", player_one_wins);
                    command.Parameters.AddWithValue("@losses", player_one_losses);

                    int rows = command.ExecuteNonQuery();
                }
            }

            // Update player one wins/losses based
            // on if they won or lost
            if (player_two.getGamePiece() == who_won)
            {
                player_two_wins++;
                using (SqlCeCommand command = new SqlCeCommand("UPDATE [statistics] SET [wins] = @wins, [losses] = @losses" +
                    " WHERE username='" + player_two_username + "'", connection))
                {
                    command.Parameters.AddWithValue("@wins", player_two_wins);
                    command.Parameters.AddWithValue("@losses", player_two_losses);

                    int rows = command.ExecuteNonQuery();
                }
            }
            else
            {
                player_two_losses++;
                using (SqlCeCommand command = new SqlCeCommand("UPDATE [statistics] SET [wins] = @wins, [losses] = @losses" +
                    " WHERE username='" + player_two_username + "'", connection))
                {
                    command.Parameters.AddWithValue("@wins", player_two_wins);
                    command.Parameters.AddWithValue("@losses", player_two_losses);

                    int rows = command.ExecuteNonQuery();
                }
            }
        }

        public void Close()
        {
            connection.Close();
        }



    }

    
}
