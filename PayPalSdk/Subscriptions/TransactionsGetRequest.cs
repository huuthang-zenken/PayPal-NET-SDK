using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Subscriptions
{
    public class TransactionsGetRequest : HttpRequest
    {
        public TransactionsGetRequest(string startTime, string endTime) : base("/v1/billing/subscriptions/{id}/transactions?start_time={start_time}&end_time={end_time}", HttpMethod.Get, typeof(TransactionCollection))
        {
            try
            {
                this.Path = this.Path.Replace("{startTime}", Uri.EscapeDataString(Convert.ToString(startTime)));
                this.Path = this.Path.Replace("{endTime}", Uri.EscapeDataString(Convert.ToString(endTime)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
    }
}
