using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace accountsReceivableRESTClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to setup the authorization for our system.  This will put a Base64 string in the "Authorization" header
            List<Model.NameValue> headers = new List<Model.NameValue>();
            headers.Add(new Model.NameValue {Name = "Authorization", Value = AuthorizationString,});


            // make a call to the /templates/getNewScreen to retrieve a blank AR screen template
            var myScreen = Helpers.JsonHelper.ExecuteREST<Model.PaymentEntryScreen>
                ("http://YourServer/ctDynamicsSLAPI/api/accountsReceivable/paymentEntry/templates/getNewScreen", 
                null, headers, HttpMethod.Post);

            // Set a few key fields
            myScreen.myARDoc.CustId = "C300";
            myScreen.myARDoc.BankAcct = "1070";
            myScreen.myARDoc.BankSub = "000000000000";

            myScreen.batchNote = new Model.Note { sNoteText = "This is a test batch note." };
            myScreen.documentNote = new Model.Note { sNoteText = "This is a test document note." };

            // Pass the template you just created to generate an AR Screen object (which will fill in all the defaults you didn't fill in)
            myScreen = Helpers.JsonHelper.ExecuteREST<Model.PaymentEntryScreen>
                ("http://YourServer/ctDynamicsSLAPI/api/accountsReceivable/paymentEntry/screen",
                myScreen, headers, HttpMethod.Post);


            // override some key fields in the returned object.  In this case, we are updating the CuryOrigDocAmt and the CuryCrTot 
            // to be the amount we are going to finally save
            myScreen.myARDoc.CuryOrigDocAmt = 13.04;
            myScreen.myBatch.CuryCrTot = myScreen.myARDoc.CuryOrigDocAmt;

            // Create your AR Transactions
            myScreen.myARTran = new List<Model.ARTran>();

            // minimum, to create an ARTran record, it needs to know the BatNbr and SiteID of the Batch and ARDoc.
            // ARTran.BatNbr = Batch.BatNbr
            // ARTran.SiteId = ARDoc.RefNbr
            Model.ARTran myARTran = new Model.ARTran
            {
                BatNbr = myScreen.myBatch.BatNbr,
                SiteId = myScreen.myARDoc.RefNbr,
            };

            // sending in the few fields, have the web services fill in all the defaults for you.
            myARTran = Helpers.JsonHelper.ExecuteREST<Model.ARTran>
                ("http://YourServer/ctDynamicsSLAPI/api/accountsReceivable/paymentEntry/templates/getNewARTran",
                myARTran, headers, HttpMethod.Post);

            // after we get the defaults back, lets update the ARTran and set the amount to what we want.  
            // NOTE:  the ARDoc.CuryOrigDocAmt and ARDoc.CuryCrTot should equal the sum of the ARTran.CuryTranAmt before you do the final save
            myARTran.CuryTranAmt = myScreen.myARDoc.CuryOrigDocAmt;
            myARTran.TranDesc = "Transaction Description";

            // add the ARTran object to the screen.myARTran array
            myScreen.myARTran.Add(myARTran);


            // now that we have the full screen object with it's child ARDoc, Batch, and ARTran, lets finally save it back to the web service
            try
            {
                myScreen = Helpers.JsonHelper.ExecuteREST<Model.PaymentEntryScreen>
                ("http://YourServer/ctDynamicsSLAPI/api/accountsReceivable/paymentEntry/screen",
                myScreen, headers, HttpMethod.Put);
            }
            catch(Exception ex)
            {
                // if there was an error, do any client based error handling
                Console.WriteLine("something terribly went wrong:\n" + ex.Message);
            }

            // this is the batch number of what you just saved.
            string batNbr = myScreen.myBatch.BatNbr;

        }

        /// <summary>
        /// APIKey used to identify your client
        /// </summary>
        private static string APIKey 
        { 
            get
            {
                // set your APIKey that was given to you by your ctAPI administrator
                return "[Your APIKey Here]";
            }
        }

        /// <summary>
        /// Secret Key given to you (needed along with the APIKey)
        /// </summary>
        private static string SecretKey
        {
            get
            {
                // set your SecretKey that was given to you by your ctAPI administrator
                return "[Your Secret Key Here]";
            }
        }

        /// <summary>
        /// Will return a comma Base 64 String representative of a comma delimited string containing your APIKey and SecretKey.  
        /// this is then used by the web service to authorize your client and know which resources you have access to
        /// </summary>
        private static string AuthorizationString
        {
            get
            {
                return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(APIKey + "," + SecretKey));
            }
        }
    }
}
