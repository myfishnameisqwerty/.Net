using System;
using FacebookResources = A19_Ex03_Alexey_332338060_Yevgeny_324759737.Properties.Resources;
using System.Drawing;
using System.Windows.Forms;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public partial class LoginPage : Form
    {
        private Image m_FacebookImageLoginButton = FacebookResources.facebook_login;
        private Operator m_LoginOperator;



        public LoginPage()
        {
            InitializeComponent();
            InitializeAdditionalProperties();
        }

        private void Form1_Load(object sender, EventArgs e) { }


        private void InitializeAdditionalProperties()
        {
            pictureFacebookLogin.Image = m_FacebookImageLoginButton;
            StartPosition = FormStartPosition.Manual;
            m_LoginOperator = Operator.GetInstance();
            ShowDialog();
        }




        private void pictureBoxFacebookLogin_Click(object sender, EventArgs e)
        {
            m_LoginOperator.SignIn();

            if (checkBoxRememberMe.Checked == true)
            {
                m_LoginOperator.SaveLoginData();
            }

            this.Hide();

            m_LoginOperator.RunProgramMenu();

        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        /* private void fetchPages()
         {
             listBoxPages.Items.Clear();
             listBoxPages.DisplayMember = "Name";
             foreach (Page page in m_LoggedInUser.LikedPages)
             {
                 listBoxPages.Items.Add(page);
                 //each page has LikeCount property
             }
             if (m_LoggedInUser.LikedPages.Count == 0)
             {
                 MessageBox.Show("No liked pages to retrieve :(");
             }
         }*/

    }




}

