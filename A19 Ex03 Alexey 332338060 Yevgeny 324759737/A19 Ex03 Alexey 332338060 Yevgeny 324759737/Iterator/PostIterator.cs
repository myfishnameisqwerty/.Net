using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737

{
    public class PostIterator  : PostedItemIterator
    {
        public PostIterator(List<ModifiedPostedItem> i_SetOfPosts) : base(i_SetOfPosts)
        {

        }

        public override object Current
        {
            get
            {
                ModifiedPost post = Collection.ElementAt(CurrentIndex) as ModifiedPost;

                return new PartialPost
                {
                    CreatedTime = post.CreatedTime,
                    Caption = post.Caption,
                    Message = post.Message,
                    PictureURL = post.PictureURL
                };
            }
        }

        public class PartialPost
        {
            public DateTime ? CreatedTime { get; set; }
            public string Caption { get; set; }
            public string Message { get; set; }
            public string PictureURL { get; set; }
        }
    }
}
