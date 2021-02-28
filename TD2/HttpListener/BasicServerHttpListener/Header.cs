using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Header
    {
        NameValueCollection headers;
        public Header(NameValueCollection headersCollection)
        {
            this.headers = headersCollection;
        }
        public void printHeader(NameValueCollection headers)
        {
            // Displays all the headers present in the response received from the URI.
            Console.WriteLine("\r\nThe following headers were received in the response:");
            // Displays each header and it’s key associated with the response.
            for (int i = 0; i < headers.Count; ++i)
                Console.WriteLine("\nHeader Name:{ 0}, Value: { 1}",headers.GetKey(i),headers.Get(i));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(headers.ToString());
            return sb.ToString();
        }
    }
}
