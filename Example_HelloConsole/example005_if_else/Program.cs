Console.Write("Введите имя пользователья");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРААА, это же Маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}