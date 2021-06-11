using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FromentKylian_Guybrush
{
    class Decodage
    {
        string nomfichier;
        public List<string> tab = new List<string>();
        public List<int> carte = new List<int>();
        string[] test;
        char[] separators = new char[] { ':', '|' };


        public void CreationCarte()
        {
            Console.WriteLine("Quelle Carte voulez vous decoder ? (Saisir le nom de la carte)");

            try
            {
                nomfichier = Console.ReadLine();
                StreamReader sr = new StreamReader(nomfichier + ".chiffre");
                string chiffre = sr.ReadLine();
                test = chiffre.Split(separators);


                for (int i = 0; i < tab.Count; i++)
                {
                    if (chiffre[i + 1] != ':')
                    {
                        carte[i] = chiffre[i] + chiffre[i + 1];
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Le fichier n'a pas pu être lu.");
                Console.WriteLine(e.Message);
            }
        }

        public void AfficherCarte()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(test[i]);
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89)
                {
                    Console.WriteLine();
                }
            }
        }

        public void x()
        {
            int[] numbers = new int[test.Length];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = int.Parse(test[i]);
            }


            for (int i = 0; i < 100; i++)
            {
                if (numbers[i] >= 64 && numbers[i] < 80)
                {
                    test[i] = "M";
                }
                else if (numbers[i] >= 32 && numbers[i] < 48)
                {
                    test[i] = "F";
                }
            }
        }
    }
}



