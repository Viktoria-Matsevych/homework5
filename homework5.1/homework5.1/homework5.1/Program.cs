using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//Визначаємо шляхи до каталогів
string mainFolder = "MyFolder";
string docsFolder = Path.Combine(mainFolder, "Documents");
string imagesFolder = Path.Combine(mainFolder, "Images");

Console.WriteLine("=== Створення та перевірка каталогів ===\n");

try
{
    // 1. Створення головного каталогу MyFolder
    if (!Directory.Exists(mainFolder))
    {
        Directory.CreateDirectory(mainFolder);
        Console.WriteLine($"[Успішно] Створено головний каталог: {mainFolder}");
    }
    else
    {
        Console.WriteLine($"[Інфо] Каталог {mainFolder} вже існує.");
    }

    // 2. Створення підкаталогів всередині MyFolder
    if (!Directory.Exists(docsFolder))
    {
        Directory.CreateDirectory(docsFolder);
        Console.WriteLine($"[Успішно] Створено підкаталог: {docsFolder}");
    }

    if (!Directory.Exists(imagesFolder))
    {
        Directory.CreateDirectory(imagesFolder);
        Console.WriteLine($"[Успішно] Створено підкаталог: {imagesFolder}");
    }

    // 3. Перевірка існування кожного каталогу та виведення фінального статусу
    Console.WriteLine("\n--- Перевірка статусу каталогів ---");
    CheckDirectoryStatus(mainFolder);
    CheckDirectoryStatus(docsFolder);
    CheckDirectoryStatus(imagesFolder);
}
catch (Exception ex)
{
    Console.WriteLine($"\n[Помилка] Сталася помилка при роботі з диском: {ex.Message}");
}

Console.ReadLine(); // Затримка екрану
   

    // Допоміжний метод для перевірки існування та виведення повідомлення
    static void CheckDirectoryStatus(string path)
{
    if (Directory.Exists(path))
    {
        Console.WriteLine($"Каталог '{path}' — ІСНУЄ.");
    }
    else
    {
        Console.WriteLine($"Каталог '{path}' — НЕ знайдено.");
    }
}