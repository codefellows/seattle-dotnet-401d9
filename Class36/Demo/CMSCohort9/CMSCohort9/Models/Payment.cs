using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using CMSCohort9.Models.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CMSCohort9.Models
{
    public class Payment : IPayment
    {
        private IConfiguration _configuration;

        public Payment(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Potential params: Order itself (order Object)
        /// </summary>
        public void Run(double total)
        {
            // sets the environment that we will be running
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            // define the merchant information 

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = _configuration["AuthorizeNetLoginID"],
                ItemElementName = ItemChoiceType.transactionKey,
                Item = _configuration["AuthorizeNetTransactionKey"]
            };

            // we can either hardcode the CC number or bring it into the method through the order. 
            // we likely want to capture the CC number info on the checkout process and save it in our orders table. 

            var creditCard = new creditCardType
            {
                cardNumber = "4111111111111111",
                expirationDate = "1219"
            };

            // Get billing address from the order
            customerAddressType billingAddress = GetAddress("order.BillingAddress");

            var paymentType = new paymentType { Item = creditCard };

            // could optionally get line items in here. 

            var transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = (decimal)total,
                payment = paymentType,
                billTo = billingAddress               
            };


            var request = new createTransactionRequest { transactionRequest = transactionRequest };

            var controller = new createTransactionController(request);
            controller.Execute();

            var response = controller.GetApiResponse();

            if(response != null)
            {
                if(response.messages.resultCode == messageTypeEnum.Ok)
                {
                    // return "approved!" 
                }
                else
                {
                    // return "Not approved"
                    if(response.transactionResponse.errors != null)
                    {
                       // log response.transactionResponse.errors[0].errorCode 
                    }
                }
            }

        }

        private customerAddressType GetAddress(string billing)
        {
            customerAddressType address = new customerAddressType
            {
                firstName = "Josie",
                lastName = "Cat",
                address = "123 Catnip Lane",
                city = "meowsville",
                zip = "12345"
            };

            return address;
        }
    }
}
