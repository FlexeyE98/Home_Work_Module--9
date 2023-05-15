namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Exception> exceptions = new List<Exception>()
            {
               new ArgumentException(),
               new ArgumentNullException(),
               new DivideByZeroException(),
               new ArgumentNullException(),
               new MyException("Упс. Ошибка вышла. Вы словили исключение")
            };

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            Console.ReadLine();
        }
    }
}