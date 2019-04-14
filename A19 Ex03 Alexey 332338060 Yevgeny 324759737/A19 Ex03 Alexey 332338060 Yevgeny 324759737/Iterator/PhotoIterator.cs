
using System.Collections.Generic;
using System.Linq;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class PhotoIterator : PostedItemIterator
    {
        public PhotoIterator (List<ModifiedPostedItem> i_SetOfPosts) : base(i_SetOfPosts)
        {
           
        }

        public override object Current
        {
            get
            {
                ModifiedPhoto photo = Collection.ElementAt(CurrentIndex) as ModifiedPhoto;
                return new PartialPhoto
                {
                    Message = photo.Message,
                    Picture = photo.PictureNormalURL
                };
            }

            
        }

        public class PartialPhoto
        {
            public string Message { get; set; }
            public string Picture { get; set; }
        }


    }
}
