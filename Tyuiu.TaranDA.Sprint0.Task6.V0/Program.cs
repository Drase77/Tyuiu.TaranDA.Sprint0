using Tyuiu.TaranDA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TaranDA.Sprint0.Task6.V0
{

    class program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массивов = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}