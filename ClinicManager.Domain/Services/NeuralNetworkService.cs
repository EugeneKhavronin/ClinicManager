using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Domain.Services
{
    public class NeuralNetworkService : INeuralNetwork
    {
        private readonly DatabaseContext _context;

        public NeuralNetworkService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HeartPrediction>> GetProbability()
        {
            var result = await _context.HeartModels.ToListAsync();
            List<HeartPrediction> results = new List<HeartPrediction>();
            foreach (var heart in result)
            {
                var heartModel = new HeartPrediction
                {
                    Prediction = heart.Prediction,
                    Probability = heart.Probability,
                };
                results.Add(heartModel);
            }
            return results;
        }
    }
}