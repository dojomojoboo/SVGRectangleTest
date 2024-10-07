# SVG Rectangle Resizer

This project is a React-based web application that allows users to create, resize, and validate a rectangle SVG figure. The initial dimensions are read from a JSON file, and user interactions lead to updates in the backend, including the validation of the rectangle's dimensions.

## Project Structure

The project is divided into two main parts:

1. **Frontend** - React application running at [http://localhost:3000](http://localhost:3000).
2. **Backend** - C# API service running at [http://localhost:5142](http://localhost:5142).

## Technologies Used

- **Frontend**: React, HTML, CSS
- **Backend**: C#, ASP.NET Core Web API
- **Data Format**: JSON

## Features

- Displays a resizable rectangle based on dimensions from a JSON file.
- Dynamically updates and displays the perimeter of the rectangle.
- Resizing action updates the JSON data and sends it to the backend for validation.
- Implements delayed validation (10 seconds) to simulate long computation.
- Validates that the rectangle width does not exceed its height, with appropriate error handling.

## Getting Started

### Prerequisites

- Node.js (v14 or higher)
- npm (Node Package Manager)
- .NET SDK (v5.0 or higher)

### Installation

1. **Run the Frontend: Start the React application:**:
   ```bash
   npm start

2. **Install Backend Dependencies: Navigate to the SvgRectangleApi folder and run:**:
   ```bash
   cd SvgRectangleApi
   dotnet restore

3. **Run the Backend: Start the API service:**:
   ```bash
   dotnet run

## API Endpoints

- GET /api/rectangle: Fetch initial rectangle dimensions in JSON format.
- POST /api/rectangle: Update rectangle dimensions and validate.

## Usage
1. Open your web browser and visit http://localhost:3000.
2. Adjust the rectangle size by clicking and dragging the corners of the SVG figure.
3. The perimeter will update in real-time.
4. Upon resizing, the updated dimensions will be sent to the backend for validation. (http://localhost:5142/api/rectangle)

## Error Handling
If the width exceeds the height upon submission, the UI will present an error message indicating the validation failure.
