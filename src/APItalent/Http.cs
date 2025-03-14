namespace APItalent;

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class Http
{
    private static readonly AuthTokenHandler AuthToken = AuthTokenHandler.Instance;
    private static readonly HttpClient HttpClient = new();
    private static readonly string? BaseUrl = Environment.GetEnvironmentVariable("BASE_ADRESS");

    /// <summary>
    /// Method for Http Post requests
    /// </summary>
    /// <returns>Returns an object of type <typeparamref name="T"/></returns>
    /// <param name="path">Full request path, without domain</param>
    /// <param name="data">Data for the request body</param>
    /// <param name="options">Get request parameters</param>
    /// <param name="authRequire">Do I need authorization?</param>
    /// <param name="statusCode">Http error code.</param>
    /// <exception cref="HttpError">
    /// Berloga API error sent by the server
    /// </exception>
    public static async Task<T?> Post<T>(string path, object? data = null, Dictionary<string, string>? options = null, bool authRequire = false, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        var requestBody = data != null ? new StringContent(JsonSerializer.Serialize(data),
            Encoding.UTF8,
            "application/json") : null;
        options ??= new Dictionary<string, string>();
        var request = new HttpRequestMessage(HttpMethod.Post, $"{BaseUrl}/{path}?{GetOptionsString(options)}");

        if (authRequire)
            request.Headers.Add("Authorization", AuthToken.AuthToken);

        request.Content = requestBody;

        var response = await HttpClient.SendAsync(request);

        var jsonResponse = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == statusCode)
        {
            if(String.IsNullOrEmpty(jsonResponse)){
                return default(T);
            }
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }

        var err = JsonSerializer.Deserialize<HttpErrorResponse>(jsonResponse);
        throw new HttpError(statusCode, err);
    }
    /// <summary>
    /// Method for Http Get requests
    /// </summary>
    /// <returns>Returns an object of type <typeparamref name="T"/></returns>
    /// <param name="path">Full request path, without domain</param>
    /// <param name="options">Get request parameters</param>
    /// <param name="authRequire">Do I need authorization?</param>
    /// <param name="statusCode">Http error code.</param>
    /// <exception cref="HttpError">
    /// Berloga API error sent by the server
    /// </exception>
    public static async Task<T?> Get<T>(string path, Dictionary<string, string>? options = null, bool authRequire = false, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        options ??= new Dictionary<string, string>();
        var request = new HttpRequestMessage(HttpMethod.Get, $"{BaseUrl}/{path}?{GetOptionsString(options)}");

        if (authRequire)
            request.Headers.Add("Authorization", AuthToken.AuthToken);

        var response = await HttpClient.SendAsync(request);

        var jsonResponse = await response.Content.ReadAsStringAsync();

        if (response.StatusCode == statusCode)
        {
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }

        var err = JsonSerializer.Deserialize<HttpErrorResponse>(jsonResponse);
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
