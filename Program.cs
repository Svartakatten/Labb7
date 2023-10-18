using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel1 = new Rektangel();
            Fyrkant fyrkant1 = new Fyrkant();
            Cirkel cirkel1 = new Cirkel();
            Parallellogram parallello1 = new Parallellogram();
            Ellips ellips1 = new Ellips();

            Console.WriteLine($"Rektangels area : {rektangel1.Area()}");
            Console.WriteLine($"Fyrkantens area : {fyrkant1.Area()}");
            Console.WriteLine($"Cirkelns area : {cirkel1.Area()}");
            Console.WriteLine($"Parallelons area : {parallello1.Area()}");
            Console.WriteLine($"Ellipsens area : {ellips1.Area()}");
        }
    }
    public abstract class Geometri
    {
        public abstract double Area();
    }
    public class Rektangel : Geometri
    {
        private double Height { get; set; }
        private double Base { get; set; }
        public Rektangel()
        {
            Height = 4;
            Base = 8;
        }
        public override double Area()
        {
            return Base * Height;
        }
    }
    public class Fyrkant : Geometri
    {
        private double Side { get; set; }
        public Fyrkant()
        {
            Side = 4;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
    public class Cirkel : Geometri
    {
        private double Pi { get; set; }
        private double Radius { get; set; }
        public Cirkel()
        {
            Radius = 4;
        }
        public override double Area()
        {
            return Pi * (Radius * Radius);
        }
    }
    public class Parallellogram : Geometri
    {
        private double Height { get; set; }
        private double Base { get; set; }
        public Parallellogram()
        {
            Height = 4;
            Base = 8;
        }
        public override double Area()
        {
            return Base * Height;
        }
    }
    public class Ellips : Geometri
    {
        public double a { get; set; }
        private double b { get; set; }
        private double Pi { get; set; }
        public Ellips()
        {
            Pi = 3.141;
            a = 4;
            b = 6;
        }
        public override double Area()
        {
            return Pi * a * b;
        }
    }
}