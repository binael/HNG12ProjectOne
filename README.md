# Number Classification API

## Overview
The **Number Classification API** is a simple ASP.NET Core Web API that takes a number as input and returns various mathematical properties about it, including whether it is prime, perfect, or an Armstrong number. Additionally, it fetches a fun fact about the number from **numbersapi.com**.

## Features
- Check if a number is **prime**.
- Check if a number is **perfect**.
- Identify if a number is an **Armstrong number**.
- Determine if a number is **odd or even**.
- Compute the **sum of its digits**.
- Fetch a **fun fact** about the number from an external API.

## Technologies Used
- **C#**
- **ASP.NET Core**
- **HttpClient** (for fetching external data)

## Endpoints
### 1. Classify a Number
**Endpoint:** `GET /api/classify-number`

**Query Parameter:**
- `number` (string) - The number to be classified.

**Example Requests & Responses:**

### ✅ Valid Request (Number: 33)
**Request:**
```sh
curl -X 'GET' \  
  'https://localhost:7154/api/classify-number?number=33' \  
  -H 'accept: */*'
```

**Response:**
```json
{
  "number": 33,
  "is_prime": false,
  "is_perfect": false,
  "properties": [
    "odd"
  ],
  "digit_sum": 6,
  "fun_fact": "33 is the largest number that is not a sum of distinct triangular numbers."
}
```

### ❌ Invalid Request (Alphabetic Input)
**Request:**
```sh
curl -X 'GET' \  
  'https://localhost:7154/api/classify-number?number=A' \  
  -H 'accept: */*'
```

**Response:**
```json
{
  "number": "alphabet",
  "error": true
}
```

## Project Structure
```
HNG12StageOne/
│── Controllers/
│   ├── StageOneController.cs  # API Controller
│
├── UtilFunctions.cs           # Helper functions for number classification
│
├── Program.cs                 # Main application entry point
└── Startup.cs                 # Application configuration
```

## Setup and Running Locally
### Prerequisites
- .NET 6.0 or later installed

### Steps to Run
1. Clone the repository:
   ```sh
   git clone <repo-url>
   ```
2. Navigate to the project directory:
   ```sh
   cd HNG12StageOne
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Run the API:
   ```sh
   dotnet run
   ```
5. The API will be available at `https://localhost:7154/api/classify-number`.

## License
This project is open-source and available under the **Odogwu Licence**.

---

Enjoy using the Number Classification API! 🚀

