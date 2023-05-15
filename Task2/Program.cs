using System.Security.Cryptography.X509Certificates;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Sorter sorter = new Sorter();
            sorter.families = new List<string>
            {
                "Петров",
                "Иванов",
                "Алексеев",
                "Щудров",
                "Виноградов",
                "Пончиков"

            };

            sorter.SorterFamilyEvent += Sorting;

            while (true)
            {
                try
                {
                    sorter.CheckNumber();
                }
                catch (FormatException)
                {

                    Console.WriteLine("\nВведено неверное значение\n");
                }
            }
        }

        public static void Sorting(List<string> families, int number)
        {
            if (number == 1)
            {
                families.Sort();
                foreach (var f in families)
                    Console.WriteLine(f);
                Console.WriteLine();
                Console.WriteLine("Массив отсортирован по алфовиту\n");

            }
            else
            {
                families.Sort();
                families.Reverse();
                foreach(var f in families)
                    Console.WriteLine(f);
                Console.WriteLine();
                Console.WriteLine("Массив отсортирован обратном алфовитном порядке\n");

            }


        }
    }
}