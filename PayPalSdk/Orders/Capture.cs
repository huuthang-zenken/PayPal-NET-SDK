// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Capture.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data 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
// DO NOT EDIT

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PayPalSdk.Orders
{
    /// <summary>
    /// A captured payment.
    /// </summary>
    [DataContract]
    public class Capture
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Capture() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Money Amount;

        /// <summary>
        /// The details of the captured payment status.
        /// </summary>
        [DataMember(Name="status_details", EmitDefaultValue = false)]
        public CaptureStatusDetails CaptureStatusDetails;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        [DataMember(Name="disbursement_mode", EmitDefaultValue = false)]
        public string DisbursementMode;

        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
        /// </summary>
        [DataMember(Name="final_capture", EmitDefaultValue = false)]
        public bool? FinalCapture;

        /// <summary>
        /// The PayPal-generated ID for the captured payment.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name="invoice_id", EmitDefaultValue = false)]
        public string InvoiceId;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescription> Links;

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name="seller_protection", EmitDefaultValue = false)]
        public SellerProtection SellerProtection;

        /// <summary>
        /// The detailed breakdown of the captured payment.
        /// </summary>
        [DataMember(Name="seller_receivable_breakdown", EmitDefaultValue = false)]
        public MerchantReceivableBreakdown SellerReceivableBreakdown;

        /// <summary>
        /// The status of the captured payment.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}

