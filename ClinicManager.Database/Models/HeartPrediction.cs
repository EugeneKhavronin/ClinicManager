namespace ClinicManager.Database.Models
{
    public class HeartPrediction
    {
        /// <summary>
        /// Прогнозирование
        /// </summary>
        public bool Prediction;
        
        /// <summary>
        /// Вероятность
        /// </summary>
        public float Probability;
        
        /// <summary>
        /// Счет
        /// </summary>
        public float Score;

        public HeartPrediction()
        {
        }

        public HeartPrediction(bool patientPrediction, float patientProbability)
        {
        }
    }
}