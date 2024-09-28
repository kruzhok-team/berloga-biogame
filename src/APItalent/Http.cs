namespace APItalent;

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class Http
{
    private static readonly HttpClient HttpClient = new();
    private static readonly string? BaseUrl = Environment.GetEnvironmentVariable("BASE_ADRESS");

    public static async Task<T?> Post<T>(string path, object? data = null, Dictionary<string, string>? options = null, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        var requestBody = data != null ? new StringContent(JsonSerializer.Serialize(data),
            Encoding.UTF8,
            "application/json") : null;
        options ??= new Dictionary<string, string>();
        var response = await HttpClient.PostAsync($"{BaseUrl}/{path}?{GetOptionsString(options)}", requestBody);

        var jsonResponce = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == statusCode)
        {
            return JsonSerializer.Deserialize<T>(jsonResponce);
        }

        var err = JsonSerializer.Deserialize<HttpErrorResponse>(jsonResponce);
        throw new HttpError(statusCode, err);
    }

    public static async Task<T?> Get<T>(string path, Dictionary<string, string>? options = null, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        options ??= new Dictionary<string, string>();
        var response = await HttpClient.GetAsync($"{BaseUrl}/{path}?{GetOptionsString(options)}");

        var jsonResponce = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == statusCode)
        {
            return JsonSerializer.Deserialize<T>(jsonResponce);
        }

        var err = JsonSerializer.Deserialize<HttpErrorResponse>(jsonResponce);
        throw new HttpError(statusCode, err);
    }

    private static string GetOptionsString(Dictionary<string, string> options)
    {
        var sb = new StringBuilder();

        foreach (var key in options.Keys)
        {
            sb.Append($"{key}={options[key]}&");
        }

        return sb.ToString().TrimEnd('&');
    }
}

public class HttpError : Exception
{
    /// <summary>
    ///   Error description from server answer
    /// </summary>
    public string ErrorMessage { get; set; }
    public string? VerboseMessage { get; set; }
    /// <summary>
    ///   Error code
    /// </summary>
    public HttpStatusCode StatusCode { get; set; }

    /// <summary>
    /// <param name="statusCode">Http error code.</param>
    /// <param name="errorResponse">Error description from server answer.</param>
    /// </summary>
    /// <summary>
    /// Berloga API Error class.
    /// </summary>
    /// <returns>A <typeparamref name="HttpError"/> representation of the Berloga API error.</returns>
    /// <param name="statusCode">Http error code.</param>
    /// <param name="errorResponse">Error description from server answer.</param>
    public HttpError(HttpStatusCode statusCode, HttpErrorResponse? errorResponse)
        : base(errorResponse != null ?
            errorResponse.verbose_message != null
                ? errorResponse.verbose_message : errorResponse.error_message
            : "Не возможно десеализировать ответ")
    {
        StatusCode = statusCode;

        if (errorResponse != null)
        {
            ErrorMessage = errorResponse.error_message;
            VerboseMessage = errorResponse.verbose_message;
        }
        else
        {
            ErrorMessage = "Не возможно десеализировать ответ";
        }
    }
}

public class HttpErrorResponse
{
    public string error_message { get; set; }
    public string? verbose_message { get; set; } = null;
}
