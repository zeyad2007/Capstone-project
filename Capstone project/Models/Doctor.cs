namespace Capstone_project.Models // updated Capstone_project.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string ClinicLocation { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}