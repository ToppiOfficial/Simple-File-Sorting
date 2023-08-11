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
        private const string GithubVersionUrl = "https://raw.githubusercontent.com/ToppiOfficial/SimpleFileSorting/testing/version.txt";

        public void CheckForUpdates()
        {
            try
            {
                Version localVersion = new Version(myVariables.applicationBuild);
                Version latestVersion = new Version(GetLatestVersion());

                if (latestVersion > localVersion)
                {
                    MessageBox.Show($"New Update Detected: Current Ver: {localVersion}. New Ver: {latestVersion}");
                }
            }
            catch { }
        }

        private string GetLatestVersion()
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetStringAsync(GithubVersionUrl).Result.Trim();
            }
        }
    }
}
