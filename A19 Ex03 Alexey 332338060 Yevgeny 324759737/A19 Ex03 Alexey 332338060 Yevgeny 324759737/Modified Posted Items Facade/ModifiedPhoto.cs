using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class ModifiedPhoto : ModifiedPostedItem
    {
        public string PictureNormalURL
        {
            get
            {
                return (m_PostedItem as Photo).PictureNormalURL;
            }
        }
        public string PictureAlbumURL
        {
            get
            {
                return (m_PostedItem as Photo).PictureAlbumURL;
            }
        }
        public string PictureThumbURL
        {
            get
            {
                return (m_PostedItem as Photo).PictureThumbURL;
            }
        }
        public ModifiedPhoto(PostedItem i_PostedItem) : base(i_PostedItem)
        {

        }
    }
}
