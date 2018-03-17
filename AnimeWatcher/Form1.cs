using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace AnimeWatcher
{
    public partial class Form1 : Form
    {
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayFile(String url)
        {
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            listAnimes.BackColor = Color.FromArgb(60, 60, 60);
            listAnimes.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            listEpisodes.BackColor = Color.FromArgb(60, 60, 60);
            listEpisodes.ForeColor = Color.White;
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            checkBox1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(60, 60, 60);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(60, 60, 60);
            button2.ForeColor = Color.White;
            checkBox1.Checked = true;
            CheckForIllegalCrossThreadCalls = false;
            PlayFile(@"Videos\Loading.mp4");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void listEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEpisodes.SelectedIndex == 0)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/537Qlxmdj28Vsuevqy_Xrw/1521385345/uoqpdmer0fbv.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 1)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/GKlYZV9YLARI8qJcpGqVAw/1521385416/jinxlirt5dew.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 2)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/jMTM1ALWazP5AhgVoZRSmw/1521386168/o95sy52bd2kr.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 3)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/c92sn_Mn2CedAmrlMVlT2Q/1521386220/gitsdkokmdfb.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 4)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/wjSsh1wXpLJ8MLjKnRYJwg/1521386270/xrtousjrtx6e.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 5)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/cW-3Anpw4Qupg1MijxZzxw/1521386323/8gofcswxk89b.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 6)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/phdMEYXcNsJBYGsJjRLQNw/1521402147/ojy89rsoxj28.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 7)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/flBlM7Z4l6oSWZWZY99xrQ/1521402193/mpnif8mxp1xa-650x370.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 8)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/YY-vc25zeDID3us2EBAzgQ/1521402228/udr6grb5lrc6.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 9)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/rzcnDV_TN_Y_bEviZBlJVw/1521402251/afkefsae1rc8.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 10)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/JKI4EFsykN_Z66Lv68h0iw/1521402277/krlky955395x-650x370.html.mp4");
            }
            else if (listEpisodes.SelectedIndex == 11)
            {
                PlayFile("http://cache1.animepremium.tv:558/cache/4EpUNMWhXEZUSxR4e1eAXQ/1521402296/on20i27dgmud.html.mp4");
            }
            else
            {
                axWindowsMediaPlayer1.close();
                PlayFile(@"Videos\Loading.mp4");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                this.BackColor = Color.White;
                listAnimes.BackColor = Color.White;
                listAnimes.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                listEpisodes.BackColor = Color.White;
                listEpisodes.ForeColor = Color.Black;
                panel1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                listAnimes.BackColor = Color.FromArgb(60, 60, 60);
                listAnimes.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                listEpisodes.BackColor = Color.FromArgb(60, 60, 60);
                listEpisodes.ForeColor = Color.White;
                panel1.BackColor = Color.FromArgb(60, 60, 60);
                checkBox1.ForeColor = Color.White;
                button1.BackColor = Color.FromArgb(60, 60, 60);
                button1.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(60, 60, 60);
                button2.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void listAnimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAnimes.SelectedIndex == 0)
            {
                listEpisodes.Items.Clear();
                listEpisodes.Items.Add("Episode 1");
                listEpisodes.Items.Add("Episode 2");
                listEpisodes.Items.Add("Episode 3");
                listEpisodes.Items.Add("Episode 4");
                listEpisodes.Items.Add("Episode 5");
                listEpisodes.Items.Add("Episode 6");
                listEpisodes.Items.Add("Episode 7");
                listEpisodes.Items.Add("Episode 8");
                listEpisodes.Items.Add("Episode 9");
                listEpisodes.Items.Add("Episode 10");
                listEpisodes.Items.Add("Episode 11");
                listEpisodes.Items.Add("Episode 12");
            }
        }
    }
}
