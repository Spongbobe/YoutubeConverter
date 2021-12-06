using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GitHubProfile : Form
    {
        public GitHubProfile()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchTb.Text.Length > 0)
            {
                var githubProfile = await Processor.ProfileProcessor.GetGitHubProfile(searchTb.Text);

                MessageBox.Show(githubProfile.Url);
            }
        }
    }
}
