using MediaToolkit;
using MediaToolkit.Model;
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
using VideoLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*CountTime.Initialize();
            while (CountTime.IsProgressing)
            {
                Task.Run(() =>
                {
                        panel1.Width += 5;
                        label1.Left += 5;

                });
            }
            label2.Text = CountTime.TotalTime.ToString();*/

            //CountTime1();

        }
        async Task<string> SaveVideoToDisk(string link, string path)
        {
            return await Test(link, path);
        }
        private async Task<string> Test(string link,string path)
        {
            var youtube = YouTube.Default;
            var vid = await youtube.GetVideoAsync(link);



            File.WriteAllBytes(path + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = path + vid.FullName };

            var outputFile = new MediaFile { Filename = $"{path + vid.FullName}.mp3" };



            using (var engine = new Engine())
            {
                //engine.GetMetadata(inputFile);

                //engine.Convert(inputFile, outputFile);
            }

            return inputFile.Filename;
        }

        private async Task Loading()
        {
            var loadingTime = new Timer();
            loadingTime.Interval = 100; // mean 1s
            loadingTime.Start();

            loadingTime.Tick += (ea, ob) =>
           {
                if(panel1.Width < this.Width - 40)
               {
                   this.Invoke((MethodInvoker)delegate {
                       panel1.Width += 5;
                       label1.Left += 5;
                       label1.Text = panel1.Width.ToString();

                      
                   });
               }
           };
        }

        private async Task AwaitFile(string filePath)
        {
            //Your File
            var file = new FileInfo(filePath);

            //While File is not accesable because of writing process
            while (IsFileLocked(file))
            {
                await Loading();

            }



            //File is available here

        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

     
        private void CountTime1()
        {
            System.Diagnostics.Stopwatch stw = new System.Diagnostics.Stopwatch() ;
            stw.Start();

            Task.Run(() =>
            {
                while (stw.IsRunning)
                {
                    panel1.Width += 5;
                    int time = (int)stw.Elapsed.TotalSeconds;
                    label1.Left += 5;
                    label1.Text = time + "s";

                    System.Threading.Thread.Sleep(500);
                    
                }

            });
           

            var elapsedTime = stw.Elapsed.TotalMilliseconds;
        }

        private string[] GetFiles(string path)
        {


            return System.IO.Directory.GetFiles(path) ;  
        }

        public static class CountTime
        {
            private static System.Diagnostics.Stopwatch stw = new System.Diagnostics.Stopwatch();

            public static void Initialize()
            {
                stw.Start();
            }
            public static bool IsProgressing
            {
                get
                {
                    return stw.IsRunning;
                }
                private set { }
            }
               
            public static double TotalTime
            {
                get
                {
                    return stw.Elapsed.TotalSeconds;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            
            //System.IO.Directory.GetFiles(fd.SelectedPath).ToList().ForEach(f =>listBox1.Items.Add(f));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(textBox1, e.Location);

            }
        }

        private async void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountTime.Initialize();
            string path = string.Empty;

            await Task.Run(async() =>
            {
                panel1.Width += 25;

                path = await SaveVideoToDisk(textBox1.Text, @"D:\");
                listBox2.Items.Add(String.Format("{0} DownlaodTime : {1}s", path, CountTime.TotalTime));
            });


        }
    }
}
