using System;
using System.Collections.Generic;
using System.Net;

namespace simple_movie_api_dotnet.Dmo
{
    public class ResponseDmo
    {
        public static Dictionary<string, dynamic> Success(object data, HttpStatusCode statusCode = HttpStatusCode.OK, string message = "Berhasil")
        {
            return new Dictionary<string, dynamic>() {
                { "code", statusCode},
                { "message", message ?? "Berhasil"},
                { "data", data}
            };
        }
    }
}
