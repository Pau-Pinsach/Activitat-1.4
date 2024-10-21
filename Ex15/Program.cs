namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int hores, minuts, segons;
            string horaIncrementada;

            //Entrada dades
            Console.Write("Introdueix les hores: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix els minuts: ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix els segons: ");
            segons = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            horaIncrementada = Incrementa1Segon(hores, minuts, segons);
            //Sortida dades
            Console.Clear();
            Console.WriteLine($"L'hora inicial és {hores:00}:{minuts:00}:{segons:00} i la hora amb un segon més és {horaIncrementada}");
        }
        public static string Incrementa1Segon(int h, int m, int s)
        {
            string hora1Segon;
            if (s == 59 && m != 59)
            {
                m = m + 1;
                s = 0;
            }
            else if (s == 59 && m == 59)
            {
                h = h + 1;
                m = 0;
                s = 0;
            }
            else
            {
                s = s + 1;
            }
            hora1Segon = $"{h:00}:{m:00}:{s:00}";
            return hora1Segon;
        }
    }
}
