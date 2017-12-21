using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://msdn.microsoft.com/en-us/library/6196h3wt(v=vs.110).aspx
 * @see https://msdn.microsoft.com/en-us/library/system.web.httputility.urldecode(v=vs.110).aspx
 * @see https://msdn.microsoft.com/en-us/library/4fkewx0t(v=vs.110).aspx
 * @todo Solution not found to url encoder decoder
 */
namespace classes
{
    public class url : encoder
    {
        public string encode(string text)
        {
            string url = ""; //  HttpUtility.UrlEncode(text);
            return url;
        }

        public string decode(string text)
        {
            // HttpContext.Current.Request.QueryString["url"]
            // return HttpContent.Current.Server.UrlDecode(url);
            string url = "";
            return url;
        }
    }
}
