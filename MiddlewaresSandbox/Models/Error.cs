using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Models
{
    public class Error
    {
        public Guid RequestGuid { get; }

        public string Url { get; }

        public string Method { get; }

        public string Body { get; }

        public DateTime CreatedAt { get; }
        public string Description { get; }
        public string StackTrace { get; }

        public Error(Guid requestGuid, string url, string method, string body, DateTime createdAt, string description, string stackTrace)
        {
            RequestGuid = requestGuid;
            Url = url;
            Method = method;
            Body = body;
            CreatedAt = createdAt;
            Description = description;
            StackTrace = stackTrace;
        }
    }
}
