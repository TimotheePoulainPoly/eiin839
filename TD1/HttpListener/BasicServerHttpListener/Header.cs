using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Header
    {
        public void showHeader(System.Net.HttpListenerRequest request)
        {
            foreach (var key in request.Headers.AllKeys)
            {
                Console.WriteLine("Header : " + key);
            }
        }
    }
}
