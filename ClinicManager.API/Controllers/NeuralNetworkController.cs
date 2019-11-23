using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Astral.Extensions.HttpClient;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    [Route("/api/neural")]
    [ApiController]
    public class NeuralNetworkController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly INeuralNetwork _neuralNetwork;

        public NeuralNetworkController(DatabaseContext context, INeuralNetwork neuralNetwork)
        {
            _context = context;
            _neuralNetwork = neuralNetwork;
        }

        [HttpGet]
        public async Task<IEnumerable<HeartPrediction>> GetProbability()
        {
            return await _neuralNetwork.GetProbability();
        }

        public static HeartPrediction GetResultPrediction()
        {
            try
            {
                HttpClient httpClient = new HttpClient()
                {
                    BaseAddress = new Uri("https://localhost:44316"),
                    Timeout = TimeSpan.FromMinutes(10)
                };

                using (var response = httpClient.GetAsync("/GetPrediction").GetAwaiter().GetResult())
                {
                    var patient = response.ReadAs<HeartModel>().GetAwaiter().GetResult();
                    return new HeartPrediction(patient.Prediction, patient.Probability);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}