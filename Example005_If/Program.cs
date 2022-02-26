Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "Наташа")
{
Console.Write("Привет, Красотка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}