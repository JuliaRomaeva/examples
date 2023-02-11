Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "антон")
{
    Console.WriteLine("Ура, это же АНТОН!");
} 
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}