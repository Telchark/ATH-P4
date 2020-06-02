using System;
using System.IO;

namespace WpfApp
{
    public class FileDataProvider
    {
        public int GetData()
        {
            var content = File.ReadAllText("File.txt");
            var lines = content.Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return Convert.ToInt32(lines[0]);

        }
    }
}
