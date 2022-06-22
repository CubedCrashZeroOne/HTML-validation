namespace HtmlFiles
{
    internal struct Person
    {
        private readonly string _name;
        private readonly string _email;

        public string Name
        {
            get { return _name; }
        }

        public string Email
        {
            get { return _email; }
        }

        public Person(string name, string email)
        {
            _name = name;
            _email = email;
        }
    }
}