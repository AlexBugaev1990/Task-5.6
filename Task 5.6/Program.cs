using System;

namespace Task_5._6
{
    class Program
    {
        static void Main(string[] args)
        {

            var User = Anketa();

            Print(User);

            //Вывод на экран
            static void Print((string Name, string LastName, int Age, string[] Pet, string[] Colors) User)
            {
                Console.Clear();
                Console.WriteLine("Вас зовут: {0} {1}\nВаш возраст: {2}", User.Name, User.LastName, User.Age);

                if (User.Pet.Length > 0)
                {
                    Console.WriteLine("Клички ваших животных:");
                    for (int i = 0; i < User.Pet.Length; i++)
                    {
                        Console.WriteLine(User.Pet[i]);
                    }
                }
                Console.WriteLine("Ваши любимые цвета:");
                for (int i = 0; i < User.Colors.Length; i++)
                {
                    Console.WriteLine(User.Colors[i]);
                }

            }

            // Ввод данных с клавиатуры
            static (string Name, string LastName, int Age, string[] Pet, string[] Colors) Anketa()
            {
                (string Name, string LastName, int Age, string[] Pet, string[] Colors) User;

                Console.WriteLine("Введите ваше имя: ");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите вашу фамилию: ");
                User.LastName = Console.ReadLine();

                string age;
                int intage;
                do
                {
                    Console.WriteLine("Введите ваше возраст: ");
                    age = Console.ReadLine();
                } while (ChekNum(age, out intage));
                User.Age = intage;

                //Питомцы 

                Console.WriteLine("Есть ли у вас домашние питомцы? ");
                string Animals = Console.ReadLine();
                User.Pet = new string[0];
                if ((Animals == "Да") || (Animals == "да"))
                {
                    Console.WriteLine("Сколько у вас домашних питомце? ");
                    int num = int.Parse(Console.ReadLine());

                    User.Pet = HousePet(num);

                }

                //Цвета 

                int numcolor = 0;

                do
                {
                    Console.WriteLine("Введите количество любимых цветов ");

                } while (ChekNum(Console.ReadLine(), out numcolor));
                User.Colors = new string[0];
                if (numcolor > 0)
                {
                    User.Colors = Colors(numcolor);
                }


                return User;
            }

            //Проверка на числа
            static bool ChekNum(string number, out int corrnumber)
            {
                if (int.TryParse(number, out int intnum))
                {
                    if (intnum > 0 && intnum < 120)
                    {
                        corrnumber = intnum;
                        return false;
                    }

                }
                corrnumber = 0;
                return true;
            }

            //Ввод питомцев
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

            //Ввод цветов
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