using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSocket_WebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new JobHost();
            Console.Error.Write("An error occurred in this web job");

            host.RunAndBlock();

        }
    }
}
