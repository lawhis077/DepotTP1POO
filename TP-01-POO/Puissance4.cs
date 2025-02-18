﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
{
    internal class Puissance4
    {
        Util u = new Util();
        public static readonly int DECALAGE_X = 5;
        public static readonly int DECALAGE_Y = 5;
        
        public void Jouer()
        {
            bool tantQuePartieContinue = true;
            Grille _grille = new Grille();
            int nombreDeTour = 0;

            while (tantQuePartieContinue)
            {
                nombreDeTour++;
                u.Titre("Puissance de 4!        /       Par Louis Lamonde");

               
                _grille.Afficher();

                Console.Write("\n\nVotre Coup : ");
                char coup = u.SaisirChar();

                int col = ConvertCoupEnCol(coup);
                if (nombreDeTour % 2 == 0)
                {
                    _grille.InsererJeton(col, "x");
                    _grille.Afficher();

                }
                else 
                {
                    _grille.InsererJeton(col, "o");
                    _grille.Afficher();
                }

                tantQuePartieContinue = EstGagnant();
            }
        }

        private bool EstGagnant()
        {
           
        }

        private int ConvertCoupEnCol(char coup)
        {
            switch (coup)
            {
                case 'a':
                    return 0;
                case 'b':
                    return 1;
                case 'c':
                    return 2;
                case 'd':
                    return 3;
                case 'e':
                    return 4;
                case 'f':
                    return 5;
                case 'g':
                    return 6;

                default: return 0;




            }
        }
    }
}
