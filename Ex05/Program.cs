namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int numero;
            bool parell, multiple;

            //Entrada dades
            Console.Write("Escriu un número enter: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            parell = ParellSenar(numero);
            multiple = Multiple7(numero);

            //Sortida dades
            if (parell == true)
                Console.WriteLine("El número és parell");
            else
                Console.WriteLine("El número és senar");
            if (multiple == true)
                Console.WriteLine("El número és múltiple de 7");
            else 
                Console.WriteLine("El número no és múltiple de 7");

        }
        static bool ParellSenar(int numero)
        {
            bool resultat;
            resultat = numero % 2 == 0;
            return resultat;
        }
        static bool Multiple7(int numero)
        {
            bool resultat;
            resultat = numero % 7 == 0;
            return resultat;
        }
    }
}
