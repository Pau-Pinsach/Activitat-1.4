namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int any;
            string valid;

            //Entrada dades
            Console.Write("Escriu un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            valid = ComprovacioAny(any);

            //Sortida dades
            Console.Clear();
            Console.WriteLine(valid);
        }
        public static string ComprovacioAny(int any)
        {
            if (any < 1701 || any > 2100)
            {
                return $"L'any {any} no és vàlid";
            }
            else if (any <= 1800)
            {
                return $"L'any {any} és vàlid, pertany al segle XVIII";
            }
            else if (any <= 1900)
            {
                return $"L'any {any} és vàlid, pertany al segle XIX";
            }
            else if (any <= 2000)
            {
                return $"L'any {any} és vàlid, pertany al segle XX";
            }
            else
            {
                return $"L'any {any} és vàlid, pertany al segle XXI";
            }
        }
    }
}
