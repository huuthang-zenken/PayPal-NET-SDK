# REST API SDK for Dotnet V2

![Home Image](homepage.jpg)

__Welcome to PayPal Dotnet SDK__. This repository contains PayPal's Dotnet SDK for 
[v2/checkout/orders](https://developer.paypal.com/docs/api/orders/v2/) APIs, 
[v2/payments](https://developer.paypal.com/docs/api/payments/v2/) APIs, 
[v1/billing/subscriptions](https://developer.paypal.com/docs/api/subscriptions/v1/) APIs, 
[v1/notifications/webhooks](https://developer.paypal.com/docs/api/webhooks/v1/) APIs.

It includes a simplified interface to only provide simple model objects and blueprints for HTTP calls. This repo currently contains functionality for PayPal APIs which includes [Orders V2], [Payments V2], [Subscriptions V1], [Webhooks V1].

Also refer to [Setup your SDK](https://developer.paypal.com/docs/checkout/reference/server-integration/setup-sdk/) for additional information about setting up the SDK's.

## Prerequisites

.NET Core 1.0+

An environment which supports TLS 1.2 (see the TLS-update site for more information)

PayPalHttp 1.0.0

## Usage

### Setting up credentials
Get client ID and client secret by going to https://developer.paypal.com/developer/applications and generating a REST API app. Get <b>Client ID</b> and <b>Secret</b> from there.

```dotnet
using System;
using PayPalSdk.Core;
using PayPalSdk.Orders;
using PayPalHttp;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CaptureOrderSample
{
    static String clientId = "PAYPAL-CLIENT-ID";
    static String secret = "PAYPAL-CLIENT-SECRET";

    public static HttpClient client()
    {
        // Creating a sandbox environment
        PayPalEnvironment environment = new SandboxEnvironment(clientId, secret);

        // Creating a client for the environment
        PayPalHttpClient client = new PayPalHttpClient(environment);
        return client;
    }
}
```

## Examples
### Creating an Order
This will create an order and print order id for the created order

```dotnet
public async static Task<HttpResponse> CreateOrder()
 {
         HttpResponse response;
        // Construct a request object and set desired parameters
        // Here, OrdersCreateRequest() creates a POST request to /v2/checkout/orders
        var order = new OrderRequest() {
                Intent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        Amount = new AmountWithBreakdown()
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                },
                ApplicationContext = new ApplicationContext()
                {
                    ReturnUrl = "https://www.example.com",
                    CancelUrl = "https://www.example.com"
                }
            };


            // Call API with your client and get a response for your call
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(order);
            response = await client().Execute(request);
            var statusCode = response.StatusCode;
            Order result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Order Id: {0}", result.Id);
            Console.WriteLine("Intent: {0}", result.Intent);
            Console.WriteLine("Links:");
            foreach (LinkDescription link in result.Links)
            {
                 Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            }
            return response;
    }
```

### Capturing an Order
Before capturing an order, order should be approved by the buyer using the approve link in create order response
```dotnet
  public async static Task<HttpResponse> CaptureOrder()
    {
            // Construct a request object and set desired parameters
            // Replace ORDER-ID with the approved order id from create order
            var request = new OrdersCaptureRequest("APPROVED-ORDER-ID");
            request.RequestBody(new OrderActionRequest());
            HttpResponse response = await client().Execute(request);
            var statusCode = response.StatusCode;
            Order result = response.Result<Order>();
            Console.WriteLine("Status: {0}", result.Status);
            Console.WriteLine("Capture Id: {0}", result.Id);
            return response;
    }

```

## License
Code released under [SDK LICENSE](LICENSE)  
