using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public abstract class CollectionIterator<T> : IEnumerator
    {

        public int CurrentIndex { get; set; }
        
        

        public IEnumerable<T> Collection { get; protected set; }

        public CollectionIterator(IEnumerable<T> i_SetOfItems)
        {
            Reset();
            Collection = i_SetOfItems;
        }



        public virtual object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return CurrentIndex < Collection.Count();
        }

        public virtual void Reset()
        {
            CurrentIndex = -1;
        }
    }
}
