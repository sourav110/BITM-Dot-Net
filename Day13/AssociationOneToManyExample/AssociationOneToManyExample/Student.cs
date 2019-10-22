namespace AssociationOneToManyExample
{
    class Student

    {
        public string Name { set; get; }
        public string RegNo { set; get; }
        public string Email { set; get; }


        public Student()
        {
        }

        public Student(string name, string regNo, string email)
        {
            Name = name;
            RegNo = regNo;
            Email = email;
        }

    }
}
