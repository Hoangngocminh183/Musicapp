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
    public partial class Homepage_Fan : Form
    {
        Modify modify = new Modify();
        public Homepage_Fan()
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
                ControlMussic musicControl = new ControlMussic();

                // Nạp dữ liệu từ đối tượng Music vào User Control
                musicControl.SetData(music);

                // Thêm User Control vào FlowLayoutPanelToppicks
                flowLayoutPanelToppicks.Controls.Add(musicControl);   
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
    }
}
