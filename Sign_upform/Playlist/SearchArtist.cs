using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sign_upform.Playlist
{
    public partial class SearchArtist : UserControl
    {
        public event EventHandler FollowClicked;
        public SearchArtist()
        {
            InitializeComponent();
        }

        public void SetData(Music music)
        {
            Artistname.Text = music.Artist;
            pictureArtist.ImageLocation = Path.GetFullPath(music.ImageArtits);
            Follwercount.Text = music.Follower;
        }
        private void labelArtist_Click(object sender, EventArgs e)
        {

        }

        private void SearchArtist_Load(object sender, EventArgs e)
        {
            string artistName = Artistname.Text;
            Modify modify = new Modify();
            int initialFollowerCount = modify.GetFollowerCount(artistName);
            Follwercount.Text = initialFollowerCount + " followers";
        }

        private void pictureArtist_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void follow_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlTransaction transaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        // Cập nhật hiển thị số lượng người theo dõi
                        int currentFollowers = int.Parse(Follwercount.Text.Split(' ')[0]);
                        currentFollowers++;
                        Follwercount.Text = currentFollowers + " followers";

                        // Cập nhật cơ sở dữ liệu với số lượng người theo dõi mới
                        string artistName = Artistname.Text;
                        Modify modify = new Modify();
                        modify.UpdateFollowerCount(artistName, currentFollowers);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Xử lý ngoại lệ và ghi nhật ký lỗi
                        transaction.Rollback();
                    }
                }
                sqlConnection.Close();
            }

        }
        
    }
}
