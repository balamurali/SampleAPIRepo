using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.API.Shared.Extentions
{
    public static class HttpResponseMessageExtensions
    {
        public static void EnsureStatusCode_Sample(this System.Net.Http.HttpResponseMessage message, string content = null)
        {
            if (message.IsSuccessStatusCode)
                return;

            var contentMessage = string.IsNullOrWhiteSpace(content) ? string.Empty : $"Content: {content}";
            throw new System.Net.Http.HttpRequestException(string.Format(
                System.Globalization.CultureInfo.InvariantCulture,
                "Response status code does not indicate success: {0} ({1}).{2}",
                (int)message.StatusCode,
                message.ReasonPhrase,
                contentMessage)
                );
        }
    }
}
