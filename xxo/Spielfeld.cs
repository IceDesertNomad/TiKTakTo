using System.Drawing;

namespace xxo
{
    class Spielfeld
    {
       
        private readonly int[,] board = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        public int Board
        {
            get { return board[3,3]; }
            set { board[3,3] = value; }
        }


        //public TurnResult Turn(Point Coordinates)
        //{
        // wenn an mitgelieferten koordinaten bereits X oder O steht
        //      Methodenende und rückgabe von Invalid
        // zugzähler um 1 erhöhen
        // wenn aktueller spieler true
        //      an koordinaten ein X schreiben
        // andernfalls
        //      an koordinaten ein O schreiben
        // wenn in einer der spalten 3 gleiche oder in einer der zeilen 3 gleiche oder in einer der beiden diagonalen 3 gleiche
        //      Methodenende und rückgabe von Win
        // wenn zuganzahl gleich  9
        //      Methodenende und rückgabe von Tie
        // rückgabe von valid
        //}



    }
}
