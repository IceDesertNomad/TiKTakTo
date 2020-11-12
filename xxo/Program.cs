using System;
using System.Dynamic;

namespace xxo
{
    class Program
    {
        static void Draw()
        {
            
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine(board[row, column]);

                }
            }
            // reihe zählen von 0 solange kleiner als 3
            //    spalte zählen von 0 solange kleiner als 3
            //      wenn im spielfeld an koordinate reihe,spalte leer steht
            //          ausgabe leerzeichen
            //      wenn im spielfeld an koordinate reihe,spalte X steht
            //          ausgabe eines X
            //      wenn im spielfeld an koordinate reihe,spalte O steht
            //          ausgabe eines O
            //      wenn im spielfeld an koordinate reihe,spalte hint steht
            //          ausgabe eines leerzeichens mit anderer hintergrundfarbe
            //    ende zählen spalte
            // ende zählen reihe


        }       
        static void Main()
        {
            //int[,] board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int column = 0; column < 3; column++)
            //    {
            //        Console.WriteLine(board[row, column]);
            //    }
            //}


            //Spielfeld
            string NameX;
            string NameY;
            Console.WriteLine("Welcome to TicTacToe!\n");// ausgabe begrüssung
            do
            {
                Console.WriteLine("Player X, please enter your name:"); // ausgabe Spieler X bitte name eingeben
                NameX = Console.ReadLine(); // eingabe von tastatur lesen und abspeichern
                Console.WriteLine("Welcome " + NameX);
            }
            while (string.IsNullOrEmpty(NameX)); //Prüfung ob etwas eingegeben wurde

            do
            {
                Console.WriteLine("Player Y, please enter your name:"); // ausgabe Spieler Y bitte name eingeben
                NameY = Console.ReadLine();// eingabe von tastatur lesen und abspeichern
                Console.WriteLine("Welcome " + NameY);
            }
            while (string.IsNullOrEmpty(NameY)); //Prüfung ob etwas eingegeben wurde
            //TODO Namen auf Gleichheit prüfen

            //do // wiederholen
            //   spiel auf anfangszustand setzen
            //   wiederholen
            //      spielfeld anzeigen
            //      wiederholen
            //          ausgabe Bitte feld auswählen
            //          eingabe des feldes lesen und abspeichern
            //          zug durchführen und ergebnis abspeichern
            //      solange Spielerzug ungültig
            //   solange Spielerzug gültig
            //if//   wenn spielerzug unentschieden
            //    Console.WriteLine("You tied. Better luck next time");//      ausgabe unentschieden
            // else//   andernfalls
            //      ausgabe aktueller spieler hat gewonnen
            //   ausgabe möchten sie noch ein spiel?
            //while // solange y von der tastatur gelesen wurde

        }
    }
}