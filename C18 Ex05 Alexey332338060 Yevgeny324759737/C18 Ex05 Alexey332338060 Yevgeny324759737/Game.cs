using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C18_Ex02;
using System.Windows.Forms;

namespace Ex05_FourinRow_GUI
{
    public class Game
    {
        private GameLogic m_Logic = null;
        private GameBoard m_GameField=null;
        private int m_GameMode;
        private bool m_gameOver=false,m_Quit=false;
        private Player m_Player1 = null;
        private Player m_Player2 = null;
        private Player m_CurrentPlayer = null;
        





        public Game(int i_Rows, int i_Columns, string i_Player1Name, string i_Player2Name)
        {
            m_GameField = new GameBoard(i_Rows, i_Columns, i_Player1Name, i_Player2Name);
            m_Logic = new GameLogic(i_Rows, i_Columns);
            m_GameMode = SetGameMode(i_Player1Name, i_Player2Name);
            
        }

        public void Run()
        {

            if (m_GameMode == 2)
                m_Logic.SetIntelligence();
            StartTheGame();
               
        }

        private void StartTheGame()
        {
            m_gameOver = false;
            SubscribeForColumnButtonsClick();
            m_GameField.ShowDialog();

        }

         private void PassTheTurn()
        {
            m_CurrentPlayer = (m_CurrentPlayer == m_Player1 ? m_Player2 : m_Player1);
        }

        private void CheckIfGameIsOver(Player i_Player)
        {
            bool victory = m_Logic.CheckIfWin();
            bool draw = m_Logic.CheckIfDraw();
            m_gameOver = victory || draw;


            if (m_gameOver)
            {
                string message = "", capture = "Another round ?";

                if (victory)
                {
                    i_Player.Score++;
                    UpdateScore(i_Player);
                    message = string.Format("{0} Win!", m_CurrentPlayer.Name);
                }

                else if (draw)
                    message = "Draw!";

                AnotherRoundOrQuit(capture, message);
                Clear_Matrices();
            }

            else
              PassTheTurn();
           }

        private void Clear_Matrices()
        {
            m_Logic.ClearLogicMatrix();

            ClearGameField();
        }

        private void ClearGameField()
        {
            foreach(Button button in m_GameField.Cells)
            {
                 button.ResetText();
            }

            foreach(Button button in m_GameField.ColumnButtons)
            {
                if (button.Enabled == false)
                    button.Enabled = true;
            }
         }

        private void UpdateScore(Player i_Winner)
        {
            if (m_CurrentPlayer==m_Player1)
                m_GameField.PlayerOnePoints.Text = i_Winner.Score.ToString();

            else
                m_GameField.PlayerTwoPoints.Text = i_Winner.Score.ToString();
                          
        }


        private void AnotherRoundOrQuit(string i_Headline,string i_Message)
        {
            DialogResult result = MessageBox.Show(i_Headline, i_Message, MessageBoxButtons.YesNo);
             m_Quit = (result == DialogResult.No ? true : false);

            if(!m_Quit)
                PassTheTurn();

            else
                m_GameField.Close();
        }


        private int SetGameMode(string i_FirstPlayerName, string i_SecondPlayerName)
        {
            int gameMode;


            gameMode = (i_SecondPlayerName == "Computer" ? 2 : 1);

            m_Player2 = new Player('O', i_SecondPlayerName);

            m_Player1 = new Player('X', i_FirstPlayerName);
            m_CurrentPlayer = m_Player1;

            return gameMode;
        }




        private void SubscribeForColumnButtonsClick()
        {
            foreach(Button button in m_GameField.ColumnButtons)
            {
                button.Click += columnButtons_Click;
            }

        }

        

        private bool ColumnIsFull()
        {
            return m_Logic.LastUpdatedCell.Row == 0;
        }


        private void columnButtons_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int column = int.Parse(clickedButton.Text)-1;

                if (m_Logic.InsertSymbol(column, m_CurrentPlayer))
                {
                    m_GameField.Cells[m_Logic.LastUpdatedCell.Row, column].Text = m_CurrentPlayer.Sign.ToString();
                    m_GameField.ColumnButtons[column].Enabled = (ColumnIsFull() ? false : true);
                }
             }
            CheckIfGameIsOver(m_CurrentPlayer);
            CheckIfAITurn();
        }

        private void CheckIfAITurn()
        {
            if (m_CurrentPlayer.IsComputer)
            {
                m_Logic.AITurn(m_CurrentPlayer);
                m_GameField.Cells[m_Logic.LastUpdatedCell.Row, m_Logic.LastUpdatedCell.Column].Text = m_CurrentPlayer.Sign.ToString();
                m_GameField.ColumnButtons[m_Logic.LastUpdatedCell.Column].Enabled = (ColumnIsFull() ? false : true);
                CheckIfGameIsOver(m_CurrentPlayer);
            }
        }



    }
}
