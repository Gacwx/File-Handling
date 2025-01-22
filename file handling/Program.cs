//class Program1
//{
//    static void Main()
//    {
//        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            string line;
//            while ((line = reader.ReadLine()) != null)
//            {
//                Console.WriteLine(line);
//            }
//        }
//    }
//}


//class Program2
//{
//    static void Main()
//    {
//        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            Console.WriteLine("Введите строки для записи в файл. Нажмите Enter на пустой строке для завершения.");

//            while (true)
//            {
//                string input = Console.ReadLine();

//                if (string.IsNullOrEmpty(input))
//                {
//                    break;
//                }

//                writer.WriteLine(input);
//            }
//        }

//        Console.WriteLine($"Данные успешно записаны в файл {filePath}");
//    }
//}



//class Program3
//{
//    static void Main()
//    {
//        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

//        if (File.Exists(filePath))
//        {
//            using (StreamReader reader = new StreamReader(filePath))
//            {
//                string line;
//                int lineCount = 0;

//                while ((line = reader.ReadLine()) != null)
//                {
//                    if (line.Length > 79)
//                    {
//                        line = line.Substring(0, 79);
//                    }

//                    Console.WriteLine(line);
//                    lineCount++;

//                    if (lineCount == 24)
//                    {
//                        Console.WriteLine("Press Enter to continue...");
//                        Console.ReadLine();
//                        lineCount = 0;
//                    }
//                }
//            }
//        }
//    }
//}


//class FileSplitter
//{
//    static void Main(string[] args)
//    {
//        string filePath = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";
//        int chunkSize = 5120;

//        try
//        {
//            FileStream inputFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
//            byte[] buffer = new byte[chunkSize];
//            int bytesRead;
//            int part = 0;

//            while ((bytesRead = inputFile.Read(buffer, 0, chunkSize)) > 0)
//            {
//                string partFileName = Path.GetFileNameWithoutExtension(filePath);
//                FileStream outputFile = new FileStream(partFileName, FileMode.Create, FileAccess.Write);

//                outputFile.Write(buffer, 0, bytesRead);
//                outputFile.Close();

//                Console.WriteLine("Created: " + partFileName);
//                part++;
//            }
//            inputFile.Close();
//            Console.WriteLine("Splitting is done.");
//        }

//        catch (Exception e)
//        {
//            Console.WriteLine("Error" + e.Message);
//        }
//    }
//}


class FileCopier
{
    static void Main(string[] args)
    {
        string sourceFile = "C:\\Users\\Acer\\source\\repos\\file handling\\input.txt";

        string destinationFile = "C:\\Users\\Acer\\source\\repos\\file handling\\copy.txt";

        try
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open))
            using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create))
            {
                byte[] buffer = new byte[512 * 1024];
                int bytesRead;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }

    }
}