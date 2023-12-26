using Guna.UI2.AnimatorNS;
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
    public partial class MusicList : UserControl
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
        public MusicList()
        {
            InitializeComponent();
            Share.Visible = false;
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
            ArtistClicked?.Invoke(this, musicData.Artist);
        }

        private void MusicList_Load(object sender, EventArgs e)
        {
            pictureMusic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureMusic.Width,
     pictureMusic.Height, 12, 12));
        }
       int flag = -1;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\Sign_upform (1)\Sign_upform\Resources\heart.png");
                pictureBox6.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\Sign_upform (1)\Sign_upform\Resources\Frame 517.png");
                pictureBox6.Image = c; // gọi lại biến để xuất ảnh
            }
        }
        private bool isShareVisible = false;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Toggle the visibility state
            isShareVisible = !isShareVisible;

            if (isShareVisible)
            {
                Share.Show();
            }
            else
            {
                Share.Hide();
            }
        }
    }
}
