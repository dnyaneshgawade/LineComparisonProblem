using System;

namespace LineComparison
{
    class Program
    {
        public static double length1, length2;
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the line comparison");
            Line line1 = new Line(1, 3, 2, 4);
            length1 = line1.Calculate();
            Line line2 = new Line(2, 3, 4, 5);
            length2 = line2.Calculate();
            if (length1.CompareTo(length2)>0)
                Console.WriteLine("The length of first is greater than second line.");
            if (length1.CompareTo(length2) < 0)
                Console.WriteLine("The length of first is less than second line");
            if (length1.CompareTo(length2) == 0)
                Console.WriteLine("both lines are equals");
        }
    }
}
