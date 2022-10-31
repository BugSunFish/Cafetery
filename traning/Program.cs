using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace traning
{
    internal class Program
    {
        public static int OrderPrice;
        public static void CheckOrderPrice(int CurrentProduct)
        {
            OrderPrice += CurrentProduct;
            Console.WriteLine(CurrentProduct);
            File.AppendAllText("D:\\Code_project\\traning\\traning\\Order.txt", "\n" + CurrentProduct + "\n");
        }
        static void Main(string[] args)
        {
            File.WriteAllText("D:\\Code_project\\traning\\traning\\Order.txt", "--Your Order--" + "\n");
            Console.SetWindowSize(100, 20);
            Console.Title = "Cafe";
            Console.WriteLine("--Your Order--");
            List<string> Order = new List<string>();

            Pizza hunter = new Pizza();
            Pizza cezar = new Pizza();

            Lemonade strawberry = new Lemonade();
            Lemonade mango = new Lemonade();

            Potato villager = new Potato();
            Potato free = new Potato();

            hunter.Name = "Охотничая";
            hunter.Size = "Средняя";
            hunter.Check(hunter.Size);

            cezar.Name = "Цезарь";
            cezar.Size = "Маленькая";
            cezar.Check(cezar.Size);

            strawberry.Taste = "Клубничный";
            strawberry.Check(strawberry.Taste);

            mango.Taste = "Манго";
            mango.Check(mango.Taste);

            villager.Type = "Деревенская";
            villager.Check(villager.Type);

            free.Type = "Фри";
            free.Check(free.Type);

            Console.WriteLine("Итоговая цена\n" + OrderPrice);
            File.AppendAllText("D:\\Code_project\\traning\\traning\\Order.txt", "Итоговая цена\n" + OrderPrice);
        } 
    }
}
