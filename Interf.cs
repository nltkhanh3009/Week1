using System;

public interface IDongVat
{
    void TiengKeu();
}

public class Cho : IDongVat
{
    public void TiengKeu()
    {
        Console.WriteLine("Gau gau");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDongVat cho = new Cho();

        cho.TiengKeu();
        Console.ReadLine();
    }
}
