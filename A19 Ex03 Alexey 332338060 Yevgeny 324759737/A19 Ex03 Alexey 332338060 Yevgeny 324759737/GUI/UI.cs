using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public partial class UI : Form
    {
        private Menu m_Menu;
        public UI()
        {
            InitializeComponent();
            LoadMenu();
            ShowDialog();
        }
        public void LoadMenu()
        {
            
            m_Menu = new Menu(selectFeatureToolStripMenuItem){
               new MenuItem ("Top 5 photos", loadTop5PhotosPanel ),
               new MenuItem ("Top 5 posts", loadTop5PostsPanel ),
               new MenuItem ("Top 5 folowers", loadTop5FolowersPanel ),
               new MenuItem ("Order journey", loadJourneyPanel ),
           };
            m_Menu.Load();
        }

     
        private void loadTop5PhotosPanel()
        {
            ProgramMenu PanelToDisplay = new ProgramMenu();
            clearAndLoad(PanelToDisplay);
            PanelToDisplay.comboBoxPostOrPhoto.Text = "photos";
            PanelToDisplay.radioButtonFilterMyTopContent.Checked = true;
            
            

        }
        private void loadTop5PostsPanel()
        {
            ProgramMenu PanelToDisplay = new ProgramMenu();
            clearAndLoad(PanelToDisplay);
            PanelToDisplay.comboBoxPostOrPhoto.Text = "posts";
            PanelToDisplay.radioButtonFilterMyTopContent.Checked = true;
        }
        private void loadTop5FolowersPanel()
        {
            ProgramMenu PanelToDisplay = new ProgramMenu();
            clearAndLoad(PanelToDisplay);
            PanelToDisplay.radioButtonShowMyFollowers.Checked = true;
        }

        private void loadJourneyPanel()
        {
            DealDetails panelToDisplay = new DealDetails();
            ProgramMenu programMenu = new ProgramMenu();
            programMenu.SpecialOffer();
            clearAndLoad(panelToDisplay);
        }

        private void clearAndLoad(UserControl i_Panel) 
        {
            panel.Controls.Clear();
            panel.Controls.Add(i_Panel);
        }
    }
}
