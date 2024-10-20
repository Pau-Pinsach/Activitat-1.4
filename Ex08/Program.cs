namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int horaCompleta, hores, minuts, segons;
            string resultat;

            //Entrada dades
            Console.Write("Escriu una hora en format 24 hores: ");
            horaCompleta = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            hores = horaCompleta / 10000;
            minuts = horaCompleta % 10000 /100;
            segons = horaCompleta % 100;
            resultat = HoraValida(hores, minuts, segons);

            //Sortida dades
            Console.Clear();
            Console.WriteLine($"La hora {horaCompleta} {resultat}");
        }
        public static string HoraValida(int h, int m, int s)
        {
            if (h < 24 && m < 60 && s < 60)
            {
                return "és vàlida";
            }
            else
            {
                return "no és vàlida";
            }
        }
    }
}
