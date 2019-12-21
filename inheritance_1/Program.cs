using System;

namespace inheritance_1
{
    class Printer
    {
        protected ConsoleColor Color;

        public Printer()
        {
            Color = ConsoleColor.Blue;
        }

        public Printer(ConsoleColor color)
        {
            Color = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(value);
        }
    }
    class MyPrinter : Printer
    {
        public MyPrinter()
        {
            Color = ConsoleColor.DarkGreen;
        }

        public MyPrinter(ConsoleColor color) : base(color)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = new Printer();
            Printer p2 = new MyPrinter();
            MyPrinter p3 = new MyPrinter();
            Printer p4 = new Printer(ConsoleColor.DarkRed);
            p1.Print("Printer");
            p2.Print("Printer as MyPrinter");
            p3.Print("MyPrinter");
            p4.Print("Color=DarkRed");
            Console.ReadKey();
        }
    }
}
