using System;
using System.Net;

namespace AsterNET.ARI.Middleware
{
    public interface IRestCommandResult<T>
        where T : new()
    {
        string UniqueId { get; set; }
        HttpStatusCode StatusCode { get; set; }
        Exception ErrorException { get; set; }
        string ErrorMessage { get; set; }

        T Data { get; set; }
    }

    public interface IRestCommandResult
    {
        string UniqueId { get; set; }
        HttpStatusCode StatusCode { get; set; }
        Exception ErrorException { get; set; }
        string ErrorMessage { get; set; }
    }
}