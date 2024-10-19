namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio dades
            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;

            //Algorisme
            iguals = t1 == t2 && t2 == t3;

            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }
        }
    }
}
