//-----------------------------------------
//  Nom: Colonne.cs
//  Auteur : Louis Lamonde
//  Date : 2025-02-26
//  Description: Fichier contenant la création des colonnes , l'affichage des colonnes ainsi que
//  l'insertion des jetons dans celles-ci
//-----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01Connect4
{

    internal class Colonne
    {
        public int rangeeChoisie = 0;
        public Cases[] _cases = new Cases[6];
        int _numero;
        // Creation des colonnes avec le bon nombre de cases
        public Colonne(int num)
        {
            _numero = num;

            for (int i = 0; i < 6; i++)
            {
                _cases[i] = new Cases(_numero, i);
            }
        }
        // Affichage des colonnes 
        public void Afficher()
        {
            foreach (Cases uneCase in _cases)
            {
                uneCase.Afficher();
            }
        }
        // Insertion des jetons, appliquant l'effet de gravité
        public void InsererJeton(string symbole)
        {
            bool rangeeEstPleine = true;

            for (int i = 5; i >= 0; i--)
            {
                if (_cases[i].Contenu == "_")
                {
                    _cases[i].Contenu = symbole;
                    rangeeEstPleine = false;
                    break;
                }
            }
            // Message d'erreur si l'écran est pleine
            if (rangeeEstPleine)
            {
                Console.WriteLine("La colonne est pleine!");
                Util u = new Util();
                u.Pause();
            }
        }


    }

}
    

