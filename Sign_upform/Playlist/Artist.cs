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
    public partial class Artist : UserControl
    {
        public event EventHandler<string> ArtistClicked;
        public Artist()
        {
            InitializeComponent();
        }
        public void SetData(Music music)
        {
            Artistname.Text = music.Artist;
            ImageArtist.ImageLocation = Path.GetFullPath(music.ImageArtits);
          
        }
        
        private void Artist_Load(object sender, EventArgs e)
        {
            
        }

        private void ImageArtist_Click(object sender, EventArgs e)
        {

        }

        private void Artistname_Click(object sender, EventArgs e)
        {
            ArtistClicked?.Invoke(this, Artistname.Text);
        }
    }
}
