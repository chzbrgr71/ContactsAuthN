// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ContactsConsoleApplication;
using ContactsConsoleApplication.Models;
using Microsoft.Rest;

namespace ContactsConsoleApplication
{
    public static partial class ContactsExtensions
    {
        /// <param name='operations'>
        /// Reference to the ContactsConsoleApplication.IContacts.
        /// </param>
        public static IList<Contact> Get(this IContacts operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsConsoleApplication.IContacts.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Contact>> GetAsync(this IContacts operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ContactsConsoleApplication.Models.Contact>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsConsoleApplication.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        public static string PostByContact(this IContacts operations, Contact contact)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IContacts)s).PostByContactAsync(contact);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ContactsConsoleApplication.IContacts.
        /// </param>
        /// <param name='contact'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> PostByContactAsync(this IContacts operations, Contact contact, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.PostByContactWithOperationResponseAsync(contact, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
