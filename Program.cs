using System;
internal class Program
{
    static void Main(string[] args)
    {
        string enteredText = "Любое сочетание слов, каждое слово выводим с новой строки";
        string[] texts = enteredText.Split(' ', ',');

        foreach (var text in texts)
        {
            Console.WriteLine(text);
        }
    }
}