using Microsoft.Azure.AppService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsWinForm
{
    public partial class frmContacts : Form
    {
        private const string GATEWAY_URL = "https://briarrg471d33fda776405b947c467c291dc741.azurewebsites.net/";
        private const string URL_TOKEN = "#token=";

        public frmContacts()
        {
            InitializeComponent();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            browser1.Navigate(string.Format(@"{0}login/twitter", GATEWAY_URL));
        }

        private void browser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.IndexOf(URL_TOKEN) > -1)
            {
                var encodedJson = e.Url.AbsoluteUri.Substring(e.Url.AbsoluteUri.IndexOf(URL_TOKEN) + URL_TOKEN.Length);
                var decodedJson = Uri.UnescapeDataString(encodedJson);
                var result = JsonConvert.DeserializeObject<dynamic>(decodedJson);
                string userId = result.user.userId;
                string userToken = result.authenticationToken;

                var appServiceClient = new AppServiceClient(GATEWAY_URL);
                appServiceClient.SetCurrentUser(userId, userToken);

                var contactsListClient = appServiceClient.CreateContactWebAPI();
                var contacts = contactsListClient.Contacts.Get();
                foreach (var c in contacts)
                {
                    txtContacts.Text += c.Name + " " + c.EmailAddress + System.Environment.NewLine;
                }
                
                //appServiceClient.Logout();
                //webBrowser1.Navigate(string.Format(@"{0}login/aad", GW_URL));
            }
        }
    }
}
