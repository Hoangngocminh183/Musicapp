using Microsoft.Win32;
using Sign_upform.Playlist;
using Sign_upform.Playmusic;
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
    public partial class Homepage_Fan : Form
    {
        Modify modify = new Modify();
        public Homepage_Fan()
        {
            InitializeComponent();
            LoadMusicIntoUserControl();
            LoadNewReleasesIntoUserControl();
            SearchPanel.Visible = false;
        }
      
        private void LoadMusicIntoUserControl()
        {
            List<Music> musicList = modify.GetMusicList();

            foreach (Music music in musicList)
            {
                // Tạo mới một instance của User Control (assumed là controlMussic1, controlMussic2, ...)
                ControlMussic musicControl = new ControlMussic();

                // Nạp dữ liệu từ đối tượng Music vào User Control
                musicControl.SetData(music);

                // Thêm User Control vào FlowLayoutPanelToppicks
                flowLayoutPanelToppicks.Controls.Add(musicControl);

                musicControl.MusicClicked += MusicControl_MusicClicked;
                // Thêm bài hát vào danh sách playlist trong NowplayingControl
                nowplayingControl1.AddToPlaylist(music);
            }
        }
        private void MusicControl_MusicClicked(object sender, EventArgs e)
        {
            // Xử lý sự kiện MusicClicked
            if (sender is ControlMussic musicControl)
            {
                // Truy cập đối tượng Music liên kết với control được nhấp
                Music clickedMusic = musicControl.GetData();

                // Chuyển thông tin đến NowplayingControl
                nowplayingControl1.SetData(clickedMusic);

                // Kiểm tra xem musicControl đã tồn tại trong recentlyPlayedControls chưa
                ControlMussic existingControl = recentlyPlayedControls.FirstOrDefault(control => control.GetData().Equals(clickedMusic));

                if (existingControl == null)
                {
                    // Tạo một bản sao mới của ControlMussic để thêm vào recentlyPlayedControls
                    ControlMussic recentlyPlayedControlCopy = new ControlMussic();
                    recentlyPlayedControlCopy.SetData(clickedMusic);

                    // Thêm vào recentlyPlayedControls
                    recentlyPlayedControls.Insert(0, recentlyPlayedControlCopy);

                    // Nếu danh sách đã đầy, xóa phần tử cuối cùng
                    if (recentlyPlayedControls.Count > 5)
                    {
                        recentlyPlayedControls.RemoveAt(recentlyPlayedControls.Count - 1);
                    }

                    // Cập nhật giao diện cho FlowLayoutRecently
                    UpdateRecentlyPlayedControls();
                }
            }
        }
        private List<ControlMussic> recentlyPlayedControls = new List<ControlMussic>();

        private void UpdateRecentlyPlayedControls()
        {
            flowLayoutRecently.Controls.Clear();

            foreach (ControlMussic musicControl in recentlyPlayedControls)
            {
                flowLayoutRecently.Controls.Add(musicControl);

                // Đăng ký sự kiện cho việc nhấn vào musicControl trong FlowLayoutRecently
                musicControl.MusicClicked += RecentlyPlayedMusicControl_Clicked;
            }
        }
        private void RecentlyPlayedMusicControl_Clicked(object sender, EventArgs e)
        {
            if (sender is ControlMussic musicControl)
            {
                Music clickedMusic = musicControl.GetData();
                nowplayingControl1.SetData(clickedMusic); // Chuyển thông tin đến NowplayingControl
            }
        }

        private void LoadNewReleasesIntoUserControl()
        {
            List<Music> newReleases = modify.GetNewReleases();

            foreach (Music music in newReleases)
            {
                ControlMussic musicControl = new ControlMussic();
                musicControl.SetData(music);
                flowReleases.Controls.Add(musicControl); // Thêm vào cuối danh sách
                musicControl.MusicClicked += MusicControl_MusicClicked; // Đăng ký sự kiện
            }
        }


        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void Play_Pause_Click(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {

        }
        private void Artist1_Click(object sender, EventArgs e)
        {

        }

        private void artist5_Load(object sender, EventArgs e)
        {

        }

        private void artist2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void controlMussic1_Load(object sender, EventArgs e)
        {
     
        }

        private void controlMussic2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void play_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transfer_images_Click(object sender, EventArgs e)
        {

        }

        private void nowplayingControl1_Load(object sender, EventArgs e)
        {

        }

        private void nowplayingControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void see_more_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutRecently_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelToppicks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutNewReleases_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        private void SearchSong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void PreviousPage_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible=false;
        }

        private void NextPage1_Click(object sender, EventArgs e)
        {

        }

        private void see_more_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoreMusic moreMusic = new MoreMusic();
            moreMusic.StartPosition = FormStartPosition.CenterScreen;
            moreMusic.Location = this.Location;
            moreMusic.Show();
        }

        private void flowLayoutPanelToppicks_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateLablelTitle(string title)
        {
            labelTitle.Text = $"\"{title}\"";
        }
        private void PerformSearch(string searchText)
        {
            List<Music> searchResults = modify.SearchMusic(searchText);

            SearchPanel.Visible = true;
            flowLayoutSearch.Controls.Clear();

            if (searchResults.Count > 0)
            {
                foreach (Music music in searchResults)
                {
                    ControlMussic musicControl = new ControlMussic();
                    musicControl.SetData(music);
                    flowLayoutSearch.Controls.Add(musicControl);

                    musicControl.MusicClicked += MusicControl_MusicClicked;
                }
            }
            else
            {
                labelerror.Text = "No results found for";
            }
            
        }
        private void SearchSong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string searchText = SearchSong.Text.Trim();
                UpdateLablelTitle(searchText);
                PerformSearch(searchText);
            }
        }

        private void labelError(object sender, EventArgs e)
        {

        }
    }
}
