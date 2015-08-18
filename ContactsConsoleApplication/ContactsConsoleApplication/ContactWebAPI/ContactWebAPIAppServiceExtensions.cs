using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace ContactsConsoleApplication
{
    public static class ContactWebAPIAppServiceExtensions
    {
        public static ContactWebAPI CreateContactWebAPI(this IAppServiceClient client)
        {
            return new ContactWebAPI(client.CreateHandler());
        }

        public static ContactWebAPI CreateContactWebAPI(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new ContactWebAPI(client.CreateHandler(handlers));
        }

        public static ContactWebAPI CreateContactWebAPI(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new ContactWebAPI(uri, client.CreateHandler(handlers));
        }

        public static ContactWebAPI CreateContactWebAPI(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new ContactWebAPI(rootHandler, client.CreateHandler(handlers));
        }
    }
}
