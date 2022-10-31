using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace traning
{
    internal class Lemonade
    {
        public string Taste = string.Empty;
        public int Price;
        public void Check(string Size)
        {
            if (Taste == "Клубничный")
            {
                Price = 150;
            }
            if (Taste == "Манго")
            {
                Price = 150;
            }
            if (Taste == "Обычный")
            {
                Price = 125;
            }
            string TextCheck = "Лимонад " + Size;
            Console.WriteLine(TextCheck);
            File.AppendAllText("D:\\Code_project\\traning\\traning\\Order.txt", TextCheck);
            Program.CheckOrderPrice(Price);
        }
    }
}
