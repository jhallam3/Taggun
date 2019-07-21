using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taggun.verbose
{
    public class Names
    {
        public string de { get; set; }
        public string en { get; set; }
        public string ja { get; set; }
        public string ru { get; set; }
       
}

public class City
{
    public int geoname_id { get; set; }
    public Names names { get; set; }
}

public class Names2
{
    public string de { get; set; }
    public string en { get; set; }
    public string es { get; set; }
    public string fr { get; set; }
    public string ja { get; set; }
   
    public string ru { get; set; }

}

public class Continent
{
    public string code { get; set; }
    public int geoname_id { get; set; }
    public Names2 names { get; set; }
}

public class Names3
{
    public string de { get; set; }
    public string en { get; set; }
    public string es { get; set; }
    public string fr { get; set; }
    public string ja { get; set; }
    
    public string ru { get; set; }

}

public class Country
{
    public int geoname_id { get; set; }
    public bool is_in_european_union { get; set; }
    public string iso_code { get; set; }
    public Names3 names { get; set; }
}

public class Location2
{
    public int accuracy_radius { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string time_zone { get; set; }
}

public class Postal
{
    public string code { get; set; }
}

public class Names4
{
    public string de { get; set; }
    public string en { get; set; }
    public string es { get; set; }
    public string fr { get; set; }
    public string ja { get; set; }
    
    public string ru { get; set; }

}

public class RegisteredCountry
{
    public int geoname_id { get; set; }
    public bool is_in_european_union { get; set; }
    public string iso_code { get; set; }
    public Names4 names { get; set; }
}

public class Names5
{
    public string de { get; set; }
    public string en { get; set; }
    public string es { get; set; }
    public string fr { get; set; }
    public string ja { get; set; }
    
    public string ru { get; set; }

}

public class Subdivision
{
    public int geoname_id { get; set; }
    public string iso_code { get; set; }
    public Names5 names { get; set; }
}

public class Location
{
    public City city { get; set; }
    public Continent continent { get; set; }
    public Country country { get; set; }
    public Location2 location { get; set; }
    public Postal postal { get; set; }
    public RegisteredCountry registered_country { get; set; }
    public List<Subdivision> subdivisions { get; set; }
}

public class TotalAmount
{
    public double confidenceLevel { get; set; }
    public int index { get; set; }
    public int data { get; set; }
    public string text { get; set; }
    public List<Object> regions { get; set; }
    public string currencyCode { get; set; }
    public string keyword { get; set; }
}

public class TaxAmount
{
    public int confidenceLevel { get; set; }
}

public class Date
{
    public DateTime data { get; set; }
    public string text { get; set; }
    public List<Object> regions { get; set; }
    public int index { get; set; }
    public double confidenceLevel { get; set; }
}

public class Region
{
    public int x { get; set; }
    public int y { get; set; }
}

public class Text
{
    public string text { get; set; }
    public List<Region> regions { get; set; }
}

public class Amount
{
    public int data { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
    public string text { get; set; }
    public string currencyCode { get; set; }
}

public class Number
{
    public int data { get; set; }
    public string text { get; set; }
    public List<Object> regions { get; set; }
    public int index { get; set; }
    public string classifyResult { get; set; }
}

public class Entities
{
}

public class MerchantName
{
    public string data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class MerchantAddress
{
    public string data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class MerchantCity
{
    public string data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class MerchantState
{
    public string data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class MerchantCountryCode
{
    public string data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class MerchantTypes
{
    public List<string> data { get; set; }
    public double confidenceLevel { get; set; }
    public string text { get; set; }
    public int index { get; set; }
    public List<Object> regions { get; set; }
}

public class ReceiptVerboseRootObject
{
    public Location location { get; set; }
    public TotalAmount totalAmount { get; set; }
    public TaxAmount taxAmount { get; set; }
    public double confidenceLevel { get; set; }
    public Date date { get; set; }
    public Text text { get; set; }
    public List<Amount> amounts { get; set; }
    public List<Number> numbers { get; set; }
    public List<object> lineAmounts { get; set; }
    public Entities entities { get; set; }
    public MerchantName merchantName { get; set; }
    public MerchantAddress merchantAddress { get; set; }
    public MerchantCity merchantCity { get; set; }
    public MerchantState merchantState { get; set; }
    public MerchantCountryCode merchantCountryCode { get; set; }
    public MerchantTypes merchantTypes { get; set; }
    public double elapsed { get; set; }
}

}
