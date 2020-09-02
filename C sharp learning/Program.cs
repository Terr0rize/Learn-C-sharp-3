using System;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            Random randNum = new Random();


            int num;
            num = randNum.Next(1, 6); //рандом от 1 до 5
            switch (num)
            {
                case 1:
                    Console.WriteLine("Num is - " + num);
                    break;
                case 2:
                    Console.WriteLine("Num is - " + num);
                    break;
                case 3:
                    Console.WriteLine("Num is - " + num);
                    break;
                default:
                    Console.WriteLine("Whoops. Number < 5");
                    break;
            }

           
        }
    }
}
