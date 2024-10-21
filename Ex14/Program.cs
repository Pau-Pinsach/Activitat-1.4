namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero, unitats, milers;

            //Entrada dades
            Console.Write("Escriu un número de 4 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            unitats = numero % 10;
            milers = numero / 1000;

            //Sortida dades
            if (CapICua(unitats, milers))
            {
                Console.WriteLine($"El número {numero} és cap i cua.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no és cap i cua");
            }
        }
        static bool CapICua(int unitats, int milers)
        {
            bool capICua;
            if (unitats == milers)
            {
                capICua = true;
            }
            else
            {
                capICua = false;
            }
            return capICua;
        }
    }
}
