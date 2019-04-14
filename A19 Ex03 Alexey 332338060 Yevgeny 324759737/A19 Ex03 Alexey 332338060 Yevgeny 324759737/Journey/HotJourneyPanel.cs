using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    [DealDetailsExtension]
    public partial class HotJourneyPanel : UserControl, IDescribable, IPaneL
    {

        

        public HotJourneyPanel()
        {
            InitializeComponent();
        }


        public Panel CustomizedPanel
        {
            get { return sexTrip; }
        }

        

        public string GetDescription()
        {
            return "Sex trip";
        }
    }
}
