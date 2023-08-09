using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_File_Sorting.Content
{
    public class myVariables
    {
        public static string applicationBuild = "1.0";
    }
    public class fileFormats
    {
        public string fileFormat { get; set; }

        public fileFormats(string _fileformat)
        {
            fileFormat = _fileformat;
        }
    }

    public class folderCategories
    {
        public string folderCategory { get; set; }
        public List<fileFormats> fileFormats { get; set; }

        public folderCategories(string _folderCategory)
        {
            folderCategory = _folderCategory;
            fileFormats = new List<fileFormats>();
        }

        public void AddFormat(string formatName)
        {
            fileFormats.Add(new fileFormats(formatName));
        }
    }
}
