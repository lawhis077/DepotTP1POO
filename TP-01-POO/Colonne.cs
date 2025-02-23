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

        public Colonne(int num)
        {
            _numero = num;

            for (int i = 0; i < 6; i++)
            {
                _cases[i] = new Cases(_numero, i);
            }
        }

        public void Afficher()
        {
            foreach (Cases uneCase in _cases)
            {
                uneCase.Afficher();
            }
        }

        public void InsererJeton(string symbole)
        {

            for (int i = 5; i >= 0; i--)
            {
                if (_cases[i].Contenu == "_")
                {
                    _cases[i].Contenu = symbole;
                    //rangeeChoisie = i;
                    break;
                }

            }
        }

    }

}
    

