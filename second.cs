class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1) Игра 'Угадай число'");
            Console.WriteLine("2) Таблица умножения");
            Console.WriteLine("3) Выйти из программы");
            Console.Write("Выберите программу: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PlayGuessNumberGame();
                    break;
                case "2":
                    DisplayMultiplicationTable();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неправильный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void PlayGuessNumberGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        Console.WriteLine("Игра 'Угадай число'");
        Console.WriteLine("Угадайте число от 0 до 100.");

        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Введите ваше предположение: ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("Слишком маленькое число. Попробуйте снова.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Слишком большое число. Попробуйте снова.");
                }
                else
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber} за {attempts} попыток.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        } while (guess != randomNumber);
    }

    static void DisplayMultiplicationTable()
    {
        const int tableSize = 10;

        int[,] multiplicationTable = new int[tableSize, tableSize];

        // Заполнение таблицы умножения
        for (int i = 1; i <= tableSize; i++)
        {
            for (int j = 1; j <= tableSize; j++)
            {
                multiplicationTable[i - 1, j - 1] = i * j;
            }
        }

        Console.WriteLine("Таблица умножения:");

        // Вывод таблицы умножения
        for (int i = 1; i <= tableSize; i++)
        {
            for (int j = 1; j <= tableSize; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
