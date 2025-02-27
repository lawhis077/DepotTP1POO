using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------
//  Nom: Program.cs -- Connect4
//  Auteur : Louis Lamonde
//  Date : 2025-01-27
//  Description: Fichier contenant le déroulement général du jeux Connect 4
//-----------------------------------------

namespace TP01Connect4
{
    internal class Puissance4
    {
        Util u = new Util();
        public static readonly int DECALAGE_X = 5;
        public static readonly int DECALAGE_Y = 5;
        public const int MAX_RANGEE = 6;
        public bool tantQuePartieContinue = false;
        public string symbole = "x";
        public int col;
        // Méthode contenant le déroulement général d'une partie ainsi que si l'utilisateur veux refaire une partie
        public void Jouer()
        {

            char choixUtilisateur = 'X';
            while (choixUtilisateur != 'o' || choixUtilisateur != 'O')
            {
                tantQuePartieContinue = false;
                Grille _grille = new();

                PartieEnCours(_grille);


               
                Console.WriteLine("Voulez vous rejouer? [o/n]");

                Util util = new Util();
                choixUtilisateur = util.SaisirChar();
            }

            Console.WriteLine("Merci d'avoir jouer!!");
        }

        // Méthode contenant le déroulement d'une partie en cours
        public void PartieEnCours(Grille _grille)
        {
            int nombreDeTour = 0;
            while (!tantQuePartieContinue)
            {
                nombreDeTour++;
                u.Titre("Connect 4!!       /       Par Louis Lamonde");

                _grille.Afficher();

                Console.Write("\n\nVotre Coup : ");
                char coup = u.SaisirChar();

                col = ConvertCoupEnCol(coup);

                if (nombreDeTour % 2 == 0)
                {
                    symbole = "o"; 
                    _grille.InsererJeton(col, symbole);
                }
                else
                {
                    symbole = "x"; 
                    _grille.InsererJeton(col, symbole);
                }

                _grille.Afficher();

               
                if (_grille.EstGagnant())
                {
                    tantQuePartieContinue = true;
                    Console.WriteLine($"\nFelicitation au joueur {symbole} pour avoir gagné la partie!!");
                }
                else if (_grille.PartieNulle())
                {
                    tantQuePartieContinue = true;
                    Console.WriteLine("\nLa partie est nulle!");
                }
            }
        }
        // Méthode s'occupant de la conversion entre le coup choisi par le joueur et la colonne affectée
        public int ConvertCoupEnCol(char coup)
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

