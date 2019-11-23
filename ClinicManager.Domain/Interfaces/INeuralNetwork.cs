using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;

namespace ClinicManager.Domain.Interfaces
{
    public interface INeuralNetwork
    {
        HeartPrediction GetPrediction(HeartModel heartModel);
    }
}