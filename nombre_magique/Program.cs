using System;

namespace nombre_magique
{
    class Program
    {
        // DemanderNombre
        // afficher : Rentrez un nombre
        // tester si ce nombre est valide (convertion -> try/catch) -> ERREUR : ce nombre n'est pas valide
        // reboucler tant que le nombre n'est pas valide
        // considérer que 0 est invalide
        // retourner la valeur (int)

        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = max + 1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write("Rentrez un nombre entre " + min + " et " + max + " : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);
                    }

                    // tester si nombreUtilisateur entre min et max
                    // ERREUR
                    // nombreUtilisateur = 0 <- forcer à reboucler
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide");
                }
            }

            return nombreUtilisateur;
        }

        static void Main(string[] args)
        {

            // 
            Random rand = new Random();
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            // Nombre magique aleatoire
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);
            int nombre = NOMBRE_MAGIQUE + 1;

            int NbVies = 5;

            //while (NbVies > 0)  
            for (NbVies = 4; NbVies > 0; NbVies--)
            {
                Console.WriteLine("il vous reste: " + NbVies + " vies ");
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("le nombre magique est plus grand");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("le nombre magique est plus petit");
                }
                else
                {
                    break;
                }

            }

            if (nombre == NOMBRE_MAGIQUE)
            {

                Console.WriteLine("Bravo, vous avez trouvé le nombre magique");

            }
            else
            {
                Console.WriteLine("vous n avez plus de vie");
                Console.WriteLine("Vous avez perdu, le nombre magique etait: " + NOMBRE_MAGIQUE);
            }

        }
    }
}