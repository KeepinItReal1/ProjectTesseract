using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Drawing;

namespace ProjectTesseract
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ConvertImageToText();
        }
        public void ConvertImageToText()
        {
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.Lithuanian);
                string plainText = api.GetTextFromImage("C:\\Users\\justas\\source\\repos\\ProjectTesseract\\ProjectTesseract\\Test3.jpg");
    
                Console.WriteLine(plainText);
                Console.Read();
            }
        }
    }
}