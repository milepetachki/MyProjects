namespace Web_Browser_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoBack = new System.Windows.Forms.Button();
            this.WebUrl = new System.Windows.Forms.TextBox();
            this.GoForward = new System.Windows.Forms.Button();
            this.GoogleSearch = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sAVEASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 80);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1264, 602);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::Web_Browser_2._0.Properties.Resources.The_best_top_desktop_hd_dark_black_wallpapers_dark_black_wallpaper_dark_background_dark_wallpaper_16;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "                ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.GoBack);
            this.panel1.Controls.Add(this.WebUrl);
            this.panel1.Controls.Add(this.GoForward);
            this.panel1.Controls.Add(this.GoogleSearch);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Go);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 56);
            this.panel1.TabIndex = 10;
            // 
            // GoBack
            // 
            this.GoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBack.BackgroundImage")));
            this.GoBack.Image = ((System.Drawing.Image)(resources.GetObject("GoBack.Image")));
            this.GoBack.Location = new System.Drawing.Point(17, 12);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(41, 40);
            this.GoBack.TabIndex = 0;
            this.GoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // WebUrl
            // 
            this.WebUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.WebUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.WebUrl.BackColor = System.Drawing.Color.DimGray;
            this.WebUrl.Location = new System.Drawing.Point(328, 32);
            this.WebUrl.Name = "WebUrl";
            this.WebUrl.Size = new System.Drawing.Size(449, 20);
            this.WebUrl.TabIndex = 9;
            // 
            // GoForward
            // 
            this.GoForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoForward.BackgroundImage")));
            this.GoForward.Image = ((System.Drawing.Image)(resources.GetObject("GoForward.Image")));
            this.GoForward.Location = new System.Drawing.Point(64, 12);
            this.GoForward.Name = "GoForward";
            this.GoForward.Size = new System.Drawing.Size(41, 40);
            this.GoForward.TabIndex = 1;
            this.GoForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GoForward.UseVisualStyleBackColor = true;
            this.GoForward.Click += new System.EventHandler(this.GoForward_Click);
            // 
            // GoogleSearch
            // 
            this.GoogleSearch.BackColor = System.Drawing.Color.DimGray;
            this.GoogleSearch.Location = new System.Drawing.Point(1044, 32);
            this.GoogleSearch.Name = "GoogleSearch";
            this.GoogleSearch.Size = new System.Drawing.Size(161, 20);
            this.GoogleSearch.TabIndex = 8;
            this.GoogleSearch.TextChanged += new System.EventHandler(this.textBoxGoogleSearch_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImage = global::Web_Browser_2._0.Properties.Resources.The_best_top_desktop_hd_dark_black_wallpapers_dark_black_wallpaper_dark_background_dark_wallpaper_16;
            this.Refresh.Image = global::Web_Browser_2._0.Properties.Resources.images;
            this.Refresh.Location = new System.Drawing.Point(166, 13);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(41, 40);
            this.Refresh.TabIndex = 2;
            this.Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(960, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Google:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::Web_Browser_2._0.Properties.Resources.The_best_top_desktop_hd_dark_black_wallpapers_dark_black_wallpaper_dark_background_dark_wallpaper_16;
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(213, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(45, 40);
            this.Home.TabIndex = 3;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Web URL:";
            // 
            // Go
            // 
            this.Go.BackgroundImage = global::Web_Browser_2._0.Properties.Resources.The_best_top_desktop_hd_dark_black_wallpapers_dark_black_wallpaper_dark_background_dark_wallpaper_16;
            this.Go.Image = global::Web_Browser_2._0.Properties.Resources.Crystal_button_ok;
            this.Go.Location = new System.Drawing.Point(783, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(45, 40);
            this.Go.TabIndex = 4;
            this.Go.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::Web_Browser_2._0.Properties.Resources.The_best_top_desktop_hd_dark_black_wallpapers_dark_black_wallpaper_dark_background_dark_wallpaper_16;
            this.Stop.Image = global::Web_Browser_2._0.Properties.Resources.button_cancel_32x32;
            this.Stop.Location = new System.Drawing.Point(834, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(45, 40);
            this.Stop.TabIndex = 5;
            this.Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.toolStripSeparator1,
            this.sAVEASToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // sAVEASToolStripMenuItem
            // 
            this.sAVEASToolStripMenuItem.Name = "sAVEASToolStripMenuItem";
            this.sAVEASToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sAVEASToolStripMenuItem.Text = "SAVE AS";
            this.sAVEASToolStripMenuItem.Click += new System.EventHandler(this.sAVEASToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "By: 5ak";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button GoForward;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GoogleSearch;
        private System.Windows.Forms.TextBox WebUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sAVEASToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

