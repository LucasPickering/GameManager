namespace GameManager
{
    partial class GameManager
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
            System.Windows.Forms.TabControl ServerTabControl;
            System.Windows.Forms.TabPage serverTabPage;
            this.ServerListBox = new System.Windows.Forms.ListBox();
            this.LocalTabControl = new System.Windows.Forms.TabControl();
            this.cTabPage = new System.Windows.Forms.TabPage();
            this.CDriveListBox = new System.Windows.Forms.ListBox();
            this.dTabPage = new System.Windows.Forms.TabPage();
            this.DDriveListBox = new System.Windows.Forms.ListBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ServerTabControl = new System.Windows.Forms.TabControl();
            serverTabPage = new System.Windows.Forms.TabPage();
            ServerTabControl.SuspendLayout();
            serverTabPage.SuspendLayout();
            this.LocalTabControl.SuspendLayout();
            this.cTabPage.SuspendLayout();
            this.dTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerTabControl
            // 
            ServerTabControl.Controls.Add(serverTabPage);
            ServerTabControl.Location = new System.Drawing.Point(12, 12);
            ServerTabControl.Name = "ServerTabControl";
            ServerTabControl.SelectedIndex = 0;
            ServerTabControl.Size = new System.Drawing.Size(315, 685);
            ServerTabControl.TabIndex = 0;
            // 
            // serverTabPage
            // 
            serverTabPage.Controls.Add(this.ServerListBox);
            serverTabPage.Location = new System.Drawing.Point(4, 22);
            serverTabPage.Name = "serverTabPage";
            serverTabPage.Padding = new System.Windows.Forms.Padding(3);
            serverTabPage.Size = new System.Drawing.Size(307, 659);
            serverTabPage.TabIndex = 0;
            serverTabPage.Text = "Server";
            serverTabPage.UseVisualStyleBackColor = true;
            // 
            // ServerListBox
            // 
            this.ServerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerListBox.FormattingEnabled = true;
            this.ServerListBox.Location = new System.Drawing.Point(3, 3);
            this.ServerListBox.Name = "ServerListBox";
            this.ServerListBox.Size = new System.Drawing.Size(298, 650);
            this.ServerListBox.TabIndex = 0;
            this.ServerListBox.SelectedIndexChanged += new System.EventHandler(this.ServerListBox_SelectedIndexChanged);
            // 
            // LocalTabControl
            // 
            this.LocalTabControl.Controls.Add(this.cTabPage);
            this.LocalTabControl.Controls.Add(this.dTabPage);
            this.LocalTabControl.Location = new System.Drawing.Point(414, 12);
            this.LocalTabControl.Name = "LocalTabControl";
            this.LocalTabControl.SelectedIndex = 0;
            this.LocalTabControl.Size = new System.Drawing.Size(315, 685);
            this.LocalTabControl.TabIndex = 1;
            // 
            // cTabPage
            // 
            this.cTabPage.Controls.Add(this.CDriveListBox);
            this.cTabPage.Location = new System.Drawing.Point(4, 22);
            this.cTabPage.Name = "cTabPage";
            this.cTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cTabPage.Size = new System.Drawing.Size(307, 659);
            this.cTabPage.TabIndex = 0;
            this.cTabPage.Text = "C: Drive";
            this.cTabPage.UseVisualStyleBackColor = true;
            // 
            // CDriveListBox
            // 
            this.CDriveListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDriveListBox.FormattingEnabled = true;
            this.CDriveListBox.Location = new System.Drawing.Point(3, 4);
            this.CDriveListBox.Name = "CDriveListBox";
            this.CDriveListBox.Size = new System.Drawing.Size(301, 650);
            this.CDriveListBox.TabIndex = 1;
            this.CDriveListBox.SelectedIndexChanged += new System.EventHandler(this.CDriveListBox_SelectedIndexChanged);
            // 
            // dTabPage
            // 
            this.dTabPage.Controls.Add(this.DDriveListBox);
            this.dTabPage.Location = new System.Drawing.Point(4, 22);
            this.dTabPage.Name = "dTabPage";
            this.dTabPage.Size = new System.Drawing.Size(307, 659);
            this.dTabPage.TabIndex = 1;
            this.dTabPage.Text = "D: Drive";
            this.dTabPage.UseVisualStyleBackColor = true;
            // 
            // DDriveListBox
            // 
            this.DDriveListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DDriveListBox.FormattingEnabled = true;
            this.DDriveListBox.Location = new System.Drawing.Point(3, 4);
            this.DDriveListBox.Name = "DDriveListBox";
            this.DDriveListBox.Size = new System.Drawing.Size(301, 650);
            this.DDriveListBox.TabIndex = 1;
            this.DDriveListBox.SelectedIndexChanged += new System.EventHandler(this.DDriveListBox_SelectedIndexChanged);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Location = new System.Drawing.Point(333, 333);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Enabled = false;
            this.UploadButton.Location = new System.Drawing.Point(333, 362);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(333, 425);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(333, 270);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshGameLists);
            // 
            // GameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 709);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.LocalTabControl);
            this.Controls.Add(ServerTabControl);
            this.Name = "GameManager";
            this.Text = "Game Manager";
            ServerTabControl.ResumeLayout(false);
            serverTabPage.ResumeLayout(false);
            this.LocalTabControl.ResumeLayout(false);
            this.cTabPage.ResumeLayout(false);
            this.dTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LocalTabControl;
        private System.Windows.Forms.TabPage cTabPage;
        private System.Windows.Forms.TabPage dTabPage;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox CDriveListBox;
        private System.Windows.Forms.ListBox DDriveListBox;
        private System.Windows.Forms.ListBox ServerListBox;
        private System.Windows.Forms.Button RefreshButton;
    }
}

