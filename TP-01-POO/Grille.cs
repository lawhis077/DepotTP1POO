using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01Connect4
{
    internal class Grille
    {
        Colonne[] _colonnes = new Colonne[7];

        public Grille()
        {
            for (int i = 0; i < 7; i++)
            {
                _colonnes[i] = new Colonne(i);

            }
        }


        public void Afficher()
        {
            Console.SetCursorPosition(Puissance4.DECALAGE_X, Puissance4.DECALAGE_Y);
            Console.WriteLine("  A   B   C   D   E   F   G");

            foreach (Colonne uneColonne in _colonnes)
            {
                uneColonne.Afficher();
            }
        }

        public void InsererJeton(int col, string symbole)
        {
                _colonnes[col].InsererJeton(symbole);

        }


        public bool EstGagnant()
        {
            // Check for horizontal win
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++) // Only check up to column 3 to avoid out-of-bounds
                {
                    if (_colonnes[col]._cases[row].Contenu != "_" &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 1]._cases[row].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 2]._cases[row].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 3]._cases[row].Contenu)
                    {
                        return true; // Found a winning line
                    }
                }
            }

            // Check for vertical win
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 3; row++) // Only check up to row 2 to avoid out-of-bounds
                {
                    if (_colonnes[col]._cases[row].Contenu != "_" &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col]._cases[row + 1].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col]._cases[row + 2].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col]._cases[row + 3].Contenu)
                    {
                        return true; // Found a winning line
                    }
                }
            }

            // Check for diagonal win (\)
            for (int col = 0; col < 4; col++) // Only check up to column 3
            {
                for (int row = 0; row < 3; row++) // Only check up to row 2
                {
                    if (_colonnes[col]._cases[row].Contenu != "_" &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 1]._cases[row + 1].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 2]._cases[row + 2].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 3]._cases[row + 3].Contenu)
                    {
                        return true;
                    }
                }
            }

            // Check for diagonal win (/)
            for (int col = 0; col < 4; col++) // Only check up to column 3
            {
                for (int row = 3; row < 6; row++) // Start from row 3 (to avoid out-of-bounds)
                {
                    if (_colonnes[col]._cases[row].Contenu != "_" &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 1]._cases[row - 1].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 2]._cases[row - 2].Contenu &&
                        _colonnes[col]._cases[row].Contenu == _colonnes[col + 3]._cases[row - 3].Contenu)
                    {
                        return true;
                    }
                }
            }

            return false; // No win condition found
        }
    }
}

