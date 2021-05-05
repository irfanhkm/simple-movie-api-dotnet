using System;
using System.Collections.Generic;

namespace simple_movie_api_dotnet.Dmo
{
    public class ResponseDmo
    {
        public static Dictionary<string, dynamic> Success(object data, int statusCode = 200, string message = "Berhasil")
        {
            return new Dictionary<string, dynamic>() {
                { "code", statusCode},
                { "message", message ?? "Berhasil"},
                { "data", data ?? Array.Empty<string>()}
            };
        }
    }
}
