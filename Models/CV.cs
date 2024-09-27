namespace Bincom_CV.Models
{
    public class CV
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }
        
    
        public List<Education> EducationHistory { get; set; }
    }
    

   
}
