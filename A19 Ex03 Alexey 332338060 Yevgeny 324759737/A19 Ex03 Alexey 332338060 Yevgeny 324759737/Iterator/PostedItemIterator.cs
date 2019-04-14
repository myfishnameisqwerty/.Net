using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public abstract class PostedItemIterator : CollectionIterator<ModifiedPostedItem>
    {

        protected PostedItemIterator(List<ModifiedPostedItem> i_ItemsList) :base(i_ItemsList)
        {

        }

        public bool MoveBack()
        {
            CurrentIndex--;
            return CurrentIndex >=0;
        }

        public override void Reset()
        {
            CurrentIndex = 0;
        }


    }
}
