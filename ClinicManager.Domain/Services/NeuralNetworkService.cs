using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ClinicManager.Domain.Services
{
    public class NeuralNetworkService : INeuralNetwork
    {
        private readonly DatabaseContext _context;

        public NeuralNetworkService(DatabaseContext context)
        {
            _context = context;
        }

        public HeartPrediction GetPrediction(HeartModel heartModel)
        {
            var client = new RestClient($"https://localhost:44316/GetPrediction/");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(heartModel);

            var response = client.Execute(request);

            var obj = JsonConvert.DeserializeObject<HeartPrediction>(response.Content);
            
            return obj;
        }
    }
}