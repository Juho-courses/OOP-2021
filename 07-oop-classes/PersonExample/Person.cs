namespace PersonExample
{
    /*
    - first name
    - last name
    - is the person studying
    - full name (first name + last name)
    (- address)
    */
    class Person
    {
        public string lastName = "UnknownLastName";
        private string firstName = "UnknownFirstName";

        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get { return firstName; }
        }

        public bool IsStudying { set; get; }

        public string FullName => FirstName + " " + lastName;

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public Person() { }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstname)
        {
            this.firstName = firstname;
        }
    }
}