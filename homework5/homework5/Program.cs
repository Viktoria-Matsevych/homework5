using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("--Інформація про системне середовище--");

//ім'я комп'ютера 
string machineName = Environment.MachineName;
Console.WriteLine($"Ім'я комп'ютера: {machineName}");

//Ім'я користувача
string userName = Environment.UserName;
Console.WriteLine($"Ім'я користувача: {userName}");

//Версія операційної системи
OperatingSystem osVersion = Environment.OSVersion;
Console.WriteLine($"Версія операційної сиситеми: {osVersion}");

//Системний каталог Windows 
string systemsDirectory = Environment.SystemDirectory;
Console.WriteLine($"Системний каталог Windows: {systemsDirectory}");

//Поточний робочий каталог програми
string currentDirectory = Environment.CurrentDirectory;
Console.WriteLine($"Поточний робочий каталог: {currentDirectory}");

Console.ReadLine();