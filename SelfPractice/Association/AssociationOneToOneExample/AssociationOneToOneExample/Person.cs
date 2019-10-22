namespace AssociationOneToOneExample
{
    class Person
    {
        public Person(string firstName, string middleName, string lastName) 
            :this()
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person()
        {
        }

        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public Address PersonAddress { set; get; }


        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetReverseName()
        {
            return LastName + " " + MiddleName + " " + FirstName;
        }

    }
}
