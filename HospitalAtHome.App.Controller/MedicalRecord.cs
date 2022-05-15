namespace HospitalAtHome.App.Controller
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string? Diagnosis { get; set;}
        public string? Around { get; set;}
        public Suggestion? Suggestion { get; set; }
    }
}