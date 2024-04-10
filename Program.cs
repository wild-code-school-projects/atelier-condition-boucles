namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Premier exo : 
            ConditionAge();

            // Second exo : 
            //BoucleMultiplication();

            // Troisieme exo : 
            //FiltrageUtilisateur();
        }

        static void ConditionAge()
        {
            Console.Write("Veuillez saisir votre age : ");

            var saisitAge = Console.ReadLine();
            if (Int32.TryParse(saisitAge, out var age))
            {
                if (age < 1)
                    return;

                if (age < 18)
                    Console.WriteLine("Vous etes mineur.");
                else if (age >= 18 && age < 25)
                    Console.WriteLine("Vous etes majeur.");
                else if (age >= 25 && age <= 30)
                    Console.WriteLine("Vous etes adulte");
                else
                    Console.WriteLine("Vous etes en beton arme !");
            }
        }

        static void BoucleMultiplication()
        {
            while (true)
            {
                Console.Write("Quelle table de multiplication souhaitais vous afficher ? : ");

                var saisitTable = Console.ReadLine();

                if (Int32.TryParse(saisitTable, out var table))
                {
                    for (int n = 1; n <= 10; n++)
                        Console.WriteLine(table * n);
                }
            }
        }

        static void FiltrageUtilisateur()
        {
            while (true)
            {
                Console.WriteLine("Saisit break pour arreter le program.\n\n\n");
                Console.Write("Saisit du nombre flottant : ");

                var saisitUser = Console.ReadLine();

                if (saisitUser == "break")
                    break;

                if (float.TryParse(saisitUser, out var flottant))
                {
                    if (flottant < 0.0f || flottant > 100.999999f)
                        Console.WriteLine("Erreur, nombre flottant invalid.");
                    else
                        Console.WriteLine($"Nombre flottant {flottant} valide !");
                }
            }
        }
    }
}
