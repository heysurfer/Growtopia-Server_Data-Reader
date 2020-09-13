using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Console.WriteLine("Title: {0}", Console.Title);
            Console.Title = "Server Data Reader";
            string a;
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("http://growtopia2.com/growtopia/server_data.php");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String text = reader.ReadToEnd();

                a = text;

            }
            String texts = a;

            texts = a;
            texts = texts.Replace("server|", "");
            texts = texts.Replace("port|", "");


            string ip;
            string port;

            string ayir = texts;
            string[] bosluk;
            bosluk = ayir.Split();
            ip = bosluk[0];
            port = bosluk[2];
            Console.WriteLine("Ip : " + ip);
            Console.WriteLine("Port : " + port);
            Console.WriteLine("Server Data Reader By HeySurfer");

            Console.ReadKey();

        }
    }
}
