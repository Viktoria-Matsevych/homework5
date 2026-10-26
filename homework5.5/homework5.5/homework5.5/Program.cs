using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// Визначаємо шлях до папки bin
string bin = AppContext.BaseDirectory;

// Створюємо папки
string folder = Path.Combine(bin, "MyFolder");
string documents = Path.Combine(folder, "Documents");
string images = Path.Combine(folder, "Images");

Directory.CreateDirectory(folder);
Directory.CreateDirectory(documents);
Directory.CreateDirectory(images);

// Створюємо файл info.txt, якщо його немає
string file = Path.Combine(documents, "info.txt");

if (File.Exists(file))
{
    File.WriteAllText(file,
        "Ім'я: Учень\nПрізвище: Учень\nГрупа: 10 клас\nДата: "
        + DateTime.Now.ToString());
}

Console.WriteLine("Папка MyFolder знаходиться тут:");
Console.WriteLine(folder);
Console.WriteLine();

Console.WriteLine("Файл info.txt створено в Documents.");
Console.WriteLine();
Console.WriteLine("1 - Видалити файл");
Console.WriteLine("2 - Видалити порожній каталог");

Console.Write("Ваш вибір: ");
string choice = Console.ReadLine();

if (choice == "1")
{
    Console.Write("Введіть назву файлу (наприклад, info.txt): ");
    string name = Console.ReadLine();

    string path = Path.Combine(documents, name);

    if (File.Exists(path))
    {
        Console.Write("Видалити файл? (так/ні): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "так")
        {
            File.Delete(path);
            Console.WriteLine("Файл успішно видалено!");
        }
        else
        {
            Console.WriteLine("Видалення скасовано.");
        }
    }
    else
    {
        Console.WriteLine("Файл не знайдено!");
    }
}
else if (choice == "2")
{
    Console.WriteLine("1 - Documents");
    Console.WriteLine("2 - Images");
    Console.Write("Виберіть каталог: ");

    string number = Console.ReadLine();
    string path;

    if (number == "1")
    {
        path = documents;
    }
    else if (number == "2")
    {
        path = images;
    }
    else
    {
        Console.WriteLine("Неправильний вибір!");
        return;
    }

    Console.Write("Видалити порожній каталог? (так/ні): ");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "так")
    {
        if (Directory.Exists(path))
        {
            if (Directory.GetFileSystemEntries(path).Length == 0)
            {
                Directory.Delete(path, false);
                Console.WriteLine("Каталог успішно видалено!");
            }
            else
            {
                Console.WriteLine(
                    "Каталог не порожній! Його не видалено.");
            }
        }
        else
        {
            Console.WriteLine("Каталог не знайдено!");
        }
    }
    else
    {
        Console.WriteLine("Видалення скасовано.");
    }
}
else
{
    Console.WriteLine("Неправильний вибір!");
}
