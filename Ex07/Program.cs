namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Declaracio variables
            int velocitat;
            string sancio;

            //Entrada dades
            Console.Write("A quina velocitat anaves? ");
            velocitat = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            sancio = Sancio(velocitat);

            //Sortida dades
            Console.Clear();
            Console.WriteLine(sancio);
        }
        public static string Sancio(int velocitat)
        {
            if (velocitat >= 80 && velocitat <= 99)
            {
                return $"Anaves a {velocitat}Km/h, per tant la sanció és de 100€";
            }
            else if (velocitat >= 100 && velocitat <= 129)
            {
                return $"Anaves a {velocitat}Km/h, per tant la sanció és de 300€";
            }
            else if (velocitat >= 130)
            {
                return $"Anaves a {velocitat}Km/h, per tant la sanció és de 600€ i la retirada del carnet";
            }
            else
            {
                return $"No tens cap sanció";
            }
        }
    }
}
