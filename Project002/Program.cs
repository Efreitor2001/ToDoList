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

switch (line1[0])
{
    case '/':

        switch (line1)
        {
            case "/done":
                int i = 1;
                int ui = 0;
                Console.Write("Введите номер дела, которое хотите завершить: ");
                ui = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Список ваших дел:");
                while ((line = sr1.ReadLine()) != null)
                {
                    if (i == ui)
                    {
                        Console.WriteLine(i + ". " + line + " ☑");
                        sw1.WriteLine(line + " ☑");
                    }
                    else
                    {
                        Console.WriteLine(i + ". " + line);
                        sw1.WriteLine(line);
                    }
                    i++;
                }
                sr1.Close();
                sw1.Close();
                break;
            case "/help":
                Console.WriteLine("Список доступных команд:");
                Console.WriteLine("/list - покажет текущий список дел");
                Console.WriteLine("/done - завершить выбранное дело");
                while ((line = sr1.ReadLine()) != null)
                {
                    sw1.WriteLine(line);
                }
                sr1.Close();
                sw1.Close();
                break;
            case "/list":
                Console.WriteLine("Список ваших дел:");
                i = 1;
                while ((line = sr1.ReadLine()) != null)
                {
                    Console.WriteLine(i + ". " + line);
                    sw1.WriteLine(line);
                    i++;
                }
                sr1.Close();
                sw1.Close();
                break;
            default:
                Console.WriteLine("Ошибка! Такой команды не существует!!!");
                while ((line = sr1.ReadLine()) != null)
                {
                    sw1.WriteLine(line);
                }
                sr1.Close();
                sw1.Close();
                break;

        }
        break;
    default:
        while ((line = sr1.ReadLine()) != null)
        {
            sw1.WriteLine(line);
        }
        sw1.WriteLine(line1);
        sr1.Close();
        sw1.Close();
        break;
}