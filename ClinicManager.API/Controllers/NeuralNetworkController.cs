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

        [HttpPost]
        public HeartPrediction GetProbability(HeartModel model)
        {
            return _neuralNetwork.GetPrediction(model);
        }
    }
}