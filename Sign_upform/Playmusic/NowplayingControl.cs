using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms.Suite;
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
        private int currentMouseX; // Thêm biến để lưu giữ giá trị của mouseX khi kéo thanh ProgressBar
        private bool isLooping = false;
        private bool isRestarting = false; // Biến để kiểm tra xem có đang khởi động lại từ sự kiện PlaybackStopped không
        private List<Music> playlist = new List<Music>(); // Danh sách bài hát
        private int currentSongIndex = -1; // Chỉ số của bài hát hiện tại trong danh sách

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
            // PlayMusic();

           
        }
        public void AddToPlaylist(Music music)
    {
        // Nếu danh sách trống, thêm bài hát hiện tại vào danh sách và đặt currentSongIndex
        if (playlist.Count == 0)
        {
            playlist.Add(music);
            currentSongIndex = 0;
        }
        // Nếu danh sách không trống, kiểm tra xem bài hát đã có trong danh sách hay chưa
        // Nếu chưa có, thêm vào danh sách và đặt currentSongIndex
        else if (!playlist.Contains(music))
        {
            playlist.Add(music);
            currentSongIndex = playlist.IndexOf(music);
        }
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
                    wavePlayer.Init(audioFile);
                    pausedPosition = 0; // Reset giá trị vị trí tạm dừng sau khi sử dụng
                }
                else
                {
                    // Ngược lại, phát nhạc mới
                    audioFile = new AudioFileReader(filePath);
                    // Kiểm tra và đặt thuộc tính lặp lại
                    if (isLooping)
                    {
                        isRestarting = true; // Đánh dấu là đang khởi động lại từ sự kiện PlaybackStopped
                    }
                    wavePlayer.Init(audioFile);
                }
                    isPlaying = true;
                    timer1.Start();
                    timer2.Start();
                    // Đăng ký sự kiện PlaybackStopped để xử lý việc lặp lại
                    wavePlayer.PlaybackStopped += WavePlayer_PlaybackStopped;

                    // Start playing from the current position
                    wavePlayer.Play();
                
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
        // Phương thức để cắt bớt chuỗi và thêm dấu "..."
        private string TruncateStringWithEllipsis(string input, int maxLength)
        {
            if (input.Length > maxLength)
            {
                return input.Substring(0, maxLength) + "...";
            }
            return input;
        }
        private void TitleMusic_Click(object sender, EventArgs e)
        {
            
        }
        private void TitleMusic_TextChanged(object sender, EventArgs e)
        {
            if (TitleMusic.Text.Length > 7)
            {
                // Nếu số ký tự vượt quá giới hạn, cắt chuỗi và thêm dấu "..."
                TitleMusic.Text = TruncateStringWithEllipsis(TitleMusic.Text, 7);
            }
        }
        private void TitleArtist_Click(object sender, EventArgs e)
        {

        }

        int flags = 1;
        private void play_pause_Click(object sender, EventArgs e)
        {
            flags *= -1;
            if (flags == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\Sign_upform (1)\Sign_upform\Resources\angle-left 3.png");
                play_pause.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\Sign_upform (1)\Sign_upform\Resources\Pause.png");
                play_pause.Image = c;
            }
            PlayPauseMusic();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Chuyển sang bài hát tiếp theo trong danh sách
            if (playlist.Count > 0)
            {
                currentSongIndex++;
                // Kiểm tra xem đã hết danh sách bài hát chưa
                if (currentSongIndex >= playlist.Count)
                {
                    // Nếu đã hết, quay lại bài hát đầu danh sách
                    currentSongIndex = 0;
                }
                SetData(playlist[currentSongIndex]);
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            // Chuyển đến bài hát trước đó trong danh sách
            if (playlist.Count > 1 && currentSongIndex > 0)
            {
                currentSongIndex--;
                SetData(playlist[currentSongIndex]);
            }
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

                // Calculate the new position based on the mouse cursor's coordinates
                float newPosition = (float)mouseX / guna2ProgressBar1.Width;

                // Update the ProgressBar value
                guna2ProgressBar1.Value = (int)(newPosition * 100);

                // Update the displayed time while dragging
                labelRealTime.Text = $"{(int)(newPosition * totalSeconds) / 60}:{(int)(newPosition * totalSeconds) % 60:00}";

                // Check if dragging and update the position in the audioFile
                if (isDragging)
                {             
                    // Calculate the new position in seconds
                    int newPositionInSeconds = (int)(newPosition * totalSeconds);

                    // Move to the new position in the audioFile
                    audioFile.CurrentTime = TimeSpan.FromSeconds(newPositionInSeconds);
                }
            }
        }


        private void guna2ProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            currentMouseX = e.X; // Gán giá trị cho currentMouseX khi bắt đầu kéo
            UpdateProgressBarPosition(currentMouseX);
        }

        private void guna2ProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (audioFile != null && isPlaying)
            {
                // Calculate the new position based on the mouse cursor's coordinates
                float newPosition = (float)e.X / guna2ProgressBar1.Width;

                // Calculate the new position in seconds
                int totalSeconds = (int)audioFile.TotalTime.TotalSeconds;
                int newPositionInSeconds = (int)(newPosition * totalSeconds);

                // Move to the new position in the audioFile
                audioFile.CurrentTime = TimeSpan.FromSeconds(newPositionInSeconds);
            }
        }

        private void guna2ProgressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                UpdateProgressBarPosition(e.X); // Cập nhật giá trị khi di chuyển chuột
            }
        }

        private void labelRealTime_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalTime_Click(object sender, EventArgs e)
        {

        }

        private void Volume_Scroll(object sender, ScrollEventArgs e)
        {
            int volumeValue = Volume.Value;
            float volumeRatio = volumeValue / 100.0f;
            wavePlayer.Volume = volumeRatio;
        }
        private void WavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Kiểm tra nếu phát nhạc dừng tự nhiên (không phải do phương thức StopMusic)
            if (e.Exception == null && isLooping && !isRestarting)
            {
                // Nếu lặp lại được kích hoạt và không phải đang khởi động lại, phát lại nhạc
                PlayMusic();
            }

            // Đặt lại biến đánh dấu khởi động lại
            isRestarting = false;
        }
        private void loop_Click(object sender, EventArgs e)
        {
            // Toggle the looping state
            isLooping = !isLooping;

            // Update UI to reflect the looping state
            if (isLooping)
            {
                // Set a visual indication that looping is enabled (you can customize this based on your UI)
                MusicLoop.BackColor = Color.Green; // For example, set the background color to green
            }
            else
            {
                // Set a visual indication that looping is disabled
                MusicLoop.BackColor = SystemColors.Control; // Reset the background color to the default
            }
        }

        
    }
}
