using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Ввод строки пользователем
        Console.Write("Введите строку с IP-адресом: ");
        string input = Console.ReadLine();

        // Регулярное выражение для поиска IPv4-адреса
        string patternIPv4 = @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

        // Регулярное выражение для поиска IPv6-адреса
        string patternIPv6 = @"\b(([0-9A-Fa-f]{1,4}:){7}[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,7}:|([0-9A-Fa-f]{1,4}:){1,6}:[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,5}(:[0-9A-Fa-f]{1,4}){1,2}|([0-9A-Fa-f]{1,4}:){1,4}(:[0-9A-Fa-f]{1,4}){1,3}|([0-9A-Fa-f]{1,4}:){1,3}(:[0-9A-Fa-f]{1,4}){1,4}|([0-9A-Fa-f]{1,4}:){1,2}(:[0-9A-Fa-f]{1,4}){1,5}|[0-9A-Fa-f]{1,4}:((:[0-9A-Fa-f]{1,4}){1,6}|:)|:((:[0-9A-Fa-f]{1,4}){1,7}|:))\b";

        // Поиск IPv4-адреса в строке
        Match matchIPv4 = Regex.Match(input, patternIPv4);

        // Поиск IPv6-адреса в строке
        Match matchIPv6 = Regex.Match(input, patternIPv6);

        // Если найден IPv4-адрес, вывести его на консоль
        if (matchIPv4.Success)
        {
            Console.WriteLine("Найден IPv4-адрес: " + matchIPv4.Value);
        }
        // Если найден IPv6-адрес, вывести его на консоль
        else if (matchIPv6.Success)
        {
            Console.WriteLine("Найден IPv6-адрес: " + matchIPv6.Value);
        }
        // Если не найден ни IPv4, ни IPv6-адрес, вывести предупреждение
        else
        {
            Console.WriteLine("IP-адрес не найден.");
        }

        Console.ReadLine();
    }
}