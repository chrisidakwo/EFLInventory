using System.IO;

namespace Inventory.Helpers {
    public static class IOHelpers {
        /// <summary>
        /// Create a folder
        /// </summary>
        /// <param name="applicationPathUrl"></param>
        /// <param name="folderPath"></param>
        public static DirectoryInfo CreateFolder(string folderPath) {
            DirectoryInfo directory = null;
            if (!Directory.Exists(folderPath)) {
                directory = Directory.CreateDirectory(folderPath);
            }
            return directory;
        }

        /// <summary>
        /// Copy folders and folder contents to a new destination
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="destFolder"></param>
        public static void CopyFolderContents(string sourceFolder, string destFolder) {
            if (!Directory.Exists(destFolder)) { Directory.CreateDirectory(destFolder); }
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files) {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders) {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolderContents(folder, dest);
            }
        }

        /// <summary>
        /// Empty a folder directory
        /// </summary>
        /// <param name="directory"></param>
        public static void Empty(this DirectoryInfo directory) {
            foreach (FileInfo file in directory.GetFiles()) { file.Delete(); }
            foreach (DirectoryInfo subDirectory in directory.GetDirectories()) { subDirectory.Delete(true); }
        }
    }
}