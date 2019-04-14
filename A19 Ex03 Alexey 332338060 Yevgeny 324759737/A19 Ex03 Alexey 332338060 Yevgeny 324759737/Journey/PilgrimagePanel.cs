
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    [DealDetailsExtension]
    public partial class PilgrimagePanel : UserControl, IDescribable, IPaneL
    {
        
        public PilgrimagePanel()
        {
            InitializeComponent();
        }

        public Panel CustomizedPanel
        {
            get { return religionPanel; }
        }

        public string GetDescription()
        {
            return "Religion";
        }
    }
}
