using System;

namespace Lucky_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Введите пожалуйста число, содержащее 4-8 цифр. Или exit для выхода.");
                string writeInConsole = Console.ReadLine();
                Console.WriteLine();

                int numberTicket;

                if (writeInConsole == "exit")
                {
                    Console.WriteLine("Выход");
                    exit = true;
                }
                else if (int.TryParse(writeInConsole, out numberTicket))
                {

                    if (numberTicket >= 1000 && numberTicket < 100000000)
                    {

                        int n = (int)Math.Ceiling((decimal)writeInConsole.Length / 2);

                        int firstNumbers = (int)(Math.Floor(numberTicket / (Math.Pow(10, n))));
                        int lastNumbers = (int)(numberTicket % (Math.Pow(10, n)));


                        if(Sum(firstNumbers) == Sum(lastNumbers))
                        {
                            Console.WriteLine("\tПриветствую Вас! Ваш билет является удачным!)");
                        }
                        else
                        {
                            Console.WriteLine("\tК сожалению ваш билет является неудачным(");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\tВаш билет не соответствует условию (4-8 цифр)!!!");
                    }
                }
                else
                {
                    Console.WriteLine("\tНекорректные входные данные!");
                }

                Console.WriteLine("\n####################################################################\n\n");
            }
        }

        static int Sum(int value)
        {
            if (value < 10)
            {
                return value;
            }

            return (value % 10) + Sum(value / 10);
        }
    }

}
