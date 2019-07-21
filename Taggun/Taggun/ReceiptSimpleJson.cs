using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taggun
{
    public class TotalAmount
    {
        public int data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class TaxAmount
    {
        public int confidenceLevel { get; set; }
    }

    public class Date
    {
        public DateTime data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantName
    {
        public string data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantAddress
    {
        public string data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantCity
    {
        public string data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantState
    {
        public string data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantCountryCode
    {
        public string data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class MerchantTypes
    {
        public List<string> data { get; set; }
        public double confidenceLevel { get; set; }
    }

    public class ReceiptSimpleRootObject
    {
        public TotalAmount totalAmount { get; set; }
        public TaxAmount taxAmount { get; set; }
        public double confidenceLevel { get; set; }
        public Date date { get; set; }
        public MerchantName merchantName { get; set; }
        public MerchantAddress merchantAddress { get; set; }
        public MerchantCity merchantCity { get; set; }
        public MerchantState merchantState { get; set; }
        public MerchantCountryCode merchantCountryCode { get; set; }
        public MerchantTypes merchantTypes { get; set; }
    }

}
