using System;

namespace Crafter.Application.DTOS.ResponseDtos
{
    public class ResponseDto<T> where T : class
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string? ErrorCode { get; set; }
        public string? Message { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
    }
}


