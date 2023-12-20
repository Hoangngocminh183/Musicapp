using Sign_upform;
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
            string query = "SELECT SongID, Title, Artist, FilePath, ImagePath, SongCode FROM Songs ORDER BY SongCode DESC";

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

    }
}
