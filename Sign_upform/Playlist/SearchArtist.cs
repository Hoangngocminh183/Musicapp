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

namespace Sign_upform.Playlist
{
    public partial class SearchArtist : UserControl
    {
        public SearchArtist()
        {
            InitializeComponent();
        }

        public void SetData(Music music)
        {
            Artistname.Text = music.Artist;
            pictureArtist.ImageLocation = Path.GetFullPath(music.ImageArtits);
        }
        private void labelArtist_Click(object sender, EventArgs e)
        {

        }

        private void SearchArtist_Load(object sender, EventArgs e)
        {

        }

        private void pictureArtist_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void follow_Click(object sender, EventArgs e)
        {

        }
    }
}
