namespace Bincom_CV.Models
{
    public class CV
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }
        public List<string> Skills { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Education> EducationHistory { get; set; }
    }
    public class WorkExperience
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Duration { get; set; }
        public string Responsibilities { get; set; }
    }

    public class Education
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string Duration { get; set; }
    }
}
