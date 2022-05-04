using System;

namespace Task_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var User = Anketa();

            Console.WriteLine("Вас зовут: {0} {1}", User.Name, User.LastName);
            Console.WriteLine("Ваш возраст: {0}", User.Age);

            

            static (string Name, string LastName, int Age) Anketa()
            {
                (string Name, string LastName, int Age) User;

                Console.WriteLine("Введите ваше имя: ");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите вашу фамилию: ");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите ваше возраст: ");
                User.Age = int.Parse(Console.ReadLine());

                //Питомцы

                Console.WriteLine("Есть ли у вас домашние питомцы? ");
                string Animals = Console.ReadLine();

                if ((Animals == "Да") || (Animals == "да"))
                {
                    Console.WriteLine("Сколько у вас домашних питомце? ");
                    int num = int.Parse(Console.ReadLine());

                    HousePet(num);

                }

                //Цвета

                Console.WriteLine("Введите количество любимых цветов ");
                int NumColors = int.Parse(Console.ReadLine());

                if (NumColors > 0)
                {
                    Colors(NumColors);
                }
                return User;
            }

            static string[] HousePet(int num)
            {
                string[] Pet = new string[num];

                Console.WriteLine("Перечислите их клички:");

                for (int i = 0; i < Pet.Length; i++)
                {
                    Pet[i] = Console.ReadLine();
                }

                return Pet;
            }

            static string[] Colors(int NumColors)
            {
                string[] FavColors = new string[NumColors];

                Console.WriteLine("Перечислите любимые цвета:");

                for (int i = 0; i < FavColors.Length; i++)
                {
                    FavColors[i] = Console.ReadLine();
                }

                return FavColors;
            }

           
        }
    }
}
