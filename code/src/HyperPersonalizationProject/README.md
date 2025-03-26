# Hyper-Personalization Project

This project is a demo of a Generative AI-driven hyper-personalization system using a .NET 8 API backend and a React frontend. It uses JSON-based data to simulate an AI model for recommendations and includes basic implementations of hybrid filtering, A/B testing, and a reinforcement learning feedback loop.


## Folder Structure
HyperPersonalizationProject/
│
├── Backend/                   # .NET 8 API Project
│   ├── Controllers/
│   │   └── RecommendationController.cs
│   ├── Models/
│   │   └── FeedbackRequest.cs
│   ├── Services/
│   │   └── RecommendationService.cs
│   ├── Program.cs
│   └── appsettings.json
│
├── Frontend/                  # React Frontend Project
│   ├── public/
│   │   └── index.html         (if needed)
│   ├── src/
│   │   ├── components/
│   │   │   └── RecommendationForm.js
│   │   ├── App.js
│   │   └── index.js
│   └── package.json
│
├── AI_Model/                  # JSON-based AI model data
│   ├── recommendations.json
│   └── feedback.json          (optional, for simulated feedback data)
│
└── README.md                  # Setup and usage instructions

## How to Run the Project

### Backend (.NET 8 API)
1. Navigate to the Backend folder.
2. Run the following commands:
   ```bash
   dotnet restore
   dotnet run
3.	The API will be available at: https://localhost:5001 (or http://localhost:5000 depending on your configuration).

Frontend (React)
	1.	Navigate to the Frontend folder.
	2.	Install dependencies and start the application:
        npm install
        npm start
    3.Open http://localhost:3000 in your browser.

Testing the System
	•	Use the form on the frontend to submit feedback.
	•	The backend will process the request and return a recommendation based on the provided input.

Notes
	•	This project uses JSON files in the AI_Model folder to simulate AI model data.
	•	No database or Docker support is included. Everything runs locally.
