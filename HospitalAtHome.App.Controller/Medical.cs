namespace HospitalAtHome.App.Controller
{
    public class Medical: Person
    {
        public int? Code { get; set; }
        public string? Specialty { get; set; }
        public string? Registration { get; set;}
    }
}