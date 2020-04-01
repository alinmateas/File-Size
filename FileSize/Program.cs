using System;
using System.IO;
using System.Text;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            long theSize;

            String result = "";
            FileInfo fi1 = new FileInfo(args[0]);
            if (fi1.Exists) result += CalculateFileSize(fi1.Length);


        }

        private static string CalculateFileSize(long length)
        {
            StringBuilder sb = new StringBuilder();

            if (length >= 1073741824) sb.Append(length / 1073741824 + "GB");
            else if (length >= 1048576) sb.Append(length / 1048576 + "MB");
            else if (length >= 1024) sb.Append(length / 1024 + "KB");

            return sb.ToString();
        }
    }
}
