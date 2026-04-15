
using TypeUdenMain;
using System.IO;

Console.WriteLine("Skriv et ord:");
string Word = Console.ReadLine();
Console.WriteLine("Skriv en tekst:");
string Text = Console.ReadLine();

Console.WriteLine($"Ordet '{Word}' forekommer {WordCount.CountWords(Word, Text)} gange i teksten.");
bool? ResultBool = WordCount.TrueOrFalse(WordCount.CountWords(Word, Text), Word, Text);

if  (ResultBool == null)
{
    Console.WriteLine("Det søgte ord findes ikke i det angivet tekst");
}
else if (ResultBool == false)
{
    Console.WriteLine($"Ordet '{Word}' forkommer {WordCount.CountWords(Word, Text)} gange");
}
else
{
    Console.WriteLine($"Det søgte ord '{Word}' findes {WordCount.CountWords(Word, Text)} gange i det angivet tekst");
    
}