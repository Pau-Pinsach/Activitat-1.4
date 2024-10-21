namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int any;

            //Entrada dades
            Console.Write("Introdueix un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            //Sortida dades
            Console.Clear();
            if (ComprovacioAny(any))
            {
                Console.WriteLine($"L'any {any} és un any de traspàs");
            }
            else
            {
                Console.WriteLine($"L'any {any} no és un any de traspàs");
            }
        }
        static bool ComprovacioAny(int any)
        {
            bool comprovacio;
            if ((any % 4 == 0 && any % 100 != 0) || any % 400 == 0)
            {
                comprovacio = true;
            }
            else
            {
                comprovacio = false;
            }
            return comprovacio;
        }
    }
}
