using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------
//  Nom: Grille.cs
//  Auteur : Louis Lamonde
//  Date : 2025-02-26
//  Description: S'occupe de la création ainsi que l'affichage de la grille et la vérification de combinaisons gagnantes
//-----------------------------------------

namespace TP01Connect4
{
    internal class Grille
    {
        Colonne[] _colonnes = new Colonne[7];
        // Création de la grille contenant les colonnes
        public Grille()
        {
            for (int i = 0; i < 7; i++)
            {
                _colonnes[i] = new Colonne(i);

            }
        }

        // Affichage de la grille ainsi que les différents choix possible pour le joueur
        public void Afficher()
        {
            Console.SetCursorPosition(Puissance4.DECALAGE_X, Puissance4.DECALAGE_Y);
            Console.WriteLine("  A   B   C   D   E   F   G");

            foreach (Colonne uneColonne in _colonnes)
            {
                uneColonne.Afficher();
            }
        }
        // Méthode qui s'occupe de l'insertion du jeton dans la case choisie
        public void InsererJeton(int col, string symbole)
        {
                _colonnes[col].InsererJeton(symbole);

        }

        // La plus grande méthode du programme, s'occupant de vérifier si il y a une combinaison gagnante, retourne bool true si oui...
        public bool EstGagnant()
        {
            // I pour rangée, j pour colonne
            // Pour une victoire horizontale...
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_colonnes[j]._cases[i].Contenu != "_" &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 1]._cases[i].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 2]._cases[i].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 3]._cases[i].Contenu)
                    {
                        return true;
                    }
                }
            }

            // Pour une victoire verticale...
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_colonnes[j]._cases[i].Contenu != "_" &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j]._cases[i + 1].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j]._cases[i + 2].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j]._cases[i + 3].Contenu)
                    {
                        return true;
                    }
                }
            }

            // Pour une victoire diagonale...(\)
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_colonnes[j]._cases[i].Contenu != "_" &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 1]._cases[i + 1].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 2]._cases[i + 2].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 3]._cases[i + 3].Contenu)
                    {
                        return true;
                    }
                }
            }

            // Pour une victoire diagonale... (/)
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i < 6; i++)
                {
                    if (_colonnes[j]._cases[i].Contenu != "_" &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 1]._cases[i - 1].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 2]._cases[i - 2].Contenu &&
                        _colonnes[j]._cases[i].Contenu == _colonnes[j + 3]._cases[i - 3].Contenu)
                    {
                        return true;
                    }
                }
            }

            return false; // Aucune victoire détectée
        }

        // Méthode vérifiant si toutes les colonnes sont pleine. Si oui, la partie est nulle...
        internal bool PartieNulle()
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    if (_colonnes[col]._cases[row].Contenu == "_")
                    {
                        return false; 
                    }
                }
            }
            return true;
        }
    }
}

