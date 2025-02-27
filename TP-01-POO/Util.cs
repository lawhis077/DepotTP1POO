//-----------------------------------------
//  Nom: Util.cs
//  Auteur : Louis Lamonde
//  Date : 2025-02-26
//  Description: Fichier contenant les methodes utiles à l'affichage du programme
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01Connect4

{
    internal class Util
    {

        public Random R = new Random();

        //------------------------------------------
        // Methode Mettant un titre au programme 
        //------------------------------------------
        public void Titre(string leTitre)
        {

            ViderEcran();
            for (int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            Console.WriteLine(leTitre);

            for (int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("\n\n");
        }

        //------------------------------------------
        // Méthode permettant l'entrée de donnée par l'utilisateur
        //------------------------------------------
        public char SaisirChar()
        {
            ConsoleKeyInfo cle;
            cle = Console.ReadKey(true);
            return cle.KeyChar;
        }


        //------------------------------------------
        // Méthode permettant de vider l'écran
        //------------------------------------------
        public void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //------------------------------------------
        // Méthode mettant une pause au programme 
        //------------------------------------------
        public void Pause()
        {
            Console.WriteLine("\n\tAppuyez sur une touche...");
            Console.ReadKey(true);
        }

    }
}
