using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class ModifiedPost : ModifiedPostedItem
    {
        public string Caption { get; set; }

        public string PictureURL
        {
            get
            {
                return (m_PostedItem as Post).PictureURL;
            }
        }
        public ModifiedPost(PostedItem i_PostedItem) : base(i_PostedItem)
        {
            Caption = (i_PostedItem as Post).Caption;
        }
       
    }

  
}
