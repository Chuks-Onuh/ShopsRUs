using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopsRUs.API.DTOs
{
    public class ApiResponse
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }
        public PaginationDto PaginationInfo { get; set; }

        public ApiResponse(string message = null)
        {
            Succeeded = true;
            Message = message;
        }

        public static ApiResponse Success(object data, PaginationDto pagination)
        {
            return new ApiResponse { Succeeded = true, Message = "Success", Data = data, PaginationInfo = pagination };
        }

        public static ApiResponse Failure(string message = "Failure", List<string> errors = null)
        {
            return new ApiResponse { Message = message, Errors = errors };
        }
    }
}

