using System;
using System.Collections.Generic;
using System.Text;

namespace C18_Ex02
{
    public class Player
    {
        private char m_Sign;
        private bool m_IsComputer;
        private int m_score;
        private string m_Name;
        public Player(char i_Sign, string i_Rival)
        {
            m_Sign = i_Sign;
            m_Name = i_Rival;
            m_IsComputer = i_Rival.Equals("Computer");
            m_score = 0;
        }
        public char Sign
        {
            get { return m_Sign; }
        }
        public bool IsComputer
        {
            get { return m_IsComputer; }
        }
        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }
        public string Name
        {
            get { return m_Name; }
        }

    }
}
