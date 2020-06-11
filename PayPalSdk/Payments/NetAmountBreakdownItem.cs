// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// NetAmountBreakdownItem.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+xW22okNxB9z1cU/ZRA2+3NhcC8OXuBTYjXOCYQHOOtkapHYtXSbKnkSRP234P6MrfukNj4JVk/NVKVqnQOR6frz+K6XVOxKC5I4LwJyQv8wIQfdNh4eCvUFGXxK7LFpaMLbHJqURY/UbtbvKKo2K7FBl8simtD4EkAu2KncEWS2JOGjSEPYghUYiavWgh1t2aqk9dgI2hb18TkBWoOzWzyJbaX6ACV6u66McTUBRpiZdALmOB0zFuWIReOp0VZnDNj20M9K4srQv3Ou7ZY1Ogi5Y2PyTLp7cYlhzWxWIrF4mZL0s/BUzslRAV/Tyyk73rQBwTNBKeEbVGi1wNzUAcGhNp69MqiA2H0EVU+VUJMygBGQFiiQ68IAsMa2yaTpxM9HeYobP1qBvRw5TsVNB0iPopM4d6IYaITZZBRCTG8/eXdybdfv/h+R0Q+e/tlpYOKlfVCK8ZcoNKWSUnFFKUak09ycqy+AjEoYDV5sbWleCCgBzEinI4I8cm5T+U/snKPLh2yMe5MWegiJWyMVQYauzICS1r8ns7OvlHJdV/qV872q3MPHRfEnToGaBmpsx8I3v94+dv7ngRkAh8EpF1bhc61UHOvHXSnfdFqrHrUAzQp26DbnpjvdX3xaq9XTEtt760mnW8YQExIEb0WE+fbVSPCN4EHF+jJB5+aJXF+7+NF1g4VxeFBHCikhEgENy/HvZdZCA+VzVMo43ZPG6//yEa0IrhCoalEaAjfcR/eSeU4MpXMmAE5o2dfkxA31g9yH8xDAgzG01tp8HsmIwHQBzHEj3sdj/KLGBIruhsbHgCfxv6DnjHDyr80DUFekcxTM419VtQ8xE97qvb+pcME8vpjsvfoqH8W+SUkb2UcKHrt7XDBm8ANipDO/9fRbgNv3ai7AGysmK6WBHjxHWi7shKhcz4C7sx8aLB1sWC9PAlt+2bzNyPJGtu8mhtIJqHnceR5HHkeR/5n48jtpy/+AgAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;

namespace PayPalSdk.Payments
{
    /// <summary>
    /// The net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the merchant holds their funds.
    /// </summary>
    [DataContract]
    public class NetAmountBreakdownItem
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public NetAmountBreakdownItem() {}

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="converted_amount", EmitDefaultValue = false)]
        public Money ConvertedAmount;

        /// <summary>
        /// The exchange rate that determines the amount to convert from one currency to another currency.
        /// </summary>
        [DataMember(Name="exchange_rate", EmitDefaultValue = false)]
        public ExchangeRate ExchangeRate;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name="payable_amount", EmitDefaultValue = false)]
        public Money PayableAmount;
    }
}

