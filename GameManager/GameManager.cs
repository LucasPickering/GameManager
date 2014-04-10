using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameManager
{
    public partial class GameManager : Form
    {
        private const string serverDir = "\\\\WINDOWS-2000\\Games\\";
        private const string cDriveDir = "C:\\Games\\";
        private const string dDriveDir = "D:\\Games\\";

        public GameManager()
        {
            InitializeComponent();
            RefreshGameLists(null, null);
        }

        private void RefreshGameLists(object sender, EventArgs e)
        {
            ServerListBox.Items.Clear();
            CDriveListBox.Items.Clear();
            DDriveListBox.Items.Clear();

            IEnumerable<string> serverFolders = Directory.EnumerateDirectories(serverDir).OrderBy(s => s);
            IEnumerable<string> cDriveFolders = Directory.EnumerateDirectories(cDriveDir).OrderBy(s => s);
            IEnumerable<string> dDriveFolders = Directory.EnumerateDirectories(dDriveDir).OrderBy(s => s);

            foreach (string folder in serverFolders)
                ServerListBox.Items.Add(GetGameName(folder));

            foreach (string folder in cDriveFolders)
                CDriveListBox.Items.Add(GetGameName(folder));

            foreach (string folder in dDriveFolders)
                DDriveListBox.Items.Add(GetGameName(folder));
        }

        private string GetGameName(string folder)
        {
            string gameName = folder.Substring(folder.LastIndexOf('\\') + 1);
            if (File.Exists(folder + "\\game.txt"))
            {
                StreamReader sr = new StreamReader(folder + "\\game.txt");
                string line = sr.ReadLine();
                sr.Close();
                if (!String.IsNullOrWhiteSpace(line))
                    gameName = line;
            }
            return gameName;
        }

        private void SetButtons()
        {
            DownloadButton.Enabled = ServerListBox.SelectedIndex >= 0;
            UploadButton.Enabled = CDriveListBox.SelectedIndex >= 0 || DDriveListBox.SelectedIndex >= 0;
            DeleteButton.Enabled = ServerListBox.SelectedIndex >= 0 || CDriveListBox.SelectedIndex >= 0 || DDriveListBox.SelectedIndex >= 0;
        }

        private void ServerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServerListBox.SelectedIndex >= 0)
            {
                CDriveListBox.ClearSelected();
                DDriveListBox.ClearSelected();
                SetButtons();
            }
        }

        private void CDriveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CDriveListBox.SelectedIndex >= 0)
            {
                ServerListBox.ClearSelected();
                DDriveListBox.ClearSelected();
                SetButtons();
            }
        }

        private void DDriveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDriveListBox.SelectedIndex >= 0)
            {
                ServerListBox.ClearSelected();
                CDriveListBox.ClearSelected();
                SetButtons();
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string gameName = ServerListBox.GetItemText(ServerListBox.SelectedIndex);
            DirectoryInfo sourceFolder = 
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
