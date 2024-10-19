namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            const int a = 5, b = 3, c = -10;
            bool resultat;

            //e1
            resultat = a > 3;
            Console.WriteLine($"e01: {resultat}");
            //e2
            resultat = a > c;
            Console.WriteLine($"e02: {resultat}");
            //e3
            resultat = b != c;
            Console.WriteLine($"e03: {resultat}");
            //e4
            resultat = a == 3;
            Console.WriteLine($"e04: {resultat}");
            //e5
            resultat = a * b == 15;
            Console.WriteLine($"e05: {resultat}");
            //e6
            resultat = c / b < a;
            Console.WriteLine($"e06: {resultat}");
            //e7
            resultat = c / b == -10;
            Console.WriteLine($"e07: {resultat}");
            //e8
            resultat = a + b + c == 5;
            Console.WriteLine($"e08: {resultat}");
            //e9
            resultat = (a + b == 8) && (a - b == 2);
            Console.WriteLine($"e09: {resultat}");
            //e10
            resultat = (a + b == 8) || (a - b == 6);
            Console.WriteLine($"e10: {resultat}");
            //e11
            resultat = a > 3 && b > 3 && c < 3;
            Console.WriteLine($"e11: {resultat}");
        }
    }
}
