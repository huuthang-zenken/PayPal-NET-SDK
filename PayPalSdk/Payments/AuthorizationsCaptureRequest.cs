// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// AuthorizationsCaptureRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data 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
// DO NOT EDIT

using System;
using System.IO;
using System.Net.Http;

using PayPalHttp;

namespace PayPalSdk.Payments
{
    /// <summary>
    /// Captures an authorized payment, by ID.
    /// </summary>
    public class AuthorizationsCaptureRequest : HttpRequest
    {
        public AuthorizationsCaptureRequest(string AuthorizationId) : base("/v2/payments/authorizations/{authorization_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        public AuthorizationsCaptureRequest PayPalRequestId(string PayPalRequestId) 
        {
            this.Headers.Add("PayPal-Request-Id", PayPalRequestId);
            return this;
        }
        
        public AuthorizationsCaptureRequest Prefer(string Prefer) 
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }
        
        
        public AuthorizationsCaptureRequest RequestBody(CaptureRequest Capture)
        {
            this.Body = Capture;
            return this;
        }
    }
}
