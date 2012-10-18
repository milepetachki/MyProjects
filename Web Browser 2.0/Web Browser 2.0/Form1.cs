using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Browser_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_KeyPress(object sender,System.Windows.Forms.KeyPressEventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void textBoxGoogleSearch_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.bg/webhp?sourceid=chrome-instant&ie=UTF-8#hl=bg&output=search&sclient=psy-ab&q=" + WebUrl);
        }



        private void textBoxWebUrl_Enter(object sender, EventArgs e)
        {
            webBrowser1.Navigate(WebUrl.Text);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void GoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(WebUrl.Text);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading site" + e.Url.Host.ToString();
        }

        private void sAVEASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        
  
    }
}
