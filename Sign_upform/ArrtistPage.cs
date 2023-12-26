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
    public partial class ArrtistPage : Form
    {
        public ArrtistPage()
        {
            InitializeComponent();
        }
        public void LoadArtistControls(string artistName)
        {
            Modify modify = new Modify();
            List<Music> artistControls = modify.GetControlsByArtist(artistName);

            foreach (Music music in artistControls)
            {
                ControlMussic musicControl = new ControlMussic();
                musicControl.SetData(music);
                // Đăng ký sự kiện MusicClicked
                musicControl.MusicClicked += MusicControl_ArtistPage_MusicClicked;
                FlowHighlight.Controls.Add(musicControl);
            }
        }
        private void MusicControl_ArtistPage_MusicClicked(object sender, EventArgs e)
        {
            if (sender is ControlMussic musicControl)
            {
                Music clickedMusic = musicControl.GetData();
                
                nowplayingControl1.SetData(clickedMusic); // Chuyển thông tin đến NowplayingControl
            }
        }
        public void AddSearchResult(SearchArtist searchArtist)
        {
            // Thêm điều khiển SearchArtist vào flowLayoutSearch
            flowLayoutSearch.Controls.Add(searchArtist);
        }
        private void FlowHighlight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchArtist1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutSearch_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Homepage_Fan homepage_Fan = new Homepage_Fan();
            homepage_Fan.Show();
            this.Hide();
        }
    }
}
