using System.Diagnostics;
using System.Security;

namespace CopyDirectories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string srcPath;
        public string destinationPath;
        public List<Task> tasks=new List<Task>();
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"copying {srcPath} to {destinationPath} started");
            tasks.Add(Task.Factory.StartNew(() => CopyDirectory(srcPath,destinationPath,true)));
            Task.WhenAll(tasks);
        }
        void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            try
            {
                var dir = new DirectoryInfo(sourceDir);
                DirectoryInfo[] dirs = dir.GetDirectories();
                Directory.CreateDirectory(destinationDir);
                foreach (FileInfo file in dir.GetFiles())
                {
                    string targetFilePath = Path.Combine(destinationDir, file.Name);
                    file.CopyTo(targetFilePath);
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subDir in dirs)
                    {
                        string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                        CopyDirectory(subDir.FullName, newDestinationDir, true);
                    }
                }
                Debug.WriteLine($"copying {srcPath} to {destinationPath} complited successfully");
            }
            catch (ArgumentNullException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (DirectoryNotFoundException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (SecurityException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (ArgumentException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
            catch (NotSupportedException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("copying failed");
            }
        }

        private void srcDirectory_TextChanged(object sender, EventArgs e)
        {
            srcPath = srcDirectory.Text;
        }

        private void destionationDirectory_TextChanged(object sender, EventArgs e)
        {
            destinationPath= destionationDirectory.Text;
        }
    }
}