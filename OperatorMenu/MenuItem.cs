namespace OperatorMenu
{
    public class MenuItem
    {
        public string Name;

        public MenuItem(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}