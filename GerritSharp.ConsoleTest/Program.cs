using GerritSharp.Clients;
using GerritSharp.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerritSharp.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ChangesClient("https://review.openstack.org");
            var changes = client.GetChanges().Result;
            foreach (ChangeInfo change in changes)
            {
                Console.WriteLine(change.Subject);
            }

        }
    }
}
