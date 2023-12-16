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
        public List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "SELECT SongId, Title, Artist, FilePath, ImagePath FROM Songs";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Song song = new Song
                        {
                            SongID = (int)dataReader["SongId"],
                            Title = dataReader["Title"].ToString(),
                            Artist = dataReader["Artist"].ToString(),
                            FilePath = dataReader["FilePath"].ToString(),
                            ImagePath = dataReader["ImagePath"].ToString(),
                        };

                        songs.Add(song);
                    }
                }
            }

            return songs;
        }
    }
}
