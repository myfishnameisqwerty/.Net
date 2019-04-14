using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class FollowerIterator : CollectionIterator<Follower>
    {
        public FollowerIterator(List<Follower> i_SetOfFans): base(i_SetOfFans)
        {
            
           
        }

        public override object Current
        {
            get
            {
                Follower fan = Collection.ElementAt(CurrentIndex) as Follower;
                return new PartialFollower
                {
                    Name = fan.Person.Name,
                    Likes = fan.CountOfLikes
                };
            }
        }

        public class PartialFollower
        {
            public string Name { get; set; }
            public int Likes { get; set; }
        }
    }
}
