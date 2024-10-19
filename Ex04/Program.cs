namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool ordreCreixent;

            //Algorisme

            ordreCreixent = t1 == t2 - 1 && t2 == t3 - 1;

            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }

        }
    }
}
