Console.WriteLine("Обзовись:");
string username = Console.ReadLine();

if(username.ToLower() == "вася")
{
    Console.WriteLine("Ну здравстуй, Вася");
}
else
{
    Console.Write("Привет, чувак.");
    Console.WriteLine(username);
}

