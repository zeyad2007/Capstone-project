namespace Capstone_project.Models // updated Capstone_project.Models
{
    public class MedicalHistory
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PastIllnesses { get; set; }
        public string FamilyHistory { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedications { get; set; }
    }
}