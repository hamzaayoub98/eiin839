using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    class Mymethods
    {
        //HttpListenerRequest request;
        public Mymethods()
        {
            
        }
        public string parseURL(HttpListenerRequest request)
        {
            return ("<HTML><BODY> Hello " + HttpUtility.ParseQueryString(request.Url.Query).Get("name") + " et " +HttpUtility.ParseQueryString(request.Url.Query).Get("course") + "</BODY></HTML>");
        }

        public string callExe()
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\33774\Documents\Soc\TD2\callExe\bin\Debug\netcoreapp3.1\callExe.exe"; // Specify exe name.
            start.Arguments = "Hamza Ayoub"; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    return result;
                }
            }
           
        }
        
    }
}
