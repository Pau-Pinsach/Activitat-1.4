namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables 
            string equipLocal, equipVisitant, informe;
            int golsLocal, golsVisitant;

            //Entrada dades
            Console.Write($"Introdueix el nom de l'equip local: ");
            equipLocal = Console.ReadLine();
            Console.Write($"Introdueix els gols de l'equip local: ");
            golsLocal = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Introdueix el nom de l'equip visitant: ");
            equipVisitant = Console.ReadLine();
            Console.Write($"Introdueix els gols de l'equip visitant: ");
            golsVisitant = Convert.ToInt32(Console.ReadLine());
            //Algorisme
            informe = ResultatInforme(equipLocal, equipVisitant, golsLocal, golsVisitant);
            //Sortida dades
            Console.Clear();
            Console.WriteLine(informe);
            
        }
        public static string ResultatInforme(string equipLocal, string equipVisitant, int golsLocal, int golsVisitant)
        {
            if (golsLocal > golsVisitant)
            {
                return $"El {equipLocal} ha guanyat al {equipVisitant} amb un resultat de {golsLocal} a {golsVisitant}";
            }
            else if (golsLocal < golsVisitant)
            {
                return $"El {equipLocal} ha perdut contra el {equipVisitant} amb un resultat de {golsLocal} a {golsVisitant}";
            }
            else
            {
                return $"El {equipLocal} i el {equipVisitant} han empatat amb un resultat de {golsLocal} a {golsVisitant}";
            }
        }
    }
}
