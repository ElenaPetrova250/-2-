Console.Write("Введи число: ");
int Number = int.Parse(Console.ReadLine());
Number = Console.Read ();
if (Number > 99)
    Console.WriteLine((n / 100) % 10);
else
    Console.WriteLine("-> третьей цифры нет");
