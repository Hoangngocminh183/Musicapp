﻿using Sign_upform;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_upform
{
    internal class Modify
    {
        SqlCommand sqlCommand;// Dùng để truy vấn insert, update, delete,...
        SqlDataReader dataReader; // Dùng để đọc dữ liệu trong bảng 
        public Modify()
        {

        }
        public List<Users> User(string query)
        {
            List<Users> users = new List<Users>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    users.Add(new Users(dataReader.GetString(0), dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
            return users;
        }
        public void Command(string query) // dùng để đăng kí tài khoản 
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn 
                sqlConnection.Close();
            }
        }
        public List<Music> GetMusicList()     
        {
            List<Music> musicList = new List<Music>();
            string query = "SELECT SongID, Title, Artist, FilePath, ImagePath FROM Songs"; // Thay thế bằng tên bảng thực tế của bạn

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Music music = new Music
                    {
                        SongID = dataReader.GetInt32(0),
                        Title = dataReader.GetString(1),
                        Artist = dataReader.GetString(2),
                        FilePath = dataReader.GetString(3),
                        ImagePath = dataReader.GetString(4),
                 
                    };

                    musicList.Add(music);
                }

                sqlConnection.Close();
            }

            return musicList;
        }
        public List<Music> GetNewReleases()
        {
            List<Music> newReleases = new List<Music>();
            string query = "SELECT SongID, Title, Artist, FilePath, ImagePath, SongCode FROM Songs ORDER BY CASE WHEN ISNUMERIC(SongCode) = 1 THEN CAST(SongCode AS INT) ELSE 999999 END DESC, SongID DESC";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Music music = new Music
                    {
                        SongID = dataReader.GetInt32(0),
                        Title = dataReader.GetString(1),
                        Artist = dataReader.GetString(2),
                        FilePath = dataReader.GetString(3),
                        ImagePath = dataReader.GetString(4),
                        SongCode = dataReader.GetString(5),
                    };

                    newReleases.Add(music);
                }

                sqlConnection.Close();
            }

            return newReleases;
        }
        public List<Music> SearchMusic(string searchText)
        {
            List<Music> searchResults = new List<Music>();
            string query = "SELECT SongID, Title, Artist, FilePath, ImagePath FROM Songs WHERE UPPER(Title) LIKE UPPER('%' + @searchText + '%')";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Music music = new Music
                    {
                        SongID = dataReader.GetInt32(0),
                        Title = dataReader.GetString(1),
                        Artist = dataReader.GetString(2),
                        FilePath = dataReader.GetString(3),
                        ImagePath = dataReader.GetString(4),
                    };

                    searchResults.Add(music);
                }

                sqlConnection.Close();
            }

            return searchResults;
        }
        public List<Music> SearchMusicByArtist(string searchText)
        {
            List<Music> searchResults = new List<Music>();
             string query = "SELECT Artist, ImageArtits FROM Followers WHERE UPPER(Artist) LIKE UPPER(@searchText)";
           /* string query = "SELECT F.SongID, S.Title, F.Artist, S.FilePath, S.ImagePath, F.ImageArtits " +
               "FROM Followers F " +
               "JOIN Songs S ON F.SongID = S.SongID " +
               "WHERE UPPER(F.Artist) LIKE UPPER(@searchText)";*/

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Music music = new Music
                    {
                        Artist = dataReader.GetString(0),
                        ImageArtits = dataReader.GetString(1),
                    };

                    searchResults.Add(music);
                }

                sqlConnection.Close();
            }

            return searchResults;
        }
        public List<Music> GetControlsByArtist(string artistName)
    {
        List<Music> artistControls = new List<Music>();
        string query = "SELECT SongID, Title, Artist, FilePath, ImagePath FROM Songs WHERE UPPER(Artist) LIKE UPPER(@artistName)";

        using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@artistName", "%" + artistName + "%");
            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Music music = new Music
                {
                    SongID = dataReader.GetInt32(0),
                    Title = dataReader.GetString(1),
                    Artist = dataReader.GetString(2),
                    FilePath = dataReader.GetString(3),
                    ImagePath = dataReader.GetString(4),
                };

                artistControls.Add(music);
            }

            sqlConnection.Close();
        }

        return artistControls;
    }
        public void UpdateFollowerCount(string artistName, int newFollowerCount)
        {
            string query = "UPDATE Followers SET Follower = @newFollowerCount WHERE Artist = @artistName";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@newFollowerCount", newFollowerCount);
                sqlCommand.Parameters.AddWithValue("@artistName", artistName);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public int GetFollowerCount(string artistName)
        {
            int followerCount = 0;
            string query = "SELECT Follower FROM Followers WHERE Artist = @artistName";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@artistName", artistName);
                object result = sqlCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out followerCount))
                {
                    // Số lượng người theo dõi đã được lấy thành công
                }

                sqlConnection.Close();
            }

            return followerCount;
        }
        public List<Music> GetTopArtists()
        {
            List<Music> topArtists = new List<Music>();
            string query = "SELECT Artist, ImageArtits, Follower FROM Followers ORDER BY Follower DESC";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Music artist = new Music
                    {
                        Artist = dataReader.GetString(0),
                        ImageArtits = dataReader.GetString(1),
                        Follower = dataReader.GetInt32(2).ToString()
                    };

                    topArtists.Add(artist);
                }

                sqlConnection.Close();
            }

            return topArtists;
        }
    }
}
