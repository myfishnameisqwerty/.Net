using System;
using System.Collections.Generic;
using System.Text;

namespace C18_Ex02
{
   public class Intelligence
    {
        public int ReturnColumn(char[,] i_GameField, int i_Columns)
        {
            List<int> options = new List<int>();
            for (int i = 0; i < i_Columns; i++)
            {
                if (i_GameField[0, i] == ' ')
                {
                    options.Add(i);
                }
            }
            Random randomItem = new Random();
            int randomIndex = randomItem.Next(options.Count);
            return options[randomIndex];
        }

    }
}

