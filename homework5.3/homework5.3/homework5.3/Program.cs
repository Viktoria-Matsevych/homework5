using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Task4");

Console.WriteLine("--- Перегляд файлової системи ---");
Console.Write("Введіть повний шлях до каталогу (або назву папки, наприклад, MyFolder): ");
string inputPath = Console.ReadLine();

//Перевіряємо, чи існує вказаний каталог
if (Directory.Exists(inputPath))
{
    try
    {
        Console.WriteLine($"--- Вміст каталогу: {inputPath} ---");

        //Отримуємо та виводимо список усіх підкаталогів (папок)
        string[] directories = Directory.GetDirectories(inputPath);
        Console.WriteLine($"\n[Папки] Знайдено: {directories.Length}");
        foreach (string dir in directories)
        {
            // Path.GetFileName повертає лише назву папки, а не весь довгий шлях
            Console.WriteLine($"{Path.GetFileName(dir)}");
        }

        //Отримуємо та виводимо список усіх файлів
        string[] files = Directory.GetFiles(inputPath);
        Console.WriteLine($"\n[Файли] Знайдено: {files.Length}");
        foreach (string file in files)
        {
            // Path.GetFileName повертає лише ім'я файлу з розширенням
            Console.WriteLine($"{Path.GetFileName(file)}");
        }
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("[Помилка] Відмовлено в доступі до цього каталогу.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[Помилка] Не вдалося прочитати каталог: {ex.Message}");
    }
}
else
{
    //Повідомлення, якщо каталогу не існує
    Console.WriteLine($"[Помилка] Каталог за шляхом '{inputPath}' НЕ існує!");
}

Console.ReadLine(); // Затримка екрану