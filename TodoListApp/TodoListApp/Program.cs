// TodoListApp — практическое задание к Лекции 2 «Введение в C# и .NET»
// Работу выполнили: Талаева и Хрустель, группа 2121у

Console.WriteLine("Работу выполнили Талаева и Хрустель");
Console.WriteLine();

Console.Write("Введите имя: ");
string? firstName = Console.ReadLine();

Console.Write("Введите фамилию: ");
string? lastName = Console.ReadLine();

Console.Write("Введите год рождения: ");
int birthYear = int.Parse(Console.ReadLine()!);

int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine($"Добавлен пользователь {firstName} {lastName}, возраст - {age}");