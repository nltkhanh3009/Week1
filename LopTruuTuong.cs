using System;

public abstract class DongVat
{
    public abstract void TiengKeu();

    // Phương thức chung
    public void Ngu()
    {
        Console.WriteLine("zzzzzzz");
    }
}

// Kế thừa abstract
class Cho : DongVat
{
    public override void TiengKeu()
    {
        Console.WriteLine("Gau gau");
    }
}

// Kế thừa abstract
public class Meo : DongVat
{
    public override void TiengKeu()
    {
        Console.WriteLine("Meo Meo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo biến
        DongVat cho = new Cho();
        DongVat meo = new Meo();

        cho.TiengKeu();
        cho.Ngu();
        meo.TiengKeu();
        meo.Ngu();

        Console.ReadLine();
    }
}
