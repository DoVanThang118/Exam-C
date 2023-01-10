using ConsoleApp_Exam.Exercise_2;
using ConsoleApp_Exam.GeometryExample;
using System.Text;

public class Program
{
    static void Main1(string[] args)
    {
        Cylinder c = new Cylinder();
        c.Radius = 38.64;
        Console.WriteLine("Radius: "+ c.Radius);
        c.Height = 22.48;
        Console.WriteLine("Height: "+c.Height);
        
        Console.WriteLine(c.Result);
    }

    static void Main(string[] args)
    {
        Lion l = new Lion();
        l.SetMe(200, "lion");
        Console.WriteLine(l.Show);
        Tiger t = new Tiger();
        t.SetMe(100, "tiger");
        Console.WriteLine(t.Show);
    }
}