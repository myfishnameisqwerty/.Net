using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class MenuItem
    {
        public Action Command { get; set; }
        public string Title { get; set; }

        public ToolStripMenuItem ToolStripMenuItem { get; set; }
     
        public MenuItem(string i_Title, Action i_Command)
        {
            Title = i_Title;
            Command = i_Command;
            ToolStripMenuItem = new ToolStripMenuItem(Title);
            ToolStripMenuItem.Click += Item_Click;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Command();
        }
    }
}
