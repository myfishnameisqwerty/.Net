using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class TopListFacade: IAggregate
    {
        public List<ModifiedPostedItem> TopFiveItems { get; }
        public List<Follower> TopFiveFollowers { get; }
        public Operator Manager { get; }
        public PostedItemIterator ItemIterator { get; private set; }
        public  CollectionIterator<Follower> FansIterator { get;private set; }

        public TopListFacade()
        {
            TopFiveItems = new List<ModifiedPostedItem>();
            TopFiveFollowers = new List<Follower>();
            Manager = Operator.GetInstance();
        }



        internal void clearData()
        {
            TopFiveItems.Clear();
            TopFiveFollowers.Clear();
            BackToStart();
        }


        internal void BackToStart()
        {
            if (ItemIterator != null)
                ItemIterator.Reset();
        }



        public void TopFiveItemsRequest(int i_ForHowLong, string i_DataType)
        {

            //Type chosenType = TypeSearchEngine.FindDataType(typeof(PostedItem).Namespace.ToString(),
            //                                                 i_DataType.Substring(0, i_DataType.Length - 1));
            //Type type = Assembly.Load(typeof(PostedItem).Assembly.ToString()).GetTypes().First(t => t== Type.GetType(
            //                                                                                         string.Format(@"{0}.{1}", typeof(PostedItem).Namespace.ToString(), i_DataType.Substring(0, i_DataType.Length - 1),true,true)));

            if (i_DataType == "posts")
            {
                Manager.CreateRecentItemsListByDataType(typeof(Post), i_ForHowLong);
                Manager.GetListOfSelectedItems(TopFiveItems, i_ForHowLong, 5);
            }

            else if (i_DataType == "photos")
            {
                Manager.CreateRecentItemsListByDataType(typeof(Photo), i_ForHowLong);
                Manager.GetListOfSelectedItems(TopFiveItems, i_ForHowLong, 5);
            }


            //Manager.CreateRecentItemsListByDataType(type, i_ForHowLong);
            //    Manager.GetListOfSelectedItems(TopFiveItems, i_ForHowLong, 5);
        }


        public void TopFiveFollowersRequest(int i_ForHowLong)
        {

            Manager.GetRecentItemsOfAllTheTypes(i_ForHowLong);
            Manager.SendDataForFollowersList();
            Manager.GetListOfSelectedItems(TopFiveFollowers, i_ForHowLong, 5);
            
        }

        //public IEnumerator FansEnumerator()//Iterator pattern
        //{
        //    for (int i = 0; i < TopFiveFollowers.Count; i++)
        //        yield return new
        //        {
        //            Name = TopFiveFollowers[i].Person.Name,
        //            Likes = TopFiveFollowers[i].CountOfLikes
        //        };
        //}

        private PostedItemIterator initializePostedItemIterator(Type i_ChosenType, List<ModifiedPostedItem> i_TopList)
        {
            PostedItemIterator instance = (PostedItemIterator)Activator.CreateInstance(i_ChosenType, i_TopList); ;

            return instance;
        }



        private Type DefineChosenTypeOfItem(string i_UserChoice)
        {
            
            string nameSpace = this.GetType().Namespace.ToString();
            string typeName = string.Format(@"{0}Iterator",i_UserChoice.Substring(0, i_UserChoice.Length - 1));

            return TypeSearchEngine.TypeSearchAssemblyIsUnknown(nameSpace, typeName);
        }

        public void CreateIterator(params object[] i_UserChoice)
        {
            ItemIterator= initializePostedItemIterator( DefineChosenTypeOfItem((string)i_UserChoice[0]), TopFiveItems);
        }

        public  void  CreateIterator(List<Follower> i_Fans)
        {
            FansIterator = new FollowerIterator(i_Fans);
        }

        
    }
}