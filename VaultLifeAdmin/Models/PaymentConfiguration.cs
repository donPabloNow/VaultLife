//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VaultLifeAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentConfiguration
    {
        public int PaymentConfigurationID { get; set; }
        public string PaymentGatewayURL { get; set; }
        public string MerchantPassword { get; set; }
        public string TerminalID { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string CO_ID { get; set; }
        public string OUTLET { get; set; }
        public string MERCHANT_SECRET_KEY { get; set; }
    }
}
