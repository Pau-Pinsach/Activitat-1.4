namespace Ex30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio Variables
            int dia, mes, mesParell;


            //Entrada dades
            Console.Write("Escriu un dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriu un mes: ");
            mes = Convert.ToInt32(Console.ReadLine());


            //Algorisme
            mesParell = mes % 2;
            if (mesParell == 1)
            {
                if (mes >= 3 && mes <= 6 && dia > 0 && dia < 31)
                {
                    Console.WriteLine("Primavera");
                }
                else if (mes >= 6 && mes <= 9 && dia > 0 && dia < 31)
                {
                    Console.WriteLine("Estiu");
                }
                else if (mes >= 9 && mes <= 12 && dia > 0 && dia < 31)
                {
                    Console.WriteLine("Tardor");
                }
            }
        }
    }
}
