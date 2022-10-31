using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace traning
{
    internal class Potato
    {
        public string Type = string.Empty;
        public int Price;
        public void Check(string Size)
        {
            if (Type == "Деревенская")
            {
                Price = 75;
            }
            if (Type == "Фри")
            {
                Price = 60;
            }
            string TextCheck = "Картошка " + Size;
            Console.WriteLine(TextCheck);
            File.AppendAllText("D:\\Code_project\\traning\\traning\\Order.txt", TextCheck);
            Program.CheckOrderPrice(Price);
        }
    }
}
