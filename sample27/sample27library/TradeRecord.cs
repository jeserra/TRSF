using System;

namespace sample27library 
{
    public class TradeRecord 
    {
        public string  SourceCurrency{get;set;}
        public string DestinationCurrency{get;set;}
        public float Lots{get;set;}
        /// <summary>
        /// Precio
        /// </summary>
        /// <value></value>
        public Decimal Price {get;set;}
    }
}