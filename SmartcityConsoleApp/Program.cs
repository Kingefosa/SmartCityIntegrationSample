


    // Create instances of weather data provider and traffic management system
    var weatherDataProvider = new WeatherDataProvider();
    var trafficManagementSystem = new TrafficManagementSystem();

    // Create integration modules
    var weatherIntegration = new WeatherIntegration(weatherDataProvider);
    var trafficIntegration = new TrafficIntegration(trafficManagementSystem);

    // Retrieve weather data for a specific location
    var weatherData = weatherIntegration.GetWeatherData("New York");

    // Display the retrieved weather information
    Console.WriteLine($"Weather in {weatherData.Location}:");
    Console.WriteLine($"Temperature: {weatherData.Temperature}°C");
    Console.WriteLine($"Humidity: {weatherData.Humidity}%");

    // Retrieve traffic data for a specific city
    var trafficData = trafficIntegration.GetTrafficData("Los Angeles");

    // Display the retrieved traffic information
    Console.WriteLine($"Traffic in {trafficData.City}:");
    foreach (var incidentData in trafficData.Incidents)
    {
        Console.WriteLine($"- {incidentData.Description} ({incidentData.StartTime} - {incidentData.EndTime})");
    }

    // Wait for user input to exit
    Console.ReadLine();
