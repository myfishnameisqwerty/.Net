using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class ModifiedPostedItem
    {
        protected PostedItem m_PostedItem;

        protected ModifiedPostedItem(PostedItem i_PostedItem)
        {
            m_PostedItem = i_PostedItem;
            Message = i_PostedItem.Message;
        }

        
        public string Message { get; set; }

        public FacebookObjectCollection<User> LikedBy
        {
            get { return m_PostedItem.LikedBy; }
        }

        public DateTime? CreatedTime
        {
            get { return m_PostedItem.CreatedTime; }
        }
        

    }
}
