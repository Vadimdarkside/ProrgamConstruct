namespace ClassLibrary
{
    public class Cell
    {
        protected string currentSign;
        protected string number;
        protected Player whoChanged = null;
        public string Number
        {
            set { this.number = value; }
            get { return number; }
        }
        public string CurrentSign
        {
            set { this.currentSign = value; }
            get { return currentSign; }
        }
        public Player WhoChanged
        {
            set { this.whoChanged = value; }
            get { return whoChanged; }
        }

        public Cell(string number)
        {
            this.CurrentSign = number.ToString();
            this.number = number;
        }

        public static Cell GetCellInNumber(string number, Cell[,] grid)
        {
            Cell found = null;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Number == number)
                    {
                        found = grid[i, j];
                    }
                }
            }
            return found;
        }
    }
}
