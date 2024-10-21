namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero, unitats, centenes;

            //Entrada dades
            Console.Write("Escriu un número de 3 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            unitats = numero % 10;
            centenes = numero / 100;

            //Sortida dades
            if (CapICua(unitats, centenes))
            {
                Console.WriteLine($"El número {numero} és cap i cua.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no és cap i cua");
            }
        }
        static bool CapICua(int unitats, int centenes)
        {
            bool capICua;
            if (unitats == centenes)
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
