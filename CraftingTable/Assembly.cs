using System;
using System.Collections.Generic;
using System.Text;

namespace CraftingTable
{
    public class Assembly
    {
        public static void ToAssembly(Tool tool)
        {
            switch (tool.GetTotalIndex())
            {
                // Топор
                case 20:
                    switch (tool.GetTotalWeight())
                    {
                        case 6430:
                            Console.WriteLine("Каменный топор");
                            break;
                        case 7000:
                            Console.WriteLine("Алмазный топор");
                            break;
                        case 7600:
                            Console.WriteLine("Железный топор");
                            break;
                        case 8800:
                            Console.WriteLine("Золотой топор");
                            break;
                        case 11200:
                            Console.WriteLine("Мифриловый топор");
                            break;
                    }
                    break;
                // Кирка
                case 19:
                    switch (tool.GetTotalWeight())
                    {
                        case 6430:
                            Console.WriteLine("Каменная кирка");
                            break;
                        case 7000:
                            Console.WriteLine("Алмазная кирка");
                            break;
                        case 7600:
                            Console.WriteLine("Железная кирка");
                            break;
                        case 8800:
                            Console.WriteLine("Золотая кирка");
                            break;
                        case 11200:
                            Console.WriteLine("Мифриловая кирка");
                            break;
                    }
                    break;
                // Мотыга
                case 16:
                    switch (tool.GetTotalWeight())
                    {
                        case 6420:
                            Console.WriteLine("Каменная мотыга");
                            break;
                        case 6800:
                            Console.WriteLine("Алмазная мотыга");
                            break;
                        case 7200:
                            Console.WriteLine("Железная мотыга");
                            break;
                        case 8000:
                            Console.WriteLine("Золотая мотыга");
                            break;
                        case 9600:
                            Console.WriteLine("Мифриловая мотыга");
                            break;
                    }
                    break;
                // Лопата
                case 15:
                    switch (tool.GetTotalWeight())
                    {
                        case 6410:
                            Console.WriteLine("Каменная лопата");
                            break;
                        case 6600:
                            Console.WriteLine("Алмазная лопата");
                            break;
                        case 6800:
                            Console.WriteLine("Железная лопата");
                            break;
                        case 7200:
                            Console.WriteLine("Золотая лопата");
                            break;
                        case 8000:
                            Console.WriteLine("Мифриловая лопата");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Нет подходящего рецепта");
                    break;
            }
        }
    }
}
