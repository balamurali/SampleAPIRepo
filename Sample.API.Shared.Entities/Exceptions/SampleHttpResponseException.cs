using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.API.Shared.Exceptions
{
    class SampleHttpResponseException : Exception
    {
        public System.Net.HttpStatusCode StatusCode { get; private set; }

        public SampleHttpResponseException(System.Net.HttpStatusCode statusCode, string content) : base(content)
        {
            StatusCode = statusCode;
        }
    }
}
