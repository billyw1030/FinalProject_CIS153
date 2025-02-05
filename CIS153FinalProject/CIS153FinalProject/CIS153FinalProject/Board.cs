﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{
    class Board
    {//board has height of 6 and width of 7

        //   1   2   3   4   5   6   7
        //   8   9  10  11  12  13  14
        //  15  16  17  18  19  20  21
        //  22  23  24  25  26  27  28
        //  29  30  31  32  33  34  35 
        //  36  37  38  39  40  41  42
        
        private const int cols = 7, rows = 6;

        Cell[,] board = new Cell[rows, cols];
        public int GetNumRows()
        {
            return rows;
        }
        public int GetNumCols()
        {
            return cols;
        }

        public Cell[,] GetGameBoard()
        {
            return board;
        }

        public Cell GetCell(int r, int c)
        {
            return board[r, c];
        }

        public void SetGameBoardCell(Cell cell)
        {
            board[cell.GetR(), cell.GetC()] = cell;
        }
    }
}
