using System.ComponentModel.DataAnnotations;

namespace ClinicManager.Database.Models
{
    public class HeartModel
    {
        [Key]
        public float Age { get; set; }
        public float Sex { get; set; }
        public float Cp { get; set; }
        public float TrestBps { get; set; }
        public float Chol { get; set; }
        public float Fbc { get; set; }
        public float RestEcg { get; set; }
        public float Thalac { get; set; }
        public float Exang { get; set; }
        public float OldPeak { get; set; }
        public float Slope { get; set; }
        public float Ca { get; set; }
        public float Thal { get; set; }
        public bool Label { get; set; }
        public bool Prediction { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}