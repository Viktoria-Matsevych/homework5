using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Directory.CreateDirectory("MyFolder");
Directory.CreateDirectory("MyFolder/Documents");
Directory.CreateDirectory("MyFolder/Images");

string source = "MyFolder/Documents/info.txt";
string copy = "MyFolder/Images/info_copy.txt";
string destination = "MyFolder/info_copy.txt";

//Створюємо файл, якщо його ще немає
if (File.Exists(source))
{
    File.WriteAllText(source, "Інформація про користувача");
}

Console.WriteLine("Файл info.txt знайдено!");

//Копіюємо файл у каталог Images
File.Copy(source, copy, true);
Console.WriteLine("Файл скопійовано в Images!");

//Перевіряємо, чи існує копія
if (File.Exists(copy))
{
    //Якщо файл призначення вже існує, видаляємо його
    if (File.Exists(destination))
    {
        File.Delete(destination);
    }

    //Переміщуємо копію до MyFolder
    File.Move(copy, destination);

    Console.WriteLine("Файл переміщено до MyFolder!");
}
else
{
    Console.WriteLine("Помилка копіювання файлу!");
}

//Перевіряємо результат
if (File.Exists(destination))
{
    Console.WriteLine("Файл info_copy.txt успішно переміщено!");
}