using System.Net.Http.Json;

string url = "http://localhost:5084/weatherforecast/";

HttpClient httpClient = new();

string data = httpClient.GetAsync(url);