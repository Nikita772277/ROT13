using ROT13;

while (true)
{
    Work_ROT13 wr = new();
    Console.WriteLine($"Введите слово");
    Console.WriteLine();
    string enter = Console.ReadLine();
    wr.WordEncryption(enter);
    Console.WriteLine();
}