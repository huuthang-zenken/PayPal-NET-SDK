// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// MerchantBase.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/7xUwW4TMRC98xWjPYEUpVVLOeQEVQ9UiFKhwAVQNbHfZq167e3YTrqg/juynbZJIwQSiEskP2d25r15zz+a+TigmTXvIapjF+mUA5pJ85nF8MLigvt83UyadxgfD2cISswQjXfNrJl3II3IxgZqvVDsQP39B9edJ4GCWSGUmzY5HYidpjbZ1lhbYS8aMqX5dq0JxDZ4unZ+7YjrHwcegWkzad6I8FjnP5w0H8H6g7NjM2vZBmTgJhmBfgAuxQ+QaBCa2ZcH5iGKcct9ysoauHhl9A73bXRfhCEtrFFkNFw0rYEUOXgYSAk4QtNi3FHnoJKhcxfF66SgKXoKaRi8REoBpDgg0PP8HUyXUzoVNm4uABkXsRTO7WltYkeXPF6yfUHrDrKRidCzsVestSAE8vLQ+croLK/zkXjFxmbmfyuqS9beTX6r7M5MO+o+vdlXOJMWV0izNd+hK0Pa1Ey/psPDY7WwXl3fJB9RzvVXhSjeLSty4SNmFT7YxunTkDfw6iWpjoVVhARiAbG1fp0XiNbno9N0dHLyq39xG1FzUHsorzejvN40fUQomKWb0lu/xgoyKVVLOAhbOxIrhSE7p+db06eeLNwydtVYbpd9XujRyfboNU8Dx6warSDZlTlGHHN1ckUk/adTEm5NiPcqHzyV+f/YZ8vBO+bZxfetU+NRciF0fjahdWdUV94Y6jlcQ2eBQo6Tb8sWNhWslE8ukkv9AlIs6DR0WUGOaAlf7IxoGrhwqbI/rQskKB0WdiQ4JWNZbLYS0yB+EIPIMtIqE3Yxj5Gf4+OjXJtCfRzg8lLKfIKQbPwnqf129+wnAAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;

namespace PayPalSdk.Payments
{
    /// <summary>
    /// The details for the merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [DataContract]
    public class MerchantBase
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public MerchantBase() {}

        /// <summary>
        /// The public identifier for app created by the merchant/payee. Introduced to support use cases (for e.g. BrainTree integration with PayPal) where payee email_address or merchant_id is not available.
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue = false)]
        public string ClientId;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId;
    }
}

