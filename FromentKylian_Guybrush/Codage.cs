using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FromentKylian_Guybrush

{
    class Codage
    {
        //initialisation des listes tab et codes qui permettront de stocker le fichier .clair et le crypter

        List<string> tab = new List<string>();
        List<int> decode = new List<int>();

        string nomfichier;



        public void CreationCarte()
        {
            Console.WriteLine("Veuillez déposer la carte dans le bon format (.clair) dans le repertoir suivant : /bin/Debug/netcoreapp3.1");

            Console.WriteLine("\nQuelle Carte voulez vous Coder ? (Saisir le nom de la carte)\n");


            try
            {
                nomfichier = Console.ReadLine();
                StreamReader sr = new StreamReader(nomfichier + ".clair");
                for (int i = 0; i < 118; i++)
                    decode.Add(sr.Read());
            }
            catch (Exception e)
            {
                Console.WriteLine("Le fichier n'a pas pu être lu.");
                Console.WriteLine(e.Message);
            }
        }
        //Suppression des caractères inutiles
        public void SuppressionCarac()
        {
            for (int i = 0; i < 100; i++)
            {
                if (decode[i] == 13 || decode[i] == 10)
                {
                    decode.RemoveAt(i);
                    i--;
                }
            }
        }

        //decodage du centre de la carte
        public void DecodageCentre(int i)
        {
            if (i >= 10 && i < 90)
            {
                if (decode[i] == decode[i - 10] && decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("64");
                    else if (decode[i] == 70)
                        tab.Add("32");
                    else
                        tab.Add("0"); ;
                }
                if (decode[i] != decode[i - 10] && decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("65");
                    else if (decode[i] == 70)
                        tab.Add("33");
                    else
                        tab.Add("1");
                }
                if (decode[i] == decode[i - 10] && decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("66");
                    else if (decode[i] == 70)
                        tab.Add("34");
                    else
                        tab.Add("2");
                }
                if (decode[i] != decode[i - 10] && decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("67");
                    else if (decode[i] == 70)
                        tab.Add("35");
                    else
                        tab.Add("3");
                }
                if (decode[i] == decode[i - 10] && decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("68");
                    else if (decode[i] == 70)
                        tab.Add("36");
                    else
                        tab.Add("4");
                }
                if (decode[i] != decode[i - 10] && decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("69");
                    else if (decode[i] == 70)
                        tab.Add("37");
                    else
                        tab.Add("5"); ;
                }
                if (decode[i] == decode[i - 10] && decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("70");
                    else if (decode[i] == 70)
                        tab.Add("38");
                    else
                        tab.Add("6");
                }
                if (decode[i] != decode[i - 10] && decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("71");
                    else if (decode[i] == 70)
                        tab.Add("39");
                    else
                        tab.Add("7");
                }
                if (decode[i] == decode[i - 10] && decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("72");
                    else if (decode[i] == 70)
                        tab.Add("40");
                    else
                        tab.Add("8");
                }
                if (decode[i] != decode[i - 10] && decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("73");
                    else if (decode[i] == 70)
                        tab.Add("41");
                    else
                        tab.Add("9");
                }
                if (decode[i] == decode[i - 10] && decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("74");
                    else if (decode[i] == 70)
                        tab.Add("42");
                    else
                        tab.Add("10");
                }
                if (decode[i] != decode[i - 10] && decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("75");
                    else if (decode[i] == 70)
                        tab.Add("43");
                    else
                        tab.Add("11");
                }
                if (decode[i] == decode[i - 10] && decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("76");
                    else if (decode[i] == 70)
                        tab.Add("44");
                    else
                        tab.Add("12");
                }
                if (decode[i] != decode[i - 10] && decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("77");
                    else if (decode[i] == 70)
                        tab.Add("45");
                    else
                        tab.Add("13");
                }
                if (decode[i] == decode[i - 10] && decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("78");
                    else if (decode[i] == 70)
                        tab.Add("46");
                    else
                        tab.Add("14");
                }
                if (decode[i] != decode[i - 10] && decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                {
                    if (decode[i] == 77)
                        tab.Add("79");
                    else if (decode[i] == 70)
                        tab.Add("47");
                    else
                        tab.Add("15");
                }
            }
        }

        //decodage des bordures de la carte

        public void DecodageBordure(int i)
        {
            {
                if (i > 0 && i < 9)
                {
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("65");
                        else if (decode[i] == 70)
                            tab.Add("33");
                        else
                            tab.Add("1");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("67");
                        else if (decode[i] == 70)
                            tab.Add("35");
                        else
                            tab.Add("3");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("69");
                        else if (decode[i] == 70)
                            tab.Add("37");
                        else
                            tab.Add("5");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("71");
                        else if (decode[i] == 70)
                            tab.Add("39");
                        else
                            tab.Add("7");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("73");
                        else if (decode[i] == 70)
                            tab.Add("41");
                        else
                            tab.Add("9");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("75");
                        else if (decode[i] == 70)
                            tab.Add("43");
                        else
                            tab.Add("11");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("77");
                        else if (decode[i] == 70)
                            tab.Add("45");
                        else
                            tab.Add("13");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("79");
                        else if (decode[i] == 70)
                            tab.Add("47");
                        else
                            tab.Add("15");
                    }
                }
                if (i == 10 || i == 20 || i == 30 || i == 40 || i == 50 || i == 60 || i == 70 || i == 80)
                {
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 10] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("66");
                        else if (decode[i] == 70)
                            tab.Add("33");
                        else
                            tab.Add("2");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 10] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("67");
                        else if (decode[i] == 70)
                            tab.Add("35");
                        else
                            tab.Add("3");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 10] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("70");
                        else if (decode[i] == 70)
                            tab.Add("38");
                        else
                            tab.Add("6");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 10] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("71");
                        else if (decode[i] == 70)
                            tab.Add("39");
                        else
                            tab.Add("7");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 10] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("74");
                        else if (decode[i] == 70)
                            tab.Add("42");
                        else
                            tab.Add("10");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 10] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("75");
                        else if (decode[i] == 70)
                            tab.Add("43");
                        else
                            tab.Add("11");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 10] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("78");
                        else if (decode[i] == 70)
                            tab.Add("46");
                        else
                            tab.Add("14");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 10] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("79");
                        else if (decode[i] == 70)
                            tab.Add("47");
                        else
                            tab.Add("15");
                    }
                }
                if (i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89)
                {
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 10] && decode[i] == decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("72");
                        else if (decode[i] == 70)
                            tab.Add("40");
                        else
                            tab.Add("8");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 10] && decode[i] == decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("73");
                        else if (decode[i] == 70)
                            tab.Add("41");
                        else
                            tab.Add("9");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 10] && decode[i] == decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("76");
                        else if (decode[i] == 70)
                            tab.Add("44");
                        else
                            tab.Add("12");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 10] && decode[i] == decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("77");
                        else if (decode[i] == 70)
                            tab.Add("45");
                        else
                            tab.Add("13");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] == decode[i - 10] && decode[i] != decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("74");
                        else if (decode[i] == 70)
                            tab.Add("42");
                        else
                            tab.Add("10");
                    }
                    if (decode[i] == decode[i + 10] && decode[i] != decode[i - 10] && decode[i] != decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("75");
                        else if (decode[i] == 70)
                            tab.Add("43");
                        else
                            tab.Add("11");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] == decode[i - 10] && decode[i] != decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("78");
                        else if (decode[i] == 70)
                            tab.Add("46");
                        else
                            tab.Add("14");
                    }
                    if (decode[i] != decode[i + 10] && decode[i] != decode[i - 10] && decode[i] != decode[i - 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("79");
                        else if (decode[i] == 70)
                            tab.Add("47");
                        else
                            tab.Add("15");
                    }
                }
                if (i > 90 && i < 99)
                {
                    if (decode[i] == decode[i - 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("68");
                        else if (decode[i] == 70)
                            tab.Add("36");
                        else
                            tab.Add("4");
                    }
                    if (decode[i] == decode[i - 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("70");
                        else if (decode[i] == 70)
                            tab.Add("38");
                        else
                            tab.Add("6");
                    }
                    if (decode[i] != decode[i - 10] && decode[i] == decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("69");
                        else if (decode[i] == 70)
                            tab.Add("37");
                        else
                            tab.Add("5");
                    }
                    if (decode[i] != decode[i - 10] && decode[i] != decode[i - 1] && decode[i] == decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("71");
                        else if (decode[i] == 70)
                            tab.Add("39");
                        else
                            tab.Add("7");
                    }
                    if (decode[i] == decode[i - 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("76");
                        else if (decode[i] == 70)
                            tab.Add("44");
                        else
                            tab.Add("12");
                    }
                    if (decode[i] == decode[i - 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("78");
                        else if (decode[i] == 70)
                            tab.Add("46");
                        else
                            tab.Add("14");
                    }
                    if (decode[i] != decode[i - 10] && decode[i] == decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("77");
                        else if (decode[i] == 70)
                            tab.Add("45");
                        else
                            tab.Add("13");
                    }
                    if (decode[i] != decode[i - 10] && decode[i] != decode[i - 1] && decode[i] != decode[i + 1])
                    {
                        if (decode[i] == 77)
                            tab.Add("79");
                        else if (decode[i] == 70)
                            tab.Add("47");
                        else
                            tab.Add("15");
                    }
                }

            }
        }


        //decodage des coins de la carte
        public void DecodageCoin(int i)
        {
            if (i == 0)
            {
                if (decode[i] == decode[i + 1] && decode[i] == decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("67");
                    else if (decode[i] == 70)
                        tab.Add("35");
                    else
                        tab.Add("3");
                }
                if (decode[i] != decode[i + 1] && decode[i] == decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("75");
                    else if (decode[i] == 70)
                        tab.Add("43");
                    else
                        tab.Add("11");
                }
                if (decode[i] == decode[i + 1] && decode[i] != decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("71");
                    else if (decode[i] == 70)
                        tab.Add("39");
                    else
                        tab.Add("7");
                }
                if (decode[i] != decode[i + 1] && decode[i] != decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("79");
                    else if (decode[i] == 70)
                        tab.Add("47");
                    else
                        tab.Add("15");
                }
            }
            if (i == 9)
            {
                if (decode[i] == decode[i - 1] && decode[i] == decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("73");
                    else if (decode[i] == 70)
                        tab.Add("41");
                    else
                        tab.Add("9");
                }
                if (decode[i] != decode[i - 1] && decode[i] == decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("75");
                    else if (decode[i] == 70)
                        tab.Add("43");
                    else
                        tab.Add("11");
                }
                if (decode[i] == decode[i - 1] && decode[i] != decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("77");
                    else if (decode[i] == 70)
                        tab.Add("45");
                    else
                        tab.Add("13");
                }
                if (decode[i] != decode[i - 1] && decode[i] != decode[i + 10])
                {
                    if (decode[i] == 77)
                        tab.Add("79");
                    else if (decode[i] == 70)
                        tab.Add("47");
                    else
                        tab.Add("15");
                }
            }
            if (i == 90)
            {
                if (decode[i] == decode[i + 1] && decode[i] == decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("70");
                    else if (decode[i] == 70)
                        tab.Add("38");
                    else
                        tab.Add("6");
                }
                if (decode[i] != decode[i + 1] && decode[i] == decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("75");
                    else if (decode[i] == 70)
                        tab.Add("43");
                    else
                        tab.Add("14");
                }
                if (decode[i] == decode[i + 1] && decode[i] != decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("71");
                    else if (decode[i] == 70)
                        tab.Add("39");
                    else
                        tab.Add("7");
                }
                if (decode[i] != decode[i + 1] && decode[i] != decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("79");
                    else if (decode[i] == 70)
                        tab.Add("47");
                    else
                        tab.Add("15");
                }
            }
            if (i == 99)
            {
                if (decode[i] == decode[i - 1] && decode[i] == decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("76");
                    else if (decode[i] == 70)
                        tab.Add("44");
                    else
                        tab.Add("12");
                }
                if (decode[i] != decode[i - 1] && decode[i] == decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("78");
                    else if (decode[i] == 70)
                        tab.Add("46");
                    else
                        tab.Add("14");
                }
                if (decode[i] == decode[i - 1] && decode[i] != decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("77");
                    else if (decode[i] == 70)
                        tab.Add("45");
                    else
                        tab.Add("13");
                }
                if (decode[i] != decode[i - 1] && decode[i] != decode[i - 10])
                {
                    if (decode[i] == 77)
                        tab.Add("79");
                    else if (decode[i] == 70)
                        tab.Add("47");
                    else
                        tab.Add("15");
                }
            }

        }


        //affichage de la carte avec affichage de ":" entre chaque unité et "|" à la fin d'une ligne
        public void AffichageCarteDecodee()
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89 || i == 99)
                    Console.Write(tab[i]);
                else
                    Console.Write(tab[i] + ":");

                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89 || i == 99)
                    Console.Write("|");
            }
            Console.WriteLine();
        }


        //creation du fichier 'nom de la carte'.clair dans le fichier /bin/Debug/netcoreapp3.1
        public void CreationFichierChiffre()
        {
            string rep;
            Console.WriteLine();
            Console.WriteLine("Voulez vous creer le fichier {0}.chiffre ? (O/N)", nomfichier);
            rep = Console.ReadLine();
            if (rep == "O" || rep == "o")
            {
                try
                {
                    StreamWriter sw = new StreamWriter(nomfichier + ".chiffre");
                    for (int i = 0; i < 100; i++)
                    {
                        if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89 || i == 99)
                            sw.Write(tab[i]);
                        else
                            sw.Write(tab[i] + ":");

                        if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49 || i == 59 || i == 69 || i == 79 || i == 89 || i == 99)
                            sw.Write("|");
                    }
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Le fichier {0}.chiffre a ete cree.", nomfichier);
                    Console.WriteLine("Il est situé dans ce repertoir /bin/Debug/netcoreapp3.1");
                }
            }
            else if (rep != "O" || rep != "o")
            {
                Console.WriteLine("Le fichier {0}.chiffre n'a pas ete cree.", nomfichier);

            }
        }
    }
}
