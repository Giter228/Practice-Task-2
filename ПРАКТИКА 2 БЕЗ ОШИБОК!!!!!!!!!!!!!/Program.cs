using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ПРАКТИКА_2_БЕЗ_ОШИБОК_____________
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите программу, которую хотите запустить:");
                Console.WriteLine("1 - Угадай число.\n2 - Таблица умножения.\n3 - Вывод делителей числа.\n4 - Закрыть программу");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    TryNumber();
                }
                if (number == 2)
                {
                    Table();
                }
                if (number == 3)
                {
                    Delitel();
                }
                if (number == 4)
                {
                    Console.WriteLine("Выход..");
                    break;
                }
            }
        }

        static void TryNumber()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            Console.WriteLine("Привет! Ты зашёл в игру - Угадай число! Давай поиграем");
            Console.WriteLine("Введите число от 0 до 100 - ");
            string vvod = Console.ReadLine();
            int convert_vvod = Convert.ToInt32(vvod);
            while (random != convert_vvod)
            {
                if (random > convert_vvod)
                {
                    Console.WriteLine("Введите число больше - ");
                    convert_vvod = Convert.ToInt32(Console.ReadLine());
                }

                if (random < convert_vvod)
                {
                    Console.WriteLine("Введите число меньше -");
                    convert_vvod = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Молодец. Число успешно угадано!");
        }
        
        static void Table()
        {
            Console.WriteLine("Таблица умножения: ");
            string[,] table = new string[11,11]
            { {"-", "1","2", "3", "4", "5", "6", "7", "8", "9","10"},
              {"1", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"},
              {"2", "2", "4", "6", "8", "10", "12", "14", "16", "18", "20"},
              {"3", "3", "6", "9", "12", "15", "18", "21", "24", "27", "30"},
              {"4", "4", "8", "12", "16", "20", "24", "28", "32", "36", "40"},
              {"5", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50"},
              {"6", "6", "12", "18", "24", "30", "36", "42", "48", "54", "60"},
              {"7", "7", "14", "21", "28", "35", "42", "49", "56", "63", "70"},
              {"8", "8", "16", "24", "32", "40", "48", "56", "64", "72", "80"},
              {"9", "9", "18", "27", "36", "45", "54", "63", "72", "81", "90"},
              {"10", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"}};
            for (int m = 0; m < table.GetLength(0); m++) // для рядов
            {
                for (int n = 0; n < table.GetLength(1); n++) // для столбцов
                {
                    Console.Write(table[m,n] + "\t");
                }
                Console.WriteLine("\n");
            }
            
        }

        static void Delitel()
        {
            while (true)
            {
                Console.WriteLine("Если хотите выйти, напишите слово'выйти'.");
                string chislo = Console.ReadLine();
                if (chislo == "выйти" || chislo == "Выйти" || chislo == "dsqnb" || chislo == "Dsqnb")
                {
                    Console.WriteLine("Вы вышли из программы.");
                    break;
                }  
                Console.WriteLine("Введите число - ");
                int chislo2 = Convert.ToInt32(Console.ReadLine());
                int x = 0;
                if (x < chislo2)
                {
                    for (int y = 1; y <= chislo2; y++) // перебирание самих делителей
                    {
                        if (chislo2 % y == 0)
                        {
                            Console.Write(y + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}