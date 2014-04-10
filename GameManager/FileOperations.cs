using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    static class FileOperations
    {
        public static GameManager Manager;

        public static void CopyGame(string sourceDir, string destDir)
        {
            string dirSize = GetDirectorySize(sourceDir);
            Manager.SetOutput("Copying " + GetGameName(sourceDir) + " (" + dirSize + ")");
            CopyDirectory(sourceDir, destDir);
            Manager.RefreshLists();
            Manager.SetOutput("Successfully copied " + GetGameName(sourceDir) + " (" + dirSize + ")");
        }

        public static string GetGameName(string folder)
        {
            string gameName = folder.Substring(folder.LastIndexOf('\\') + 1);
            /*if (File.Exists(folder + "\\game.txt"))
            {
                StreamReader sr = new StreamReader(folder + "\\game.txt");
                string line = sr.ReadLine();
                sr.Close();
                if (!String.IsNullOrWhiteSpace(line))
                    gameName = line;
            }*/
            return gameName;
        }

        public static string GetDirectorySize(string directory)
        {
            float dirSize = 0;
            FileInfo[] files = new DirectoryInfo(directory).GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            foreach (FileInfo file in files)
                dirSize += file.Length;

            return (dirSize / 1000000000F).ToString("##0.0#") + "GB";
        }

        private static void CopyDirectory(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);
            foreach (string subfolderDir in Directory.GetDirectories(sourceDir))
            {
                string subfolderName = subfolderDir.Substring(subfolderDir.LastIndexOf('\\') + 1);
                CopyDirectory(subfolderDir, destDir + "\\" + subfolderName);
            }

            foreach (String fileDir in Directory.GetFiles(sourceDir))
            {
                FileInfo file = new FileInfo(fileDir);
                file.CopyTo(destDir + "\\" + fileDir.Substring(fileDir.LastIndexOf('\\') + 1));
            }
        }
    }
}
