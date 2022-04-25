StreamReader sr = new StreamReader("file.txt");
StreamWriter sw = new StreamWriter("temp.txt");
string line;
while ((line = sr.ReadLine()) != null)
{
    sw.WriteLine(line);
}
sr.Close();
sw.Close();


StreamReader sr1 = new StreamReader("temp.txt");
StreamWriter sw1 = new StreamWriter("file.txt");
Console.Write("Введите новое дело: ");
var line1 = Console.ReadLine();
while (line1 == "")
{
    Console.WriteLine("Ошибка, поле не может быть пустым...");
    Console.WriteLine("Введите ваше дело корректно: ");
    line1 = Console.ReadLine();
}
if (line1 != "/list")
{
    while ((line = sr1.ReadLine()) != null)
    {
        sw1.WriteLine(line);
    }
    sw1.WriteLine(line1);
    sr1.Close();
    sw1.Close();
}
else
{
    Console.WriteLine("Список ваших дел:");
    int i = 0;
    while ((line = sr1.ReadLine()) != null)
    {
        i++;
        Console.WriteLine(i + ". " + line);
        sw1.WriteLine(line);
    }
    sr1.Close();
    sw1.Close();
}