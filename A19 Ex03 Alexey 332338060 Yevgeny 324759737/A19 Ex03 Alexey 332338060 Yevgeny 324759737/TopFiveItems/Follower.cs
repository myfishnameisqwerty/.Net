using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737

{
    public class Follower
    {

        private readonly User m_Person;


        public User Person { get { return m_Person; } }

        public int CountOfLikes { set; get; }

        public Follower(User i_Follower)
        {
            m_Person = i_Follower;
            CountOfLikes = 1;
        }


    }
}