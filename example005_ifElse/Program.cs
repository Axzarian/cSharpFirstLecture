System.Console.WriteLine("Введите ваше имя: ");
string userName = Console.ReadLine();

if(userName.ToLower() == "глаша")
{
    System.Console.WriteLine("Ого! Какие люди!");
}
else
{
    System.Console.WriteLine("Привет, рядовой пользователь," + userName + ":(");
}