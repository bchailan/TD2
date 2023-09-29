using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAILAN_Bérénice_TD2_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création du tableau des mois sans couleurs
            String[] moissanscouleurs = new string[12];
            moissanscouleurs[0] = "Janvier";
            moissanscouleurs[1] = "Février";
            moissanscouleurs[2] = "Mars";
            moissanscouleurs[3] = "Avril";
            moissanscouleurs[4] = "Mai";
            moissanscouleurs[5] = "Juin";
            moissanscouleurs[6] = "Juillet";
            moissanscouleurs[7] = "Aout";
            moissanscouleurs[8] = "Septembre";
            moissanscouleurs[9] = "Octobre";
            moissanscouleurs[10] = "Novembre";
            moissanscouleurs[11] = "Décembre";
            //création d'une variable mois qui stocke les chaines de caractères
            foreach (string Mois in moissanscouleurs)
            {
                Console.WriteLine(Mois); //la variable est écrite puis s'exécute à la fin
            }
            //création d'un nouveau tableau pour les mois avec la lettre r en rouge
            String[] mois = new string[12];
            mois[0] = "Janvier";
            mois[1] = "Février";
            mois[2] = "Mars";
            mois[3] = "Avril";
            mois[4] = "Mai";
            mois[5] = "Juin";
            mois[6] = "Juillet";
            mois[7] = "Aout";
            mois[8] = "Septembre";
            mois[9] = "Octobre";
            mois[10] = "Novembre";
            mois[11] = "Décembre";
            //création de la variable moisrouge qui stocke les valeurs
            foreach(string moisrouge in mois)
        {
                if (moisrouge.Contains("r") || moisrouge.Contains("R")) //création d'une condition si qui dit que "si le mois contient la r ou R 
                {
                    Console.ForegroundColor = ConsoleColor.Red; //si oui alors elle applique la couleur rouge
                }
                else
                {
                    Console.ResetColor(); //sinon elle remet la couleur de base
                }

                Console.WriteLine(moisrouge); //la variable moisrouge est écrite 
            }

            Console.ResetColor(); //j'enlève la couleur pour que le reste du code ne sois pas rouge
            //création du dernier tableau 
            String[] moischiffre = new string[12];
            moischiffre[0] = "Janvier";
            moischiffre[1] = "Février";
            moischiffre[2] = "Mars";
            moischiffre[3] = "Avril";
            moischiffre[4] = "Mai";
            moischiffre[5] = "Juin";
            moischiffre[6] = "Juillet";
            moischiffre[7] = "Aout";
            moischiffre[8] = "Septembre";
            moischiffre[9] = "Octobre";
            moischiffre[10] = "Novembre";
            moischiffre[11] = "Décembre";
            //création d'une boucle for 
            for (int i = 0; i < moischiffre.Length; i++)
            {
                Console.WriteLine($"{i + 1} {moischiffre[i]}"); //tant que les valeurs du tableaux ne sont pas finis, on rajoute +1 devant chaque itération
            }
            Console.ReadLine();  //lecture du code sur le terminal
        }
    }

}
                
            
        
    

