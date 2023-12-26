using Sign_upform.Playlist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class MoreMusic : Form
    {
        Modify modify = new Modify();
        public MoreMusic()
        {
            InitializeComponent();
            LoadMusicIntoUserControl();
        }
        private void LoadMusicIntoUserControl()
        {
            List<Music> musicList = modify.GetMusicList();

            foreach (Music music in musicList)
            {
                // Tạo mới một instance của User Control (assumed là controlMussic1, controlMussic2, ...)
                MusicList musicList1 = new MusicList(); 

                // Nạp dữ liệu từ đối tượng Music vào User Control
                musicList1.SetData(music);

                // Thêm User Control vào FlowLayoutPanelToppicks
                flowLayoutMoreMusic.Controls.Add(musicList1);

                musicList1.MusicClicked += MusicControl_MusicClicked;
                musicList1.ArtistClicked += MusicControl_ArtistClicked; // Thêm đoạn này để đăng ký sự kiện ArtistClicked
                // Thêm bài hát vào danh sách playlist trong NowplayingControl
                nowplayingControl1.AddToPlaylist(music);
            }
        }
        private void MusicControl_ArtistClicked(object sender, string artistName)
        {
            // Mở ArtistPage và chuyển artistName
            ArrtistPage artistPage = new ArrtistPage();
            artistPage.StartPosition = FormStartPosition.CenterScreen;
            // Load thông tin từ bảng Followers
            artistPage.LoadArtistControls(artistName);
            // Tải kết quả tìm kiếm từ Followers vào flowLayoutSearch
            LoadSearchResultsFromFollowers(artistName, artistPage);
            artistPage.Show();
        }
        private void LoadSearchResultsFromFollowers(string artistName, ArrtistPage artistPage)
        {
            // Gọi phương thức trên ArtistPage để tải kết quả tìm kiếm từ Followers
            List<Music> searchResults = modify.SearchMusicByArtist(artistName);

            foreach (Music music in searchResults)
            {
                SearchArtist searchArtist = new SearchArtist();
                searchArtist.SetData(music);
                artistPage.AddSearchResult(searchArtist); // AddSearchResult là một phương thức bạn cần triển khai trong ArtistPage
            }
        }
        private void MusicControl_MusicClicked(object sender, EventArgs e)
        {
            if (sender is MusicList musicList1)
            {
                // Truy cập đối tượng Music liên kết với control được nhấp
                Music clickedMusic = musicList1.GetData();

                // Chuyển thông tin đến NowplayingControl
                nowplayingControl1.SetData(clickedMusic);
            }
        }

            private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void disable_bar_Click(object sender, EventArgs e)
        {

        }

        private void nowplayingControl2_Load(object sender, EventArgs e)
        {

        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nowplayingControl1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutMoreMusic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InspiroMix_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void SearchSong_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
