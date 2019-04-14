
using System.Windows.Forms;
using System;
using System.Linq;
using System.Globalization;
using System.Reflection;

using System.Drawing;
using System.Collections.Generic;
using System.IO;
using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
    public partial class DealDetails : UserControl
    {

        Ticket m_TravelTicket;
        List<string> m_AdditionalFields;
        Panel m_JourneyPanel;
        string m_DescriptionValue;
        Operator m_Operator;

        public Journey RequestedJourney {get; private set;}
        public float DealPrice { get; private set; }

        public DealDetails()
        {
            InitializeComponent();
            addRadioButtons();
            fillCountiesComboboxes();
            m_Operator = Operator.GetInstance();
            //ShowDialog();
        }

        private void addRadioButtons()
        {
            int buttonXStartPosition = 0;
            int buttonYStartPosition = 0;


            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
                 .Where(mytype => mytype.IsSubclassOf(typeof(TourOperator))))
            {
                TourOperator instance = (TourOperator)Activator.CreateInstance(mytype);
                RadioButton radioButton = new RadioButton();
                radioButton.Location = new Point(buttonXStartPosition, buttonYStartPosition);
                radioButton.Text = instance.GetDescription();
                buttonYStartPosition += 20;

                panelRadioButtons.Controls.Add(radioButton);
                radioButton.CheckedChanged += radioButton_CheckedChanged;

            }
        }

        private void fillCountiesComboboxes()
        {
            string destinationCountries = @"Resources\DestinationCountries.txt";
            string originsCountries = @"Resources\OriginsCountries.txt";

            fillComboboxFromTxtFile(ComboboxOrigin, originsCountries);
            fillComboboxFromTxtFile(ComboboxDestination, destinationCountries);
        }

        private void fillComboboxFromTxtFile(ComboBox i_ComboBox, string i_TxtFilePath)
        {
            string[] linesOfFile = File.ReadAllLines(LastAppSession.LoadFilePath(i_TxtFilePath));
            
            foreach (var line in linesOfFile)
            {
                i_ComboBox.Items.Add(line);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
           if(!applyButton.Visible)
             applyButton.Visible = true;
        }


        private void loadJourneyPanel (RadioButton i_CheckedButton)
        {
            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
                  .Where(mytype => Attribute.IsDefined(mytype, typeof(DealDetailsExtensionAttribute))))
            {
                UserControl instance = (UserControl)Activator.CreateInstance(mytype);
                MethodInfo method= mytype.GetMethod("GetDescription");
                m_DescriptionValue = (string)method.Invoke(instance, null);
                Panel instancePanel = (Panel)mytype.GetProperty("CustomizedPanel").GetValue(instance);

                if (i_CheckedButton.Text == m_DescriptionValue)
                {
                    
                    panelRadioButtons.Visible = false;
                    m_JourneyPanel = instancePanel;
                    instancePanel.Location = panelRadioButtons.Location;
                    Controls.Add(instancePanel);
                    break;
                }
            }
        }




        private void OKbutton_Click(object sender, EventArgs e)
        {
            buildTicket();
            loadAdditionalFields();
            RequestedJourney = factoryRecognition().OrderTrip(m_TravelTicket, m_AdditionalFields);
            DealPrice = RequestedJourney.Cost() * (1 - Operator.GetInstance().BirthdayDiscount);
        }


        private void buildTicket()
        {
            m_TravelTicket = new Ticket();
            m_TravelTicket.ArrivalDate = DateTime.ParseExact(arrivalDateTextBox.Text, "dd/MM/yyyy", null);
            m_TravelTicket.DepartureDate= DateTime.ParseExact(departureDateTextBox.Text, "dd/MM/yyyy", null);
            m_TravelTicket.Origin = ComboboxOrigin.Text;
            m_TravelTicket.Destination = ComboboxDestination.Text;
            m_TravelTicket.FirstName = m_Operator.LoggedUser.FirstName;
            m_TravelTicket.LastName= m_Operator.LoggedUser.LastName;
            m_TravelTicket.Birthday = DateTime.ParseExact(m_Operator.LoggedUser.Birthday, "dd/MM/yyyy", null);

        }
                                                          
        private void loadAdditionalFields()
        {
            m_AdditionalFields = new List<string>();
            

            foreach (Control control in m_JourneyPanel.Controls)
            {
                dataRetrieval(control);
            }
        }


        private void dataRetrieval(Control i_Control) 
        {
            if (i_Control is ComboBox || i_Control is TextBox)
                m_AdditionalFields.Add(i_Control.Text);

            else if (i_Control.GetType()== typeof(NumericUpDown))
                m_AdditionalFields.Add((i_Control as NumericUpDown).Value.ToString());

            else if (i_Control.GetType()==typeof(CheckBox))
                m_AdditionalFields.Add((i_Control as CheckBox).Checked.ToString());
        }




        private TourOperator factoryRecognition()
        {
            TourOperator instance=null;

            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
               .Where(mytype => mytype.IsSubclassOf(typeof(TourOperator))))
            {
                 instance = (TourOperator)Activator.CreateInstance(mytype);
                 string propertyValue= instance.GetDescription();
                if (m_DescriptionValue == propertyValue)
                    break;
            }

            return instance;
        }






        private void choiceRecognition()
        {
            
            RadioButton checkedButton= panelRadioButtons.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            
                    Controls.Remove(applyButton);
                    loadJourneyPanel(checkedButton);
            }


        private void applyButton_Click(object sender, EventArgs e)
        {
            
           
            choiceRecognition();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void fillComboBoxListOFFriends()
        {
            List<string> friendsList=new List<string>();

            m_Operator.GetListOfFriends(friendsList);
            fillComboBoxWithStrings(comboBoxFriendsList, friendsList);
        }


        private void fillComboBoxWithStrings(ComboBox i_Combo,List<string> i_List)
        {
            foreach(string item in i_List)
            {
                i_Combo.Items.Add(item);
            }
        }

        private void sendJourneyInvitation(Journey i_CoolTrip)
        {
            
        }




        private void checkBoxInviteFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInviteFriend.Checked)
            {
                comboBoxFriendsList.Visible = true;
            }
            else
            {
                comboBoxFriendsList.Visible = false;
            }
        }


    }
}
