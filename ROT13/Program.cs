
using ROT13;

Work_ROT13 wr = new();
Console.WriteLine($"Введите слово");
string enter = Console.ReadLine();
wr.WordEncryption(enter);