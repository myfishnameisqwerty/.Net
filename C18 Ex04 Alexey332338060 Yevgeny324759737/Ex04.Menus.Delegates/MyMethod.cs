using System;

namespace Ex04.Menus.Delegate
{
    
    public delegate void ActionEventHandler();

    public class MyMethod : MenuItem
    {

        public event ActionEventHandler m_SelectedActionListener;

        public MyMethod(string i_MethodMenuItemName, ActionEventHandler i_Method) : base(i_MethodMenuItemName)
        {
            m_SelectedActionListener += i_Method;
        }

        public void AddListener(ActionEventHandler i_ActionListener)
        {
            m_SelectedActionListener += i_ActionListener;
        }

       
        public override void OnGettingMethod()
        {
            
            if (m_SelectedActionListener != null)
            {
                m_SelectedActionListener.Invoke();
            }
            Console.WriteLine(Environment.NewLine + "Please press any key to continue ");
            Console.ReadLine();
        }
    }
}
