using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Money_Exchange
{
    public partial class MainForm : Form
    {

        private System.Timers.Timer time;
        private int CountTime = 0;
        public MainForm()
        {
            InitializeComponent();
            var files = System.IO.Directory.GetFiles(@"./Assets/Images");
            MessageBox.Show(files[0]);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeImage()
        {
            time = new System.Timers.Timer(5000) {AutoReset= true };
            time.Start();
            time.Elapsed += (sender, e) =>
            {
                CountTime++;
                if(CountTime == 6)
                {
                    CountTime = 0;
                    SlideImg.Image = Image.FromFile(@"~/Assets/Images/");
                }
            };
        }
    }
}
