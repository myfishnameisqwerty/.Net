using System;
using FacebookWrapper;
using FacebookResources = A19_Ex03_Alexey_332338060_Yevgeny_324759737.Properties.Resources;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;


namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public partial class ProgramMenu : UserControl
    {
        private Image m_ImageFacebookLogout;
        private Image m_ImageLeft;
        private Image m_ImageRight;
        private Image m_ImageLoading;
        private TopListFacade m_Facade;
        private Operator m_Operator;
        private Dictionary<string, int> m_DateRange;
        //private int currentItemNumber = 0;
        private DealDetails m_Offer;
        
        

        Thread m_Request;

        public ProgramMenu()
        {
            loadDesignDetails();
            loadLogicDetails();
            //ShowDialog();
        }



        private void loadDesignDetails()
        {
            m_ImageFacebookLogout = FacebookResources.facebook_logout_button;
            m_ImageLeft = FacebookResources.left;
            m_ImageRight = FacebookResources.right;
            m_ImageLoading = FacebookResources.Loading_icon;
        }

        private void loadLogicDetails()
        {
            m_Facade = new TopListFacade();
            m_DateRange = new Dictionary<string, int>();
            m_Operator = Operator.GetInstance();

            InitializeComponent();
            initializeAdditionalProperties();

        }

        //private void stamButton_Click()
        //{

        //}






        private void initializeAdditionalProperties()
        {
            pictureBoxFacebookLogout.Image = m_ImageFacebookLogout;
            pictureBoxLeft.Image = m_ImageLeft;
            pictureBoxRight.Image = m_ImageRight;
            showProfilePhoto();
            showUserName();
            fillComboboxDateRange();
            fillComboboxPostOrPhotos();
        }
        private void fillComboboxDateRange()
        {
            addToComboboxDateRange("Last month", 1);
            addToComboboxDateRange("Last 3 month", 3);
            addToComboboxDateRange("Last 6 month", 6);
            addToComboboxDateRange("Last year", 12);
            addToComboboxDateRange("All", 1000); // 83 years of support =))
        }

        private void fillComboboxPostOrPhotos()
        {
            comboBoxPostOrPhoto.Items.Add("posts");
            comboBoxPostOrPhoto.Items.Add("photos");
        }
        private void addToComboboxDateRange(string i_Date, int i_NumOfMonth)
        {
            m_DateRange.Add(i_Date, i_NumOfMonth);
            comboBoxDateRange.Items.Add(i_Date);
        }

        public void SpecialOffer()
        {
            m_Operator.LoadDiscount();
            if (m_Operator.BirthdayDiscount > 0)
                MessageBox.Show(string.Format(@"CONGRATS!!! You won {0} % discount for our travel", m_Operator.BirthdayDiscount * 100));
            m_Offer = new DealDetails();

        }

        private void pictureBoxFacebookLogout_Click(object sender, EventArgs e)
        {
            Action signout = m_Operator.SignOut;
            FacebookService.Logout(signout);
        }

        private void ProgramMenu_Load(object sender, EventArgs e)
        {

        }





        private void showProfilePhoto()
        {
            pictureBoxProfilePhoto.LoadAsync(m_Operator.LoggedUser.PictureNormalURL);
        }





        private void showUserName()
        {
            labelUserName.Text = string.Format(@"{0}  {1}", m_Operator.LoggedUser.FirstName, m_Operator.LoggedUser.LastName);
        }

        //private void buttonPost_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Status postStatus = m_Operator.LoggedUser.PostStatus(richTextBoxStatus.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}


        private void listBoxNews_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void showSlashAndNumberOfItems()
        {
            m_Facade.BackToStart();
            if (m_Facade.TopFiveItems.Count.ToString() != "0")
            {
                labelMaxItemsToDisplay.Invoke(new Action(() =>
                {
                    labelMaxItemsToDisplay.Text = m_Facade.TopFiveItems.Count.ToString();
                    labelSlash.Visible = true;
                    
                }));

            }
            else
            {
                richTextShowText.Invoke(new Action(() => noDataToDisplay()));
            }


        }

        private void showLoadingPicture()
        {
            pictureBoxForPhotos.Image = m_ImageLoading;
            pictureBoxForPhotos.Visible = true;
        }


        private void topFiveItemsRadioButtonIsChecked(int i_ForHowLong)
        {
            if (radioButtonFilterMyTopContent.Checked)
            {
                if (comboBoxPostOrPhoto.Text != "posts" && comboBoxPostOrPhoto.Text != "photos")
                {
                    MessageBox.Show("You have to select a filter");
                }
                else
                {
                    
                    whileDataIsLoading();
                    string comboBoxPostOrPhotoText = comboBoxPostOrPhoto.Text;
                    m_Request = new Thread(() =>
                    {
                        m_Facade.TopFiveItemsRequest(i_ForHowLong, comboBoxPostOrPhotoText);
                        m_Facade.CreateIterator(comboBoxPostOrPhotoText);
                        Action action = () =>
                        {
                            
                            showSlashAndNumberOfItems();
                            itemPresentation();
                            buttonShowTop5.Enabled = true;
                        };
                        this.BeginInvoke(action);
                    });
                    m_Request.Start();
                }
            }

        }

        




        private void topFiveFollowersRadioButtonIsChecked()
        {
            if (radioButtonShowMyFollowers.Checked)
            {
                m_Request = new Thread(() => m_Facade.TopFiveFollowersRequest(m_DateRange[comboBoxDateRange.Text]));
                whileDataIsLoading();
                m_Facade.CreateIterator(m_Facade.TopFiveFollowers);
                showTopFiveFollowers();
            }
        }

        private void whileDataIsLoading()
        {
            showLoadingPicture();
            buttonShowTop5.Enabled = false;
        }

        private void bringMeTopFive()
        {
            if (m_DateRange.ContainsKey(comboBoxDateRange.Text))
            {
                topFiveItemsRadioButtonIsChecked(m_DateRange[comboBoxDateRange.Text]);
                topFiveFollowersRadioButtonIsChecked();
            }

            else
                MessageBox.Show("First select date range");
        }

        private void buttonShowTop5_Click(object sender, EventArgs e)
        {
            richTextShowText.Text = "";
            m_Facade.clearData();
            bringMeTopFive();
        }

        private void showTopFiveFollowers()
        {
            buttonShowTop5.Enabled = true;
            if (m_Facade.TopFiveFollowers.Count != 0)
            {
                StringBuilder followersList = new StringBuilder(60);
                FollowerIterator.PartialFollower fan=null;

                while (m_Facade.FansIterator.MoveNext())
                {
                    fan = m_Facade.FansIterator.Current as FollowerIterator.PartialFollower;
                    followersList.AppendFormat(string.Format(@"{0} {1} likes
", fan.Name, fan.Likes));
                }

                richTextShowText.Invoke(new Action(() => richTextShowText.Text = followersList.ToString()));
            }

            else
                noDataToDisplay();
        }

        private void noDataToDisplay()
        {
            richTextShowText.Text = "Nothing to diplay";
            pictureBoxForPhotos.Visible = false;
        }



        private void showPhoto()
        {
            if (m_Facade.TopFiveItems.Count != 0)
            {
                PhotoIterator.PartialPhoto photo = m_Facade.ItemIterator.Current as PhotoIterator.PartialPhoto;
                if (photo != null)
                {
                    richTextShowText.Invoke(new Action(() => richTextShowText.Text = photo.Message));
                    pictureBoxForPhotos.Invoke(new Action(() =>
                    {
                        pictureBoxForPhotos.LoadAsync(photo.Picture);
                        pictureBoxForPhotos.Visible = true;
                    }));

                    updateNavigationMenu();
                }
            }
        }

        private void showPost()
        {
            if (m_Facade.TopFiveItems.Count != 0)
            {
                PostIterator.PartialPost post = m_Facade.ItemIterator.Current as PostIterator.PartialPost;
                
                if (post != null)
                {
                    richTextShowText.Invoke(new Action(() =>
                        richTextShowText.Text = string.Format(@"{0}
{1}
{2}", post.CreatedTime, post.Caption, post.Message)
                       ));
                    pictureBoxForPhotos.Invoke(new Action(() => pictureBoxForPhotos.Visible = false));

                    if (!string.IsNullOrEmpty(post.PictureURL))
                    {
                        pictureBoxForPhotos.Invoke(new Action(() =>
                        {
                            pictureBoxForPhotos.LoadAsync(post.PictureURL);
                            pictureBoxForPhotos.Visible = true;
                        }));

                    }
                    updateNavigationMenu();
                }

            }
        }

        private void updateNavigationMenu()
        {
            int currentItemNumber = m_Facade.ItemIterator.CurrentIndex;

            labelCurrentItemNumber.Invoke(new Action(() => labelCurrentItemNumber.Text = (currentItemNumber + 1).ToString()));
            pictureBoxRight.Visible = true;
            pictureBoxLeft.Visible = true;

            if (currentItemNumber + 1 == m_Facade.TopFiveItems.Count)
            {

                pictureBoxRight.Visible = false;
            }
            if (currentItemNumber == 0)
            {
                pictureBoxLeft.Visible = false;
            }
        }

        private void itemPresentation()
        {
            showPost();
            showPhoto();
        }



        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            if (m_Facade.ItemIterator.MoveBack())
                itemPresentation();

        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            if(m_Facade.ItemIterator.MoveNext())
             itemPresentation();
        }

        private void richTextShowText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int currentItemNumber = m_Facade.ItemIterator.CurrentIndex;

            if (comboBoxPostOrPhoto.Text == "posts")
            {
                ModifiedPost currentItem = m_Facade.TopFiveItems[currentItemNumber] as ModifiedPost;
                if (currentItem != null)
                {
                    currentItem.Message = richTextShowText.Lines[1];
                    currentItem.Caption = richTextShowText.Lines[2];
                }

            }
            else if (comboBoxPostOrPhoto.Text == "photos")
            {
                ModifiedPhoto currentItem = m_Facade.TopFiveItems[currentItemNumber] as ModifiedPhoto;
                if (currentItem != null)
                {
                    currentItem.Message = richTextShowText.Text;
                }

            }
        }

        private void buttonOrderVocation_Click(object sender, EventArgs e)
        {
            SpecialOffer();
        }

        private void radioButtonFilterMyTopContent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}