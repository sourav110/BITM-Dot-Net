namespace AssociationOneToOneExample
{
    class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string middleName, string lastName) : this()
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        

        public Address PersonAddress { set; get; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string ReverseFullName()
        {
            return LastName + " " + MiddleName + " " + FirstName;
        }
    }
}
