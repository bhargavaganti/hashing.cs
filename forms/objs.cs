using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
// https://github.com/dotnet/docs/tree/master/samples/csharp/getting-started/console-webapiclient
// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
// https://github.com/DalSoft/DalSoft.RestClient

// http://restsharp.org/
// https://github.com/restsharp/RestSharp/
// http://www.technetexperts.com/web/basics-of-restsharp-in-dot-net/

namespace forms
{
    public class objs
    {
        internal string data()
        {
            string gateway = "http://192.168.0.100/angular/libraries/apiunit.phpunit/src/api.tests";

            RestRequest request = new RestRequest("/algorithms.php?{id}", Method.POST);
            request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            RestClient client = new RestClient(gateway);
            IRestResponse response = client.Execute(request);
            string content = response.Content; // raw content as string
            File.AppendAllText("D:\\a.log", content);
            return content;
        }

        internal string people()
        {
            string gateway = "http://192.168.0.100/angular/libraries/apiunit.phpunit/src/api.tests";

            RestRequest request = new RestRequest("/strict.php?order={order}", Method.POST);
            request.AddParameter("measure", "yes"); // adds to POST or URL querystring based on Method
            request.AddUrlSegment("order", "height"); // replaces matching token in request.Resource
            request.AddHeader("X-Protection-Code", "000-000-0000"); // dash-ed

            RestClient client = new RestClient(gateway);
            IRestResponse response = client.Execute(request);
            string content = response.Content; // raw content as string
            File.AppendAllText("D:\\a.log", content);
            return content;
        }
    }
}
