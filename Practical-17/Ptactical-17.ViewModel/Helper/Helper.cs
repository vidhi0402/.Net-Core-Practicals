using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ptactical_17.ViewModel.Helper
{
    public class StudentAPI
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:47843");
            return Client;
        }
    }
}
