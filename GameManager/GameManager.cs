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
        private const string ServerDir = "\\\\WINDOWS-2000\\Games\\";
        private const string CDriveDir = "C:\\Games\\";
        private const string DDriveDir = "D:\\Games\\";

        public GameManager()
        {
            InitializeComponent();
            FileOperations.Manager = this;
            RefreshLists();
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string gameName = ServerListBox.SelectedItem.ToString();
            string sourceGameFolder = ServerDir + gameName;
            string destGameFolder = (LocalTabControl.SelectedIndex == 0 ? CDriveDir : DDriveDir) + gameName;

            if (Directory.Exists(destGameFolder))
            {
                if (!SendDeleteWarning(destGameFolder))
                    return;
                Directory.Delete(destGameFolder);
            }

            FileOperations.CopyGame(sourceGameFolder, destGameFolder);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            string gameName = (LocalTabControl.SelectedIndex == 0 ? CDriveListBox : DDriveListBox).SelectedItem.ToString();
            string sourceGameFolder = (LocalTabControl.SelectedIndex == 0 ? CDriveDir : DDriveDir) + gameName;
            string destGameFolder = ServerDir + gameName;

            if (Directory.Exists(destGameFolder))
            {
                if (!SendDeleteWarning(destGameFolder))
                    return;
                Directory.Delete(destGameFolder);
            }

            FileOperations.CopyGame(sourceGameFolder, destGameFolder);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string directory = null;
            if (ServerListBox.SelectedIndex >= 0)
                directory = ServerDir + ServerListBox.SelectedItem.ToString();
            else if (CDriveListBox.SelectedIndex >= 0)
                directory = CDriveDir + CDriveListBox.SelectedItem.ToString();
            else if (DDriveListBox.SelectedIndex >= 0)
                directory = DDriveDir + DDriveListBox.SelectedItem.ToString();

            if (SendDeleteWarning(directory))
            {
                string dirSize = FileOperations.GetDirectorySize(directory);
                SetOutput("Deleting " + FileOperations.GetGameName(directory) + " (" + dirSize + ")");
                Directory.Delete(directory, true);
                SetOutput("Successfully deleted " + FileOperations.GetGameName(directory) + " (" + dirSize + ")");
                RefreshLists();
            }
        }

        public void RefreshLists()
        {
            ServerListBox.Items.Clear();
            CDriveListBox.Items.Clear();
            DDriveListBox.Items.Clear();

            IEnumerable<string> serverFolders = Directory.EnumerateDirectories(ServerDir).OrderBy(s => s);
            IEnumerable<string> cDriveFolders = Directory.EnumerateDirectories(CDriveDir).OrderBy(s => s);
            IEnumerable<string> dDriveFolders = Directory.EnumerateDirectories(DDriveDir).OrderBy(s => s);

            foreach (string folder in serverFolders)
                ServerListBox.Items.Add(FileOperations.GetGameName(folder));

            foreach (string folder in cDriveFolders)
                CDriveListBox.Items.Add(FileOperations.GetGameName(folder));

            foreach (string folder in dDriveFolders)
                DDriveListBox.Items.Add(FileOperations.GetGameName(folder));
        }

        public void SetOutput(string text)
        {
            TextOutput.Text = text;
            TextOutput.Refresh();
        }

        private void SetButtons()
        {
            DownloadButton.Enabled = ServerListBox.SelectedIndex >= 0;
            UploadButton.Enabled = CDriveListBox.SelectedIndex >= 0 || DDriveListBox.SelectedIndex >= 0;
            DeleteButton.Enabled = ServerListBox.SelectedIndex >= 0 || CDriveListBox.SelectedIndex >= 0 || DDriveListBox.SelectedIndex >= 0;
        }

        private bool SendDeleteWarning(string directory)
        {
            return true;
        }
    }
}
