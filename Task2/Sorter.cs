using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    #region Comment

    /*    1. Не понял как использовать несколько методов для вызова их в событии Invoke
           * К примеру хотел реализовать 2 метода сортировки: Asc и Desc, но при вызове их в invoke
          обращение происходит только к одному методу, который был первым добавлен      

          2. Не прохоидили еще интерфесы, сортировку объектов как я понимаю нужно делать именно через них
          (почитал в инете) поэтому список типа стринг
     */
    #endregion

    public delegate void SorterFamily(List<string> families, int number);                         
    public class Sorter
    {
        public event SorterFamily SorterFamilyEvent;
        public List<string> families;


        public void CheckNumber()
        {
            
            Console.WriteLine("1.Сортировка по алфовиту от А-Я");
            Console.WriteLine("2.Сортировка в обратном алфовитном порядке: Я-А");
            Console.Write("Введите значение сортировки: 1 или 2: ");
            int number = int.Parse(Console.ReadLine());
            if (number != 1 && number != 2)
                throw new FormatException();

            OnGoSort(families, number);

        }

        protected virtual void OnGoSort(List<string> families, int number)
        {
            SorterFamilyEvent?.Invoke(families, number);


        }


    }

   
}
