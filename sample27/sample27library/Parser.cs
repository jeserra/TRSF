﻿using System;

namespace sample27library
{
    public class Parser
    {
        public TradeRecord ParseSource (string Source)
        {
            var listStrings  = Source.Split(',');
            var transaccion = new TradeRecord();
            transaccion.id = int.Parse( listStrings[0]);
            transaccion.Operation = listStrings[1];
            transaccion.Amount = decimal.Parse(listStrings[2]);
            transaccion.date = DateTime.Parse(listStrings[3]);
            return transaccion;
        }
    }
}
