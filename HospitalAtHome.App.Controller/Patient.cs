namespace HospitalAtHome.App.Controller
{
    public class Patient:Person
    {
        public string? Address { get; set; }
        public string? City { get; set; }
        public DateTime BirthDate { get; set;}
        public DesignatedFamilyMember? DesignatedFamilyMember { get; set; }
        public Medical? Medical { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }
        public VitalSign? VitalSign { get; set; }

    }
}