using System;

namespace Crafter.API.Dto.Response
{
   public static class ErrorCodes
    {
        public const string NotFound = "NotFound";
        public const string Unauthorized = "UNAUTHORIZED";
        public const string Exception = "EXCEPTION";
        public const string ValidationError = "VALIDATION_ERROR";
        public const string DuplicateEror = "DUPLICATE_ERROR";
        public const string Forbidden = "FORBIDDEN";//yetkili ama eriþim yok
        public const string BadRequest = "BAD_REQUEST";
    }
}
