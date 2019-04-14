using System;
using System.Collections.Generic;
using System.Text;

namespace C18_Ex02
{
    public class GameLogic
    {
        private char[,] m_gameField = null;
        private int m_Rows;
        private int m_Columns;
        private Intelligence m_Intellect = null;

        private Coordinates m_LastUpdatedCell = new Coordinates();


        public GameLogic(int i_Rows, int i_Columns)
        {
            m_Rows = i_Rows;
            m_Columns = i_Columns;
            m_gameField = new char[i_Rows, i_Columns];
            ClearLogicMatrix();
        }

        public void SetIntelligence()
        {
            m_Intellect = new Intelligence();
        }


        public void ClearLogicMatrix()
        {
            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Columns; j++)
                    m_gameField[i, j] = ' ';
            }

        }

        public void AITurn(Player i_Player)
        {
            int column = m_Intellect.ReturnColumn(m_gameField, m_Columns);
            InsertSymbol(column, i_Player);
        }

        public char[,] GameField
        {
            get { return m_gameField; }

        }

        public Coordinates LastUpdatedCell
        {
            get { return m_LastUpdatedCell; }
        }



        private int GetFirstEmptyRowCell(int i_Column)
        {
            int emptyRowCell = -1;
            for (int i = m_Rows-1; i >= 0; i--)
            {
                if (m_gameField[i, i_Column] == ' ')
                {
                    emptyRowCell = i;
                    break;
                }
            }
            return emptyRowCell;
        }
        public bool InsertSymbol(int i_Column, Player i_Participant)
        {
            bool returnStatement = true;
            m_LastUpdatedCell.Row = GetFirstEmptyRowCell(i_Column);
            m_LastUpdatedCell.Column = i_Column;

            if (m_LastUpdatedCell.Row > -1)
            {
                m_gameField[m_LastUpdatedCell.Row, m_LastUpdatedCell.Column] = i_Participant.Sign;
            }
            else
            {
                returnStatement = false;
            }
            return returnStatement;
        }





        private bool CheckIfInColumn()
        {
            bool victory = false;
            int sequence = 1;

            for (int i = m_LastUpdatedCell.Row + 1; i < m_Rows; i++)
            {
                if (m_gameField[i, m_LastUpdatedCell.Column] != m_gameField[i - 1, m_LastUpdatedCell.Column])
                {
                    break;
                }

                else if (SequenceIsFound(ref sequence))
                {
                    victory = true;
                    break;
                }

            }

            return victory;

        }

        private bool SequenceIsFound(ref int io_Sequence)
        {
            io_Sequence++;
            return io_Sequence == 4;
        }

        private bool FromUpperLeftToLowerRight(ref int io_Sequence)
        {
            bool victory = false;
            for (int i = m_LastUpdatedCell.Row + 1, j = m_LastUpdatedCell.Column + 1; i < m_Rows && j < m_Columns; i++, j++)
            {
                if (m_gameField[i, j] != m_gameField[i - 1, j - 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }

            }

            return victory;
        }


        private bool FromLowerRightToUpperLeft(ref int io_Sequence)
        {

            bool victory = false;

            for (int i = m_LastUpdatedCell.Row - 1, j = m_LastUpdatedCell.Column - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (m_gameField[i, j] != m_gameField[i + 1, j + 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }
            }

            return victory;
        }

        private bool FromUpperRightToLowerLeft(ref int io_Sequence)
        {
            bool victory = false;
            for (int i = m_LastUpdatedCell.Row + 1, j = m_LastUpdatedCell.Column - 1; i < m_Rows && j >= 0; i++, j--)
            {
                if (m_gameField[i, j] != m_gameField[i - 1, j + 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }


            }
            return victory;
        }

        private bool FromLowerLeftToUpperRight(ref int io_Sequence)
        {
            bool victory = false;
            for (int i = m_LastUpdatedCell.Row - 1, j = m_LastUpdatedCell.Column + 1; i >= 0 && j < m_Columns; i--, j++)
            {
                if (m_gameField[i, j] != m_gameField[i + 1, j - 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }
            }
            return victory;
        }

        private bool RightToLeft(ref int io_Sequence)
        {
            bool victory = false;
            for (int i = m_LastUpdatedCell.Column - 1; i >= 0; i--)
            {
                if (m_gameField[m_LastUpdatedCell.Row, i] != m_gameField[m_LastUpdatedCell.Row, i + 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }
            }

            return victory;
        }

        private bool LeftToRight(ref int io_Sequence)
        {
            bool victory = false;
            for (int i = m_LastUpdatedCell.Column + 1; i < m_Columns; i++)
            {
                if (m_gameField[m_LastUpdatedCell.Row, i] != m_gameField[m_LastUpdatedCell.Row, i - 1])
                {
                    break;
                }

                else if (SequenceIsFound(ref io_Sequence))
                {
                    victory = true;
                    break;
                }

            }
            return victory;
        }



        private bool CheckIfInMajorDiagonal()
        {
            bool victory;
            int sequence = 1;

            victory = FromUpperLeftToLowerRight(ref sequence);

            if (victory == false)
                victory = FromLowerRightToUpperLeft(ref sequence);


            return victory;

        }

        private bool CheckIfInMinorDiagonal()
        {
            bool victory;
            int sequence = 1;

            victory = FromUpperRightToLowerLeft(ref sequence);

            if (victory == false)
                victory = FromLowerLeftToUpperRight(ref sequence);

            return victory;

        }

        private bool CheckIfInRow()
        {
            bool victory;
            int sequence = 1;

            victory = RightToLeft(ref sequence);

            if (victory == false)
                victory = LeftToRight(ref sequence);

            return victory;

        }

        public bool CheckIfWin()
        {
            return CheckIfInMajorDiagonal()

                   || CheckIfInMinorDiagonal()

                   || CheckIfInRow()//DON'T FORGET!!!!

                   || CheckIfInColumn();
        }



        public bool CheckIfDraw()
        {
            bool fieldIsFull = true;

            for (int j = 0; j < m_Columns; j++)
            {
                if (m_gameField[0, j] == ' ')
                {
                    fieldIsFull = false;
                    break;
                }
            }

            return fieldIsFull;
        }






    }
}