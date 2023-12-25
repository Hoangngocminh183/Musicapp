using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform.Playlist
{
    public partial class ControlMussic : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );
        public event EventHandler MusicClicked;
        public event EventHandler<string> ArtistClicked;
        private string filePath;
        private Music musicData;
        public ControlMussic()
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

        private void pictureMusic_Click(object sender, EventArgs e)
        {
            MusicClicked?.Invoke(this, EventArgs.Empty);
        }

        private void TitleMusic_Click(object sender, EventArgs e)
        {
            MusicClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Artist_Click(object sender, EventArgs e)
        {
            ArtistClicked?.Invoke(this, musicData.Artist);
        }

        private void ControlMussic_Load(object sender, EventArgs e)
        {
            pictureMusic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureMusic.Width,
    pictureMusic.Height, 12, 12));
        }
        private string TruncateStringWithEllipsis(string input, int maxLength)
        {
            if (input.Length > maxLength)
            {
                return input.Substring(0, maxLength) + "...";
            }
            return input;
        }
        private void labelTitle_TextChanged(object sender, EventArgs e)
        {

            if (labelTitle.Text.Length > 12)
            {
                // Nếu số ký tự vượt quá giới hạn, cắt chuỗi và thêm dấu "..."
                labelTitle.Text = TruncateStringWithEllipsis(labelTitle.Text, 12);
            }
        }
    }
}
