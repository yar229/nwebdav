﻿using System;
using System.Net;
using NWebDav.Server.Http;

namespace NWebDav.Server.Platform.DotNet45
{
    public partial class HttpListenerAdapter
    {
        private class HttpContext : IHttpContext
        {
            private readonly HttpListenerContext _httpListenerContext;

            public HttpContext(HttpListenerContext httpListenerContext)
            {
                _httpListenerContext = httpListenerContext;

                Request = new HttpRequest(_httpListenerContext.Request);
                Response = new HttpResponse(_httpListenerContext.Response);
                Session = new HttpSession(_httpListenerContext.User);
            }

            public IHttpRequest Request { get; }
            public IHttpResponse Response { get; }
            public IHttpSession Session { get; }

            public void Close()
            {
                // Save status-code and description
                _httpListenerContext.Response.StatusCode = Response.Status;
                if (!string.IsNullOrEmpty(Response.StatusDescription))
                    _httpListenerContext.Response.StatusDescription = Response.StatusDescription;

                // Close the response
                _httpListenerContext.Response.Close();
            }
        }
    }
}