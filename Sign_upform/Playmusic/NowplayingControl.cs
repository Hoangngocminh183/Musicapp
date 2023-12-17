using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace Sign_upform.Playmusic
{
    public partial class NowplayingControl : UserControl
    {
        private string filePath;
        private IWavePlayer wavePlayer;
        private bool isPlaying; // theo dõi cơ chế phát nhạc
        private AudioFileReader audioFile;
        private long pausedPosition; // lưu vị trí tạm dừng
        private bool isDragging = false; // Biến để kiểm tra xem ProgressBar có đang được kéo thả hay không

        public NowplayingControl()
        {
            InitializeComponent();
            wavePlayer = new WaveOut();
            isPlaying = false;
            pausedPosition = 0;

            // Khởi tạo timer1 cho thời gian chơi nhạc
            timer1 = new Timer();
            timer1.Interval = 1000; // Cập nhật mỗi giây
            timer1.Tick += timer1_Tick;

            // Khởi tạo timer2 cho thời gian gốc của bài hát
            timer2 = new Timer();
            timer2.Interval = 1000; // Cập nhật mỗi giây
            timer2.Tick += timer2_Tick;
        }

        public void SetData(Music music)
        {
            StopMusic();
            // Cập nhật các yếu tố UI trong NowplayingControl với dữ liệu từ ControlMussic được nhấp
            TitleMusic.Text = music.Title;
            TitleArtist.Text = music.Artist;
            transfer_images.ImageLocation = Path.GetFullPath(music.ImagePath);
            filePath = Path.GetFullPath(music.FilePath);
            PlayMusic();
        }

        private void PlayMusic()
        {
            try
            {
                // Kiểm tra nếu có một bài hát khác đang phát
                if (isPlaying)
                {
                    StopMusic();
                }

                // Nếu đã tạm dừng thì tiếp tục từ vị trí tạm dừng
                if (pausedPosition > 0)
                {
                    // Tiếp tục từ vị trí tạm dừng
                    audioFile = new AudioFileReader(filePath);
                    audioFile.Position = pausedPosition;
                    pausedPosition = 0;
                }
                else
                {
                    // Ngược lại, phát nhạc mới
                    audioFile = new AudioFileReader(filePath);
                    wavePlayer.Init(audioFile);
                    wavePlayer.Play();
                    isPlaying = true;
                    timer1.Start();
                    timer2.Start();
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi phát nhạc
                MessageBox.Show($"Error playing music: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PauseMusic()
        {
            if (wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                // Lưu vị trí tạm dừng
                pausedPosition = audioFile.Position;

                wavePlayer.Pause();
                isPlaying = false;
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void StopMusic()
        {
            if (wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                wavePlayer.Stop();
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }

            isPlaying = false;
            pausedPosition = 0;
            timer1.Stop();
            timer2.Stop();
        }

        private void PlayPauseMusic()
        {
            if (isPlaying)
            {
                PauseMusic();
            }
            else
            {
                PlayMusic();
            }
        }

        private void transfer_images_Click(object sender, EventArgs e)
        {

        }

        private void TitleMusic_Click(object sender, EventArgs e)
        {

        }

        private void TitleArtist_Click(object sender, EventArgs e)
        {

        }

        private void play_pause_Click(object sender, EventArgs e)
        {
            PlayPauseMusic();
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {

        }

        private void NowplayingControl_Load(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && isPlaying)
            {
                int totalSeconds = (int)audioFile.TotalTime.TotalSeconds;
                int currentSeconds = (int)audioFile.CurrentTime.TotalSeconds;

                // Cập nhật thanh ProgressBar
                guna2ProgressBar1.Value = (currentSeconds * 100) / totalSeconds;

                // Kiểm tra nếu đã đến cuối bài hát thì dừng timer
                if (currentSeconds >= totalSeconds)
                {
                    timer1.Stop();
                }
                // Cập nhật hiển thị thời gian
                labelRealTime.Text = $"{currentSeconds / 60}:{currentSeconds % 60:00}";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian gốc của bài hát(thời gian không thay đổi)
            if (audioFile != null)
            {
                int totalSeconds = (int)audioFile.TotalTime.TotalSeconds;
                int currentSeconds = (int)audioFile.CurrentTime.TotalSeconds;

                // Tính tỷ lệ giữa thời gian hiện tại và tổng thời gian
                float progressRatio = (float)currentSeconds / totalSeconds;

                // Cập nhật giá trị tối đa và giá trị hiện tại của ProgressBar
                guna2ProgressBar1.Maximum = 100;
                guna2ProgressBar1.Value = (int)(progressRatio * 100);

                // Kiểm tra nếu đã đến cuối bài hát thì dừng timer
                if (currentSeconds >= totalSeconds)
                {
                    timer2.Stop();
                }

                // Cập nhật hiển thị thời gian
                labelTotalTime.Text = $"{totalSeconds / 60}:{totalSeconds % 60:00}";
            }
        }

        private void UpdateProgressBarPosition(int mouseX)
        {
            if (audioFile != null)
            {
                int totalSeconds = (int)audioFile.TotalTime.TotalSeconds;

                // Tính toán vị trí mới dựa trên tọa độ của con trỏ chuột
                float newPosition = (float)mouseX / guna2ProgressBar1.Width * totalSeconds;

                // Cập nhật giá trị ProgressBar
                guna2ProgressBar1.Value = (int)newPosition;

                // Cập nhật hiển thị thời gian khi đang kéo thả
                labelRealTime.Text = $"{(int)newPosition / 60}:{(int)newPosition % 60:00}";
            }
        }


        private void guna2ProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            UpdateProgressBarPosition(e.X);
        }

        private void guna2ProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (audioFile != null && isPlaying)
            {
                // Nếu đang phát nhạc, di chuyển đến vị trí mới
                int totalSeconds = (int)audioFile.TotalTime.TotalSeconds;
                int newPosition = (int)((float)e.X / guna2ProgressBar1.Width * totalSeconds);

                // Tính toán vị trí mới trong audioFile
                long newPositionInBytes = (long)((float)newPosition / 100 * audioFile.Length);

                newPositionInBytes = Math.Max(newPositionInBytes, 0);
                newPositionInBytes = Math.Min(newPositionInBytes, audioFile.Length - 1);
                // Di chuyển đến vị trí mới
                audioFile.Position = newPositionInBytes;
            }
        }

        private void guna2ProgressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                UpdateProgressBarPosition(e.X);
            }
        }

        private void labelRealTime_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalTime_Click(object sender, EventArgs e)
        {

        }
    }
}
