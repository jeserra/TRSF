using System;
using System.IO;
using System.Collections.Generic;

namespace sample27library 
{
    public class TradeProcessor2 
    {
        public void ProcessTrades(
            System.IO.Stream stream)
        {
            var lines = ReadTradeData(stream);
            var trades = ParseTrades(lines);    
          //  StoreTrades(trades);
        }


        /// <summary>
        /// Parseo de operaciones
        /// </summary>
        /// <param name="lines"> arreglo de strings para parsear</param>
        /// <returns></returns>
        public List<TradeRecord> ParseTrades(List<string> lines)
        {
            List<TradeRecord> trades = new List<TradeRecord>();
            if(ValidateData(lines))
                {
                    foreach(var fields in lines)
                    {
                         var sourceCurrencyCode = fields.Substring(0, 3);
                        var destinationCurrencyCode = fields.Substring(3, 3);

                        // calculate values
                        var trade = new TradeRecord
                        {
                            SourceCurrency = sourceCurrencyCode,
                            DestinationCurrency = destinationCurrencyCode,
                          //  Lots = tradeAmount / LotSize,
                         //  Price = tradePrice
                        };

                        trades.Add(trade);
                    }
                }
            return trades;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public virtual List<String> ReadTradeData(Stream stream)
        {
               var lines = new List<string>();
                using(var reader = new System.IO.StreamReader(stream))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                return lines;
        }

        public bool ValidateData(List<string> lines)
        {
            bool status = true;
             var lineCount = 1;
              foreach(var line in lines)
                {
                    var fields = line.Split(new char[] { ',' });

                    if(fields.Length != 3)
                    {
                        Console.WriteLine("WARN: Line {0} malformed. Only {1} field(s) found.", lineCount, fields.Length);
                        status = false;
                        continue;
                    }

                    if(fields[0].Length != 6)
                    {
                        Console.WriteLine("WARN: Trade currencies on line {0} malformed: '{1}'",  lineCount, fields[0]);
                        status = false;
                        continue;
                    }

                    int tradeAmount;
                    if(!int.TryParse(fields[1], out tradeAmount))
                    {
                        status = false;
                        Console.WriteLine("WARN: Trade amount on line {0} not a valid integer:  '{1}'", lineCount, fields[1]);
                    }

                    decimal tradePrice;
                    if (!decimal.TryParse(fields[2], out tradePrice))
                    {
                        status = false;
                        Console.WriteLine("WARN: Trade price on line {0} not a valid decimal:  '{1}'", lineCount, fields[2]);
                    }
                }

                return status;
    }


    }
}