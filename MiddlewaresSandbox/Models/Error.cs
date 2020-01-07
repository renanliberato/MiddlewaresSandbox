using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewaresSandbox.Models
{
    public class Error
    {
        public Guid RequestGuid { get; set; }

        public string Url { get; set; }

        public string Method { get; set; }

        public string Body { get; set; }

        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string StackTrace { get; set; }

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

        public Error()
        {
        }
    }
}
