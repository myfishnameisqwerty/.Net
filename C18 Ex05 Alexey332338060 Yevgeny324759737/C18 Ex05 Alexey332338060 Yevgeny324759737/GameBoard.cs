using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05_FourinRow_GUI
{
    public partial class GameBoard : Form
    {

        private int m_Rows;
        private int m_Columns;
        private Button[] m_ButtonsColumn;
        private Button[,] m_ButtonsCells;
        private Label m_LabelParticipants;
        private Label m_LabelPlayer1Points;
        private Label m_LabelPlayer2Points;
        private Label m_LabelColon;




        public GameBoard(int i_Rows, int i_Columns,string i_Player1Name,string i_Player2Name)
        {
            InitializeComponent();
            setDimensions(i_Rows, i_Columns);
            setColumnButtons();
            setCells();
            setPlayers(i_Player1Name, i_Player2Name);
            setScore();
        }

        public Label Participant
        {
            get { return m_LabelParticipants; }
        }


        public int Columns
        {
            get { return m_Columns; }
        }


        public Label PlayerOnePoints
        {
            get { return m_LabelPlayer1Points; }
        }

        public Label PlayerTwoPoints
        {
            get { return m_LabelPlayer2Points; }
        }


        private void setCells()
        {
            m_ButtonsCells = new Button[m_Rows, m_Columns];

            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Columns; j++)
                {
                    m_ButtonsCells[i, j] = new Button();
                    m_ButtonsCells[i, j].Height = m_ButtonsCells[i, j].Width = 40;
                    m_ButtonsCells[i, j].Left = j * m_ButtonsCells[i, j].Width;
                    setCellsTop(i,j);
                    Controls.Add(m_ButtonsCells[i, j]);
                }
            }

        }




        private void setScore()
        {
            m_LabelPlayer1Points = new Label();
            m_LabelPlayer2Points= new Label();
            m_LabelColon = new Label();
            
            m_LabelPlayer1Points.Location = new Point(40 * m_Columns/2 - 30, m_LabelParticipants.Location.Y + 25);
            m_LabelPlayer1Points.AutoSize = true;
            m_LabelColon.Location = new Point(m_LabelPlayer1Points.Location.X +25, m_LabelParticipants.Location.Y +25);
            m_LabelColon.AutoSize = true;
            m_LabelPlayer2Points.Location = new Point(m_LabelColon.Location.X +25, m_LabelParticipants.Location.Y +25);
            m_LabelPlayer1Points.Font = new Font(m_LabelPlayer1Points.Font.Name, 10, FontStyle.Bold);
            m_LabelPlayer2Points.Font = new Font(m_LabelPlayer2Points.Font.Name, 10, FontStyle.Bold);
            m_LabelPlayer1Points.Text = m_LabelPlayer2Points.Text = "0";
            m_LabelColon.Text = ":";
            Controls.Add(m_LabelPlayer1Points);
            Controls.Add(m_LabelColon);
            Controls.Add(m_LabelPlayer2Points);
        }

        private void setCellsTop(int i_RowIndex,int i_ColIndex)
        {

            m_ButtonsCells[i_RowIndex, i_ColIndex].Top = (i_RowIndex == 0 ? m_ButtonsColumn[i_RowIndex].Height 
                   : m_ButtonsCells[i_RowIndex - 1, i_ColIndex].Top + m_ButtonsCells[i_RowIndex, i_ColIndex].Height);
        }

        private void setColumnButtons()
        {
            m_ButtonsColumn = new Button[m_Columns];

            for (int i = 0; i < m_Columns; i++)
            {
                m_ButtonsColumn[i] = new Button();
                m_ButtonsColumn[i].Text = Convert.ToString(i + 1);
                m_ButtonsColumn[i].Height = 20;
                m_ButtonsColumn[i].Width = 40;
                m_ButtonsColumn[i].Left = i * m_ButtonsColumn[i].Width;
                Controls.Add(m_ButtonsColumn[i]);
            }

        }

        private void setDimensions(int i_Rows, int i_Columns)
        {
            m_Rows = i_Rows;
            m_Columns = i_Columns;
        }



        public Button [] ColumnButtons
        {
            get { return m_ButtonsColumn; }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            ClientSize = new Size((m_Columns * 2) * 20, (m_Rows * 2 + 4) * 20);
        }

        public Button[,] Cells
        {
            get { return m_ButtonsCells; }
        }


       


        private void setPlayers(string i_Name1,string i_Name2)
        {
            m_LabelParticipants = new Label();
            m_LabelParticipants.Location = new Point(40 * m_Columns / 2 - 30, m_ButtonsCells[m_Rows-1,0].Top+ m_ButtonsCells[m_Rows - 1, 0].Width+20);
            StringBuilder players = new StringBuilder(50);
            players.Append(string.Format(@"{0} vs {1}  ", i_Name1, i_Name2));
            m_LabelParticipants.Text = players.ToString();
            m_LabelParticipants.AutoSize = true;
            Controls.Add(m_LabelParticipants);
        }


    }










}
