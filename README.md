Unit Conversion API
Brief Description
Unit Conversion API is a RESTful ASP.NET Core Web API that allows users to convert numerical values between different units of measurement.
The application currently supports the following conversion categories:
- Length (Meter, Kilometer, Foot)
- Weight/Mass (Kilogram, Gram, Pound)
- Temperature (Celsius, Fahrenheit, Kelvin)

Prerequisites
- .NET 8 SDK (or latest stable .NET SDK)
- Visual Studio 2022 / Visual Studio Code

- - Git
Clone the Repository
git clone <repository-url>
cd UnitConversionApi
Restore Dependencies
dotnet restore
Build the Project
dotnet build
Run the Application
dotnet run
Access Swagger UI
Once the application starts, open:
https://localhost:5001/swagger

Request Body
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "foot",
  "value": 10
}
Sample Response
{
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "foot",
  "convertedValue": 32.8084
}
