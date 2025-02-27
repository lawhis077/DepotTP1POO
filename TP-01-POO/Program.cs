
//-----------------------------------------
//  Nom: Program.cs
//  Auteur : Louis Lamonde
//  Date : 2025-02-26
//  Description: Fichier de départ du programme qui 
//  redirectionne vers le jeux Connect 4   
//-----------------------------------------

using System.Runtime.CompilerServices;

// Methode Main qui envoie l'utilisateur vers la partie Connect 4
namespace TP01Connect4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puissance4 jouerPuissance4 = new();

            jouerPuissance4.Jouer();
        }
    }
}
