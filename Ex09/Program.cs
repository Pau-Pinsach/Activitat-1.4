namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            double notaExamen, notaPractiques;
            string notaFinal;

            //Entrada dades
            Console.Write("Escriu la nota de l'exàmen: ");
            notaExamen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriu la nota de les pràctiques: ");
            notaPractiques = Convert.ToDouble(Console.ReadLine());

            //Algorisme
            notaFinal = CalculNota(notaExamen, notaPractiques);

            //Sortida dades
            Console.WriteLine(notaFinal);
        }
        public static string CalculNota(double notaExamen, double notaPractiques)
        {
            double notaFinal;
            string resultat;
            if (notaExamen < 3 || notaPractiques < 3)
            {
                return $"Suspens";
            }
            else
            {
                notaFinal = notaExamen * 0.8 + notaPractiques * 0.2;

                if (notaFinal < 5)
                {
                    resultat = "Suspens";
                }
                else if (notaFinal < 7)
                {
                    resultat = "Aprovat";
                }
                else if (notaFinal < 9)
                {
                    resultat = "Notable";
                }
                else
                {
                    resultat = "Excel·lent";
                }
                return resultat; 
            }
        }
    }
}
