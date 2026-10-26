using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Визначаємо шлях до файлу ( всередині MyFolder/Documents )
string targetDirectory = Path.Combine("MyFolder", "Documents");
string filePath = Path.Combine(targetDirectory, "info.txt");

Console.WriteLine("=== Робота з текстовими файлами ===\n");

try
{
    // Перевіряємо, чи існує папка Documents (на випадок, якщо Завдання 2 не запускали)
    if (!Directory.Exists(targetDirectory))
    {
        Directory.CreateDirectory(targetDirectory);
    }

    // 1. Формуємо інформацію про користувача
    string firstName = "Вікторія"; // Вкажіть ваше ім'я
    string lastName = "Мацевич"; // Вкажіть ваше прізвище
    string group = "11-КН";       // Вкажіть вашу групу
    string creationDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

    string userLines = $"Ім'я: {firstName}\n" +
                       $"Прізвище: {lastName}\n" +
                       $"Навчальна група: {group}\n" +
                       $"Дата створення файлу: {creationDate}\n";

    // 2. Записуємо текст у файл (якщо файл існує, він буде перезаписаний)
    File.WriteAllText(filePath, userLines);
    Console.WriteLine($"[Успішно] Дані записано у файл: {filePath}");

    // 3. Перевіряємо існування файлу та виводимо його вміст
    Console.WriteLine("\n--- Перевірка та читання файлу ---");
    if (File.Exists(filePath))
    {
        Console.WriteLine($"Файл '{filePath}' — ІСНУЄ.\n");
        Console.WriteLine("Вміст файлу:");
        Console.WriteLine("-------------------------------------");

        // Зчитуємо та виводимо текст
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        Console.WriteLine("-------------------------------------");
    }
    else
    {
        Console.WriteLine($"[Помилка] Файл '{filePath}' не знайдено!");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"[Помилка] Щось пішло не так: {ex.Message}");
}

Console.ReadLine();