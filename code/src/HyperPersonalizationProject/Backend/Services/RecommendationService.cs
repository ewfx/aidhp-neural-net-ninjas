using HyperPersonalizationProject.Models;
using System.IO;
using System.Text.Json;

namespace HyperPersonalizationProject.Services
{
    public class RecommendationService
    {
        // This method simulates AI-driven recommendation based on the feedback request.
        // In a real scenario, this could call a ML model, but here we use JSON data.
        public string GetRecommendation(FeedbackRequest request)
        {
            // For simplicity, read from a JSON file in the AI_Model folder
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "AI_Model", "recommendations.json");
            if (!File.Exists(jsonFilePath))
            {
                return "No recommendations available";
            }

            var jsonData = File.ReadAllText(jsonFilePath);
            // Here, you could parse the JSON and decide based on the request.
            // We'll simulate by simply returning a string.
            return $"Recommendation based on feedback '{request.Feedback}' for a {(request.IsReturningCustomer ? "returning" : "new")} customer.";
        }
    }
}