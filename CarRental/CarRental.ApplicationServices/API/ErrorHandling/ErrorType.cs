﻿namespace CarRental.ApplicationServices.API.ErrorHandling
{
    public static class ErrorType
    {
        public const string InternalServerError = "INTERNAL_SERVER_ERROR";
        public const string ValidationError = "VALIDATION_ERROR";
        public const string NotAuthenticated = "NOT_AUTHENTICED";
        public const string Unauthorized = "UNAUTHORIZED";
        public const string NotFound = "NOT_FOUND";
        public const string UnsupportedMediaType = "UNSUPPOERTED_MEDIA_TYPE";
        public const string UnsupportedMethod = "UNSUPPOERTED_METHOD";
        public const string RequestTooLarge = "REQUEST_TOO_LARGE";
        public const string TooManyRequests = "TOO_MANY_REQUESTS";
    }
}
