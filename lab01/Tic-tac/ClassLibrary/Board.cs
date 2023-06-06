using System;

namespace ClassLibrary
{
    public class Board
    {
        public int rowCount { private set; get; } = 3;
        public int columnCount { private set; get; } = 3;
        protected Cell[,] grid;
        public Cell[,] Grid
        {
            get { return grid; }
        }

        public Board()
        {
            this.grid = new Cell[rowCount, columnCount];
            this.FillBoardFromAToI();
        }
        public void FillBoardFromAToI()
        {
            int counter = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    this.grid[i, j] = new Cell(Convert.ToChar('A' + counter).ToString());
                    counter += 1;
                }
            }
        }

        public void ShowBoard()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write($"{this.grid[i, j].CurrentSign,3}");
                    if (j < columnCount - 1)
                        Console.Write($"{"|",3}");

                }
                Console.WriteLine("");
                Console.WriteLine("-----+-----+-----");
            }
        }

        public void InsertSignToCurrentPlace(string number, Player player)
        {
            switch (number)
            {
                case "A":
                    this.InsertSign("A", player);
                    break;
                case "B":
                    this.InsertSign("B", player);
                    break;
                case "C":
                    this.InsertSign("C", player);
                    break;
                case "D":
                    this.InsertSign("D", player);
                    break;
                case "E":
                    this.InsertSign("E", player);
                    break;
                case "F":
                    this.InsertSign("F", player);
                    break;
                case "G":
                    this.InsertSign("G", player);
                    break;
                case "H":
                    this.InsertSign("H", player);
                    break;
                case "I":
                    this.InsertSign("I", player);
                    break;
            }
        }

        protected void InsertSign(string number, Player player)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (this.grid[i, j].Number == number)
                    {
                        this.grid[i, j].CurrentSign = player.Sign;
                        this.grid[i, j].WhoChanged = player;
                    }
                }
            }
        }

        public bool IsBoardFilled()
        {
            bool state = false;
            int countOfFilled = 0;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    if (this.grid[i, j].CurrentSign != this.grid[i, j].Number.ToString())
                    {
                        countOfFilled++;
                    }
                }
            if (countOfFilled == (this.rowCount * this.columnCount))
                state = true;
            return state;
        }

    }
}
