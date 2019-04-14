namespace Ex04.Menus.Delegate
{
    public abstract class MenuItem
    {
        private string m_ItemName;

        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
        }

        public string Name
        {
            get { return m_ItemName; }
        }

        public abstract void OnGettingMethod();
    }
}
