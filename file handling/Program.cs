class Program1
{
    static void Main()
    {
        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}


class Program2
{
    static void Main()
    {
        string filePath = "out.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            Console.WriteLine("Введите строки для записи в файл. Нажмите Enter на пустой строке для завершения.");

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                writer.WriteLine(input);
            }
        }

        Console.WriteLine($"Данные успешно записаны в файл {filePath}");
    }
}



class Program3
{
    static void Main()
    {
        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > 79)
                    {
                        line = line.Substring(0, 79);
                    }

                    Console.WriteLine(line);
                    lineCount++;

                    if (lineCount == 24)
                    {
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        lineCount = 0;
                    }
                }
            }
        }
    }
}
