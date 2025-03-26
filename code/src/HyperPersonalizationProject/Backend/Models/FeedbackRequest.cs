namespace HyperPersonalizationProject.Models
{
    public class FeedbackRequest
    {
        public string Model { get; set; }            // e.g., "Hybrid" or "Collaborative"
        public string Feedback { get; set; }         // e.g., "positive" or "negative"
        public bool IsReturningCustomer { get; set; }
        public double TimeToFeedback { get; set; }     // in seconds
    }
}