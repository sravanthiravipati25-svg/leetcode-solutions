public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool[,] rows = new bool[9, 9];
        bool[,] cols = new bool[9, 9];
        bool[,] boxes = new bool[9, 9];

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.')
                    continue;

                int num = board[r][c] - '1';
                int box = (r / 3) * 3 + (c / 3);

                if (rows[r, num] || cols[c, num] || boxes[box, num])
                    return false;

                rows[r, num] = true;
                cols[c, num] = true;
                boxes[box, num] = true;
            }
        }

        return true;
    }
}
