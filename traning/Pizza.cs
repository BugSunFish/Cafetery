using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace traning
{
    internal class Pizza
    {
        public string Size = string.Empty;
        public string Name = string.Empty;
        private int Price;
        public void Check(string Size)
        {
            if (Size == "Большая")
            {
                Price = 200;
            }
            if (Size == "Средняя")
            {
                Price = 100;
            }
            if (Size == "Маленькая")
            {
                Price = 75;
            }
            string TextCheck = "Пицца " + Size + " " + Name;
            Console.WriteLine(TextCheck);
            File.AppendAllText("D:\\Code_project\\traning\\traning\\Order.txt", TextCheck);
            Program.CheckOrderPrice(Price);
        }
    }
}
