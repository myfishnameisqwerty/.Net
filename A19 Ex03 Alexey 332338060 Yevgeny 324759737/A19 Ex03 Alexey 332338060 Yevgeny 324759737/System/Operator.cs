using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public class Operator
    {
        private const string m_AppID = "316022262332012";
        private static readonly object sr_LoginLock = new object();
        private FillCollectionStrategy m_Launcher;

        private volatile static Operator uniqueInstance;
        private LastAppSession m_LastSessionData;
        private LoginResult m_FacebookServices;
        private bool m_AllTheTypes;
        private User m_User;

        private List<int> m_ListOfLikes;

        private List<ModifiedPostedItem> m_ListOfItems;
        private Dictionary<string, Follower> m_FollowersEverLiked;


        public float BirthdayDiscount { get; private set; }



        public void Run()
        {
            
            if (TryToLoginViaCookies() == false)
            {
                LoginPage loginPage = new LoginPage();
            }

        }

        public static Operator GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (sr_LoginLock)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new Operator();
                }
            }

            return uniqueInstance;
        }


        public void LoadDiscount()
        {
            bool discountRewardee = ifDiscountRecipient();
            BirthdayDiscount = (discountRewardee == true ? 0.8f : 0.0f);
        }

        public void SendJourneyInvitationToFriend(Journey i_Trip)
        {
            Journey cloneTrip = Serializator.DeepClone<Journey>(i_Trip);
            SendRequestToFacebook(cloneTrip);
        }


        private void SendRequestToFacebook(Journey i_Trip)
        {
            //HERE WE ARE TO IMPLEMENT AN INTERACTION WITH FACEBOOK SERVER WHICH IS NOT POSSIBLE 
            //DUE TO ACCESS RESTRICTIONS
        }







        private bool ifDiscountRecipient()
        {
            return DateTime.Now.Day == DateTime.ParseExact(LoggedUser.Birthday, "MM/dd/yyyy", null).Day &&
             IfRoundAnniversary();
        }

        private bool IfRoundAnniversary()
        {
            int currentYear = DateTime.Now.Year;
            int birthYear = DateTime.ParseExact(LoggedUser.Birthday, "MM/dd/yyyy", null).Year;


            return (currentYear - birthYear) % 10 == 0;
        }



        private bool TryToLoginViaCookies()
        {
            bool ifSucceed = false;
            string sessionPath = @"Resources\LastAppSession.xml";
            if (File.Exists(LastAppSession.LoadFilePath(sessionPath)))
            {
                m_LastSessionData = LastAppSession.ReadFromFile(sessionPath);

                try
                {
                    m_FacebookServices = FacebookService.Connect(m_LastSessionData.LastAccessToken);
                    SignIn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ifSucceed = true;
                RunProgramMenu();

            }
            return ifSucceed;

        }

        public void SignIn()
        {

            try
            {
                m_FacebookServices = FacebookService.Login(m_AppID,
                    "public_profile",
                    "user_gender",
                    "user_birthday",
                    "user_friends",
                    "user_photos",
                    "user_posts",
                    "user_likes",
                    "manage_pages",
                    "publish_pages"

                );
                m_User = m_FacebookServices.LoggedInUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        public User LoggedUser { get { return m_User; } }



        public void SignOut()
        {

            m_LastSessionData.RemoveLastAppSessionXML();

            Application.Exit();
        }

        public void SaveLoginData()
        {
            m_LastSessionData = new LastAppSession();


            m_LastSessionData.LastAccessToken = m_FacebookServices.AccessToken;

            m_LastSessionData.WriteToFile();



        }

        public void RunProgramMenu()
        {
            UI ui = new UI();
            //ui.LoadMenu();

            //ProgramMenu programMenu = new ProgramMenu();
        }

        public void PostText(String i_Text)
        {
            Status postStatus = m_User.PostStatus(i_Text);
            
        }

        private void createRecentPhotosList(int i_ForHowLong)
        {
            foreach (Album album in m_User.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    fillRecentLists(new ModifiedPhoto(photo), i_ForHowLong);

                }
            }
        }

        private void initializeLists()
        {
            m_ListOfItems = new List<ModifiedPostedItem>();
            m_ListOfLikes = new List<int>();



            if (m_AllTheTypes)
                m_FollowersEverLiked = new Dictionary<string, Follower>();
        }

        private void createRecentPostsList(int i_ForHowLong)
        {
            foreach (Post post in m_User.Posts)
            {
                fillRecentLists(new ModifiedPost(post), i_ForHowLong);
            }
        }

        private void fillRecentLists(ModifiedPostedItem i_Item, int i_ForHowLong)
        {
            // We have  really vivid imagination for names!!!!
            DateTime itemCreationDate;

            itemCreationDate = (DateTime)i_Item.CreatedTime;
            DateTime today = DateTime.Today;

            if (isRecent(i_ForHowLong, today, itemCreationDate))
            {
                m_ListOfItems.Add(i_Item);

                if (!m_AllTheTypes)//We retrieve like counts in case we wanna get top of specific-type items
                    m_ListOfLikes.Add(i_Item.LikedBy.Count);
            }

        }
        public void CreateRecentItemsListByDataType(Type i_DataType, int i_ForHowLong)
        {
            m_AllTheTypes = false;
            initializeLists();

            m_Launcher = new FillCollectionStrategy(createRecentPhotosList);

            if (i_DataType == typeof(Post))
            {
                m_Launcher.Filler = createRecentPostsList;
            }

            m_Launcher.Filler.Invoke(i_ForHowLong);

        }

        public void GetRecentItemsOfAllTheTypes(int i_ForHowLong)
        {
            m_AllTheTypes = true;//Here we request for ALL the recent items thus to retrieve 5 top followers
            initializeLists();
            createRecentPhotosList(i_ForHowLong);
            createRecentPostsList(i_ForHowLong);

        }

        internal void GetListOfFriends(List<string> i_ListOfFriends)
        {
            foreach (User friend in m_User.Friends)
            {
                i_ListOfFriends.Add(friend.FirstName + friend.LastName);
            }
        }

        public void SendDataForFollowersList()
        {
            retrieveFollowersWhoEverLiked();
            buildListOfLikesPerFollower();
        }

        private void retrieveFollowersWhoEverLiked()
        {
            foreach (ModifiedPostedItem unit in m_ListOfItems)
            {
                foreach (User follower in unit.LikedBy)
                {
                    if (m_FollowersEverLiked.ContainsKey(follower.Id))
                        m_FollowersEverLiked[follower.Id].CountOfLikes++;
                    else
                        m_FollowersEverLiked.Add(follower.Id, new Follower(follower));

                }
            }
        }

        private void buildListOfLikesPerFollower()
        {
            foreach (KeyValuePair<string, Follower> unit in m_FollowersEverLiked)
            {
                m_ListOfLikes.Add(unit.Value.CountOfLikes);
            }

        }


        private bool isRecent(int i_maxDiff, DateTime i_Today, DateTime i_toCompare)
        {
            return (i_Today.Month - i_toCompare.Month) + 12 * (i_Today.Year - i_toCompare.Year) <= i_maxDiff;
        }

        public void GetListOfSelectedItems(object i_DataList, int i_ForHowLong, int i_NumberOfItemsToDisplay)
        {
            for (int i = 0; i < i_NumberOfItemsToDisplay; i++)
            {
                int current = KthMinOrMaxElement.kthSmallest(m_ListOfLikes, 0, m_ListOfLikes.Count - 1, m_ListOfLikes.Count - i + 1);

                if (current >= 0)
                {
                    if (!m_AllTheTypes)
                        (i_DataList as List<ModifiedPostedItem>).Add(m_ListOfItems[current]);
                    else
                        (i_DataList as List<Follower>).Add(m_FollowersEverLiked.ElementAt(current).Value);
                }
            }

        }
    }




}

