import React, { useState } from 'react';

function RecommendationForm() {
  const [feedback, setFeedback] = useState('');
  const [isReturning, setIsReturning] = useState(false);
  const [result, setResult] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    
    // Prepare the request payload
    const payload = {
      Model: "Hybrid", // or "Collaborative", for demo we use "Hybrid"
      Feedback: feedback,
      IsReturningCustomer: isReturning,
      TimeToFeedback: 3.0 // Example value in seconds
    };

    try {
      const response = await fetch('https://localhost:5001/api/Recommendation/get', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });
      const data = await response.text();
      setResult(data);
    } catch (error) {
      setResult("Error: " + error.message);
    }
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <label>
          Feedback:
          <input
            type="text"
            value={feedback}
            onChange={(e) => setFeedback(e.target.value)}
            placeholder="e.g., positive, negative"
          />
        </label>
        <br />
        <label>
          Returning Customer:
          <input
            type="checkbox"
            checked={isReturning}
            onChange={(e) => setIsReturning(e.target.checked)}
          />
        </label>
        <br />
        <button type="submit">Get Recommendation</button>
      </form>
      <div>
        <h3>Result:</h3>
        <p>{result}</p>
      </div>
    </div>
  );
}

export default RecommendationForm;