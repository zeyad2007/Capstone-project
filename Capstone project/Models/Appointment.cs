namespace Capstone_project.Models // updated Capstone_project.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string AppointmentDay { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string VisitType { get; set; }
        public string ServiceType { get; set; }
    }
}