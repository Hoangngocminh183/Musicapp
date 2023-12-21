using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform.Playlist
{
    public partial class MusicList : UserControl
    {
        public event EventHandler MusicClicked;
        private string filePath;
        private Music musicData;
        public MusicList()
        {
            InitializeComponent();
        }

        public void SetData(Music music)
        {
            musicData = music;
            labelTitle.Text = music.Title;
            labelArtist.Text = music.Artist;
            pictureMusic.ImageLocation = Path.GetFullPath(music.ImagePath);
            filePath = Path.GetFullPath(music.FilePath);
        }
        public Music GetData()
        {
            // Trả về đối tượng Music liên kết với User Control
            return musicData;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureMusic_Click(object sender, EventArgs e)
        {
            MusicClicked?.Invoke(this, EventArgs.Empty);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            MusicClicked?.Invoke(this, EventArgs.Empty);
        }
        private void labelArtist_Click(object sender, EventArgs e)
        {

        }

        private void MusicList_Load(object sender, EventArgs e)
        {

        }
    }
}
