// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// CapturesRefundRequest.cs
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
    /// Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an <code>amount</code> object in the JSON request body.
    /// </summary>
    public class CapturesRefundRequest : HttpRequest
    {
        public CapturesRefundRequest(string CaptureId) : base("/v2/payments/captures/{capture_id}/refund?", HttpMethod.Post, typeof(Refund))
        {
            try {
                this.Path = this.Path.Replace("{capture_id}", Uri.EscapeDataString(Convert.ToString(CaptureId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        public CapturesRefundRequest PayPalRequestId(string PayPalRequestId) 
        {
            this.Headers.Add("PayPal-Request-Id", PayPalRequestId);
            return this;
        }
        
        public CapturesRefundRequest Prefer(string Prefer) 
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }
        
        
        public CapturesRefundRequest RequestBody(RefundRequest RefundRequest)
        {
            this.Body = RefundRequest;
            return this;
        }
    }
}
