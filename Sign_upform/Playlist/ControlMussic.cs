using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform.Playlist
{
    public partial class ControlMussic : UserControl
    {
        public ControlMussic()
        {
            InitializeComponent();
        }
       public void SetData(Music music)
        {
            labelTitle.Text = music.Title;
            labelArtist.Text = music.Artist;
            pictureMusic.ImageLocation = Path.GetFullPath(music.ImagePath);
        }

        private void pictureMusic_Click(object sender, EventArgs e)
        {

        }

        private void TitleMusic_Click(object sender, EventArgs e)
        {

        }

        private void Artist_Click(object sender, EventArgs e)
        {

        }

        private void ControlMussic_Load(object sender, EventArgs e)
        {

        }
    }
}
