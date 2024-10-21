namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int horaCompleta, hores, minuts, segons;

            //Entrada dades
            Console.Write("Escriu una hora en format 24 hores: ");
            horaCompleta = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            hores = horaCompleta / 10000;
            minuts = horaCompleta % 10000 /100;
            segons = horaCompleta % 100;

            //Sortida dades
            Console.Clear();
            if (HoraValida(hores, minuts, segons))
                Console.WriteLine($"L'hora {horaCompleta} és vàlida");
            else
                Console.WriteLine($"L'hora {horaCompleta} és vàlida");
        }
        public static bool HoraValida(int h, int m, int s)
        {
            bool horaValida;
            if (h >= 0 && h < 24 && m >= 0 && m < 60 && s >= 0 && s < 60)
            {
                horaValida = true;
            }
            else
            {
                horaValida = false;
            }
            return horaValida;
        }
    }
}
