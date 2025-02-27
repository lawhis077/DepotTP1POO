using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------
//  Nom: Cases.cs
//  Auteur : Louis Lamonde
//  Date : 2025-02-26
//  Description: S'occupe de la création ainsi que la customisation des cases
//-----------------------------------------
namespace TP01Connect4
{
    internal class Cases
    {
        public string Contenu { get; set; }
        int _colonne;
        int _rangee;
        // Creation du nombre de cases spécifique ainsi que le contenu à l'intérieur
        public Cases(int col, int ran)
        {
            _colonne = col;
            _rangee = ran;
            Contenu = "_";

        }
        // Méthode changeant la couleur de la case selon le symbole de l'utilisateur
        public void Afficher()
        {
            Console.SetCursorPosition((_colonne * 4) + Puissance4.DECALAGE_X, _rangee + Puissance4.DECALAGE_Y + 2);

            if (Contenu == "x")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (Contenu == "o")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write($"|_{Contenu}_|");
            Console.ForegroundColor = ConsoleColor.White; 
        }

    }
}
