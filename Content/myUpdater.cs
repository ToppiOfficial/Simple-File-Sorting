using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simple_File_Sorting.Content
{
    internal class myUpdater
    {
        public void CheckForUpdates()
        {
            string githubVersionUrl = "https://github.com/ToppiOfficial/SimpleFileSorting/blob/master/version.txt";
            string githubExecutableUrl = "https://github.com/ToppiOfficial/SimpleFileSorting/releases/download/v{0}/SimpleFileSorting.exe";
            string localVersion = myVariables.applicationBuild;
            string latestVersion = "";

            using (WebClient client = new WebClient())
            {
                try
                {
                    latestVersion = client.DownloadString(githubVersionUrl).Trim();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking for updates: " + ex.Message);
                }
            }

            if (latestVersion != "" && latestVersion != localVersion)
            {
                MessageBox.Show("New Update Detected");
                string updatedExecutableUrl = string.Format(githubExecutableUrl, latestVersion);
                string tempPath = Path.Combine(Path.GetTempPath(), "SimpleFileSorting_temp.exe");

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        MessageBox.Show("Test");
                       // client.DownloadFile(updatedExecutableUrl, tempPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading updated executable: " + ex.Message);
                    }
                }

                try
                {
                    string currentExecutablePath = AppDomain.CurrentDomain.FriendlyName;
                    File.Replace(tempPath, currentExecutablePath, null, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error replacing executable: " + ex.Message);
                }
            }
        }
    }
}
