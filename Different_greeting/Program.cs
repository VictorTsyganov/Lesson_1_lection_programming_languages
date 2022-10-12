Console.Write("Введите имя пользовател: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.Write("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}