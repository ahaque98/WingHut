using System.Net;

namespace Server.Models.Response
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            ErrorMessage = new List<string>();
        }

        public HttpStatusCode StatusCode { get; set; }
        public bool isSuccess { get; set; } = true;
        public List<string> ErrorMessage { get; set; }
        public object Result { get; set; }
    }
}
