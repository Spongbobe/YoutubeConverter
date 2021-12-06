using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;
using System.IO;

namespace WindowsFormsApp1.Forms
{
    public partial class Thumnail : Form
    {
        public Thumnail()
        {
            InitializeComponent();
            
        }

        private async Task<YoutubeInfo> GetYoutubeInfo(string link)
        {

            var youtube = YouTube.Default;
            var vid = await youtube.GetVideoAsync(link);

            /* File.WriteAllBytes(path + vid.FullName, vid.GetBytes());

             var inputFile = new MediaFile { Filename = path + vid.FullName };

             var outputFile = new MediaFile { Filename = $"{path + vid.FullName}.mp3" };*/
            var video_info = new YoutubeInfo();
            video_info.Title = vid.Title;
            video_info.Thumnail = "";
            video_info.Uri = vid.Uri;

            File.WriteAllBytes("D:\\audio.mp4", await vid.GetBytesAsync());

            return video_info;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var value =  await GetYoutubeInfo(textBox1.Text);

            label1.Text = $"Title : {value.Title}";
        }
    }
    class YoutubeInfo
    {
        public string Thumnail { get; set; }
        public string Uri { get; set; }
        public string Title { get; set; }
    }
}
