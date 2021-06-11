using System;
using System.IO;


namespace FromentKylian_Guybrush
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponseDemande;
            Console.WriteLine("Que voulez faire ?\n");
            Console.WriteLine("Entrez 'C' pour coder une carte     ou      Entrez 'D' pour decoder une carte");
            reponseDemande = Console.ReadLine();
            Console.WriteLine("\nTrès bien c'est note !");

            if (reponseDemande == "D" || reponseDemande == "d")
            {
                Decodage CarteClaire;
                CarteClaire = new Decodage();
                CarteClaire.CreationCarte();
                CarteClaire.x();
                CarteClaire.AfficherCarte();
            }
            else if (reponseDemande == "C" || reponseDemande == "c")
            {
                Codage NouvelleCarte;
                NouvelleCarte = new Codage();
                NouvelleCarte.CreationCarte();
                NouvelleCarte.SuppressionCarac();
                for (int i = 0; i < 100; i++)
                {
                    if (i == 0 || i == 9 || i == 90 || i == 99)
                        NouvelleCarte.DecodageCoin(i);
                    else if ((i > 0 && i < 9) || (i == 10 || i == 20 || i == 30 || i == 40 || i == 50 || i == 60 || i == 70 || i == 80) || (i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89) || (i > 90 && i < 99))
                        NouvelleCarte.DecodageBordure(i);
                    else
                        NouvelleCarte.DecodageCentre(i);

                }
                NouvelleCarte.AffichageCarteDecodee();
                NouvelleCarte.CreationFichierChiffre();

            }
            else
            {
                Console.WriteLine("Reviens vite !");
            }
        }
    }
}
