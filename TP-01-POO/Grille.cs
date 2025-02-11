using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
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

            foreach(Colonne uneColonne in _colonnes)
            {
                uneColonne.Afficher();
            }
        }

        public void InsererJeton(int col, string symbole)
        {
            
            _colonnes[col].InsererJeton(symbole);



        }
    }
}
