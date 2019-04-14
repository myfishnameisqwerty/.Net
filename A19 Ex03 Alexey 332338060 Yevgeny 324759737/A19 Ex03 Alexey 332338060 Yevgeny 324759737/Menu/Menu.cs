using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class Menu : List<MenuItem>
    {
        ToolStripMenuItem m_Item;
        public Menu(ToolStripMenuItem i_Item)
        {
            m_Item = i_Item;
        }
        public void Load()
        {
            int id = 0;
            foreach (MenuItem item in this)
            {
                item.ToolStripMenuItem.Tag = id;
                m_Item.DropDownItems.Add(item.ToolStripMenuItem);
                id++;
            }
        }

    }
}
