namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio variables
            int angle;

            //Entrada dades
            Console.Write("Escriu un angle del -360º al 360º: ");
            angle = Convert.ToInt32(Console.ReadLine());

            //Sortida dades
            Console.Clear();
            Console.WriteLine(Quadrant(angle));
        }
        static string Quadrant(int angle)
        {
            string quadrant;
            if (angle < -360 || angle > 360)
            {
                quadrant = "Aquest angle no és vàlid";
            }
            else if (angle >= 0 && angle <= 90 || angle <= -270 && angle >= -360)
            {
                quadrant = $"L'angle {angle}º està al quadrant 1";
            }
            else if (angle >= 91 && angle <= 180 || angle <= -180 && angle > -270)
            {
                quadrant = $"L'angle {angle}º està al quadrant 2";
            }
            else if (angle >= 181 && angle <= 270 || angle <= -90 && angle > -180)
            {
                quadrant = $"L'angle {angle}º està al quadrant 3";
            }
            else
            {
                quadrant = $"L'angle {angle}º està al quadrant 4";
            }
            return quadrant;
        }
    }
}
