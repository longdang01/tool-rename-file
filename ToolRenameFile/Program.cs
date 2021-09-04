using System;
using System.IO;
using System.Text;

namespace ToolRenameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tool đổi tên file (1 loạt theo định dạng [fileName_+ STT(0->)])");
            Console.WriteLine("<!> Lưu ý không nhập path có chứa tiếng việt");
            Console.Write("Bạn nhập path: ");
            string path = Console.ReadLine();
            Console.Write("Tên file: ");
            string fileName = Console.ReadLine();
            Console.Write("Đuôi file: ");
            string extension = Console.ReadLine();

            string[] fileArray = Directory.GetFiles(@path, $"*.{extension}", SearchOption.AllDirectories);
            int run = 0;
            foreach (string f in fileArray)
            {
                File.Move(f, $"{path}\\{fileName}_" + run + $".{extension}");
                run++;
            }
        }
    }
}
