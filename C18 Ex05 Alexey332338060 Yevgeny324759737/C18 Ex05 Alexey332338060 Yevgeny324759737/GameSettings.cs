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
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked == true)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer2.Text = "";
            }

            else
            {
                textBoxPlayer2.Enabled = false;
                textBoxPlayer2.Text = "Computer";
            }
           
        }



        private bool InputIsValid()
        {
            return textBoxPlayer1.Text != "" && textBoxPlayer1.Text != "Computer"
                   && textBoxPlayer2.Text != ""
                   && !(checkBoxPlayer2.Checked == true && textBoxPlayer2.Text == "Computer" )
                   && (textBoxPlayer1.Text != textBoxPlayer2.Text)
                   ;
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (InputIsValid())
            {
                Hide();
                Game tournament = new Game(int.Parse(numericUDRows.Value.ToString()),
                                        int.Parse(numericUDColumns.Value.ToString()),
                                       textBoxPlayer1.Text, textBoxPlayer2.Text);

                tournament.Run();
             }

            else
            {
                string message = string.Format(@"One of the following errors had happened:
     1.Human/human mode is chosen and name of one of the players is Computer
     2.Player's name is empty
     3.Human/computer mode is chosen and name of the 1st player is Computer
     4. Names must be different");
                MessageBox.Show(message, "Warning!! Nuclear fuel leak!!! We all gonna die    :(", MessageBoxButtons.OK);
            }

            

        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }
    }


}

