using System;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;


class Project
{
    static void Main(string[] args)
    {
        string text1 = "Привет как твои дела.У меня хорошо";

        Word m = new Word(text1);

        Console.Write(m.ToString());

    }
}

class Text
{

    protected int AmountOfWords { get; set; }

    protected string tExt { get; set; } = "";

    public int paragraphs { get; set; } = 0;

    public Text(string s)
    {
        this.tExt = s;
        AmountOfWords = s.Split(new char[] { ' ', ',','.' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

 

    public override bool Equals(object? obj)
    {
        if (obj is Text t)
            return  AmountOfWords == t.AmountOfWords && tExt == t.tExt;

        Console.WriteLine("Должен быть тип данных Text!");
        return false ;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Amount of Words : {AmountOfWords} , paragraphs : {paragraphs}";
    }


}

class Sentence : Text
{
    private int AmountOfSentences { get; set; } = 0;

    public Sentence(string s1) : base(s1)
    {
        AmountOfSentences += s1.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine(AmountOfSentences);
        tExt = s1;
    }


    public override bool Equals(object? obj)
    {
        if (obj is Sentence t)
            return AmountOfWords == t.AmountOfWords && tExt == t.tExt && AmountOfSentences == t.AmountOfSentences;

        Console.WriteLine("Должен быть тип данных Sentence!");
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Amount of Sentences : {AmountOfSentences} ,Amount of Words : {AmountOfWords} , paragraphs : {paragraphs}";
    }
}


class Word : Text
{
    private int AmountOfLetters { get; set; }

    public Word(string s) : base(s)
    {
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (var word in words)
        {
            foreach (var c in word)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
                {
                    count++;
                }
            }
        }

        AmountOfLetters = count;
    }

 

    public override bool Equals(object? obj)
    {
        if (obj is Word t)
            return AmountOfWords == t.AmountOfWords && tExt == t.tExt && AmountOfLetters == t.AmountOfLetters;

        Console.WriteLine("Должен быть тип данных Sentence!");
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Amount of Letters : {AmountOfLetters} ,Amount of Words : {AmountOfWords} , paragraphs : {paragraphs}";
    }
}