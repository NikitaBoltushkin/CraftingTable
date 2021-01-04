using System;

namespace CraftingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            Material[,] materials = new Material[rows, columns];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    materials[i, j] = new Material();
                }
            }
            
            while (true)
            {
                // Вывод таблицы
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"| {materials[i, j].GetName()} |\t");
                    }
                    Console.WriteLine();
                }
                Console.Write("\n1. Заполнить верстак\n2. Выполнить сборку\n0. Выход\nВыбор: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("\nВыберите ячейку или введите 0 для выхода\nВыбор: ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[0, 0] = new Material("Stone",1, 10);
                                        break;
                                    case "2":
                                        materials[0, 0] = new Material("Diamond", 1, 200);
                                        break;
                                    case "3":
                                        materials[0, 0] = new Material("Iron", 1, 400);
                                        break;
                                    case "4":
                                        materials[0, 0] = new Material("Gold", 1, 800);
                                        break;
                                    case "5":
                                        materials[0, 0] = new Material("Mithril", 1, 1600);
                                        break;
                                    case "6":
                                        materials[0, 0] = new Material("Wood", 1, 3200);
                                        break;
                                    case "7":
                                        materials[0, 0] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "2":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[0, 1] = new Material("Stone", 2, 10);
                                        break;
                                    case "2":
                                        materials[0, 1] = new Material("Diamond", 2, 200);
                                        break;
                                    case "3":
                                        materials[0, 1] = new Material("Iron", 2, 400);
                                        break;
                                    case "4":
                                        materials[0, 1] = new Material("Gold", 2, 800);
                                        break;
                                    case "5":
                                        materials[0, 1] = new Material("Mithril", 2, 1600);
                                        break;
                                    case "6":
                                        materials[0, 1] = new Material("Wood", 2, 3200);
                                        break;
                                    case "7":
                                        materials[0, 1] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "3":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[0, 2] = new Material("Stone", 3, 10);
                                        break;
                                    case "2":
                                        materials[0, 2] = new Material("Diamond", 3, 200);
                                        break;
                                    case "3":
                                        materials[0, 2] = new Material("Iron", 3, 400);
                                        break;
                                    case "4":
                                        materials[0, 2] = new Material("Gold", 3, 800);
                                        break;
                                    case "5":
                                        materials[0, 2] = new Material("Mithril", 3, 1600);
                                        break;
                                    case "6":
                                        materials[0, 2] = new Material("Wood", 3, 3200);
                                        break;
                                    case "7":
                                        materials[0, 2] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "4":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[1, 0] = new Material("Stone", 4, 10);
                                        break;
                                    case "2":
                                        materials[1, 0] = new Material("Diamond", 4, 200);
                                        break;
                                    case "3":
                                        materials[1, 0] = new Material("Iron", 4, 400);
                                        break;
                                    case "4":
                                        materials[1, 0] = new Material("Gold", 4, 800);
                                        break;
                                    case "5":
                                        materials[1, 0] = new Material("Mithril", 4, 1600);
                                        break;
                                    case "6":
                                        materials[1, 0] = new Material("Wood", 4, 3200);
                                        break;
                                    case "7":
                                        materials[1, 0] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "5":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[1, 1] = new Material("Stone", 5, 10);
                                        break;
                                    case "2":
                                        materials[1, 1] = new Material("Diamond", 5, 200);
                                        break;
                                    case "3":
                                        materials[1, 1] = new Material("Iron", 5, 400);
                                        break;
                                    case "4":
                                        materials[1, 1] = new Material("Gold", 5, 800);
                                        break;
                                    case "5":
                                        materials[1, 1] = new Material("Mithril", 5, 1600);
                                        break;
                                    case "6":
                                        materials[1, 1] = new Material("Wood", 5, 3200);
                                        break;
                                    case "7":
                                        materials[1, 1] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "6":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[1, 2] = new Material("Stone", 6, 10);
                                        break;
                                    case "2":
                                        materials[1, 2] = new Material("Diamond", 6, 200);
                                        break;
                                    case "3":
                                        materials[1, 2] = new Material("Iron", 6, 400);
                                        break;
                                    case "4":
                                        materials[1, 2] = new Material("Gold", 6, 800);
                                        break;
                                    case "5":
                                        materials[1, 2] = new Material("Mithril", 6, 1600);
                                        break;
                                    case "6":
                                        materials[1, 2] = new Material("Wood", 6, 3200);
                                        break;
                                    case "7":
                                        materials[1, 2] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "7":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[2, 0] = new Material("Stone", 7, 10);
                                        break;
                                    case "2":
                                        materials[2, 0] = new Material("Diamond", 7, 200);
                                        break;
                                    case "3":
                                        materials[2, 0] = new Material("Iron", 7, 400);
                                        break;
                                    case "4":
                                        materials[2, 0] = new Material("Gold", 7, 800);
                                        break;
                                    case "5":
                                        materials[2, 0] = new Material("Mithril", 7, 1600);
                                        break;
                                    case "6":
                                        materials[2, 0] = new Material("Wood", 7, 3200);
                                        break;
                                    case "7":
                                        materials[2, 0] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "8":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[2, 1] = new Material("Stone", 8, 10);
                                        break;
                                    case "2":
                                        materials[2, 1] = new Material("Diamond", 8, 200);
                                        break;
                                    case "3":
                                        materials[2, 1] = new Material("Iron", 8, 400);
                                        break;
                                    case "4":
                                        materials[2, 1] = new Material("Gold", 8, 800);
                                        break;
                                    case "5":
                                        materials[2, 1] = new Material("Mithril", 8, 1600);
                                        break;
                                    case "6":
                                        materials[2, 1] = new Material("Wood", 8, 3200);
                                        break;
                                    case "7":
                                        materials[2, 1] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "9":
                                Console.Write("1.Камень\n2.Алмаз\n3.Железо\n4.Золото\n5.Мифрил\n6.Дерево\n7.Удалить элемент\n0.Выход\nВыберите материал:");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        materials[2, 2] = new Material("Stone", 9, 10);
                                        break;
                                    case "2":
                                        materials[2, 2] = new Material("Diamond", 9, 200);
                                        break;
                                    case "3":
                                        materials[2, 2] = new Material("Iron", 9, 400);
                                        break;
                                    case "4":
                                        materials[2, 2] = new Material("Gold", 9, 800);
                                        break;
                                    case "5":
                                        materials[2, 2] = new Material("Mithril", 9, 1600);
                                        break;
                                    case "6":
                                        materials[2, 2] = new Material("Wood", 9, 3200);
                                        break;
                                    case "7":
                                        materials[2, 2] = new Material();
                                        break;
                                    case "0":
                                        break;
                                }
                                break;
                            case "0":
                                break;
                        }
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Material blank = new Material();
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                blank += materials[i, j];
                            }
                        }
                        Tool tool = new Tool(blank.GetIndex(),blank.GetWeight());
                        Assembly.ToAssembly(tool);
                        Console.WriteLine("Нажмите для продолжения...");
                        Console.Read();
                        Console.Read();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Всего доброго!");
                        return;
                }
                
            }
        }
    }
}
