﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Website
    {
        public Website(string baseLink)
        {
            _client = new RestClient(baseLink);
        }
        public RestClient _client { get; private set; }
        public string Download(string path)
        {
            var request = new RestRequest(path);

            var response = _client.Execute(request);
            return response.Content;
        }

        public Task<IRestResponse> DownloadAsync(string path)
        {
            var request = new RestRequest(path);
            var response = _client.ExecuteAsync(request);
            return response;
        }
    }
}
