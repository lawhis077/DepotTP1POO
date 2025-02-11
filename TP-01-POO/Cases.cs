using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
{
    internal class Cases
    {
        public string Contenu { get; set; }
        int _colonne;
        int _rangee;

        public Cases(int col, int ran)
        {
            _colonne = col;
            _rangee = ran;
            Contenu = "_";

        }

        public void Afficher()
        {
            Console.SetCursorPosition((_colonne * 4) + Puissance4.DECALAGE_X , _rangee + Puissance4.DECALAGE_Y + 2);
            Console.Write($"|_{Contenu}_|");
        }
    }
}
