using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ContactWebAPI();

            var contacts = client.Contacts.Get();

            foreach (var c in contacts)
            {
                Console.WriteLine("{0}: {1} {2}",
                    c.Id, c.Name, c.EmailAddress);
            }
            Console.ReadKey();


        }
    }
}
