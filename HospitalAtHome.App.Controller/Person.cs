namespace HospitalAtHome.App.Controller
{
    public class Person
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
    }
}
