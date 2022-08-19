using Newtonsoft.Json;
using System.Globalization;
using System;
using CCExchange.Models.Base;

namespace CCExchange.Models
{
    public class Market : Model
    {
        private string? priceUsd;
        private string? exchangeId;
        private string? baseId;
        private string? quoteId;
        private string? baseSymbol;
        private string? quoteSymbol;
        private string? volumeUsd24Hr;
        private string? volumePercent;

        [JsonProperty("exchangeId")]
        public string? ExchangeId { get => exchangeId; set => exchangeId = value; }

        [JsonProperty("baseId")]
        public string? BaseId { get => baseId; set => baseId = value; }

        [JsonProperty("quoteId")]
        public string? QuoteId { get => quoteId; set => quoteId = value; }

        [JsonProperty("baseSymbol")]
        public string? BaseSymbol { get => baseSymbol; set => baseSymbol = value; }

        [JsonProperty("quoteSymbol")]
        public string? QuoteSymbol { get => quoteSymbol; set => quoteSymbol = value; }

        [JsonProperty("volumeUsd24Hr")]
        public string? VolumeUsd24Hr
        {
            get => volumeUsd24Hr;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                volumeUsd24Hr = ConvertBig(val);
            }
        }

        [JsonProperty("priceUsd")]
        public string? PriceUsd
        {
            get => priceUsd;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                val = Math.Round(val, 2);
                priceUsd = val.ToString();
            }
        }

        [JsonProperty("volumePercent")]
        public string? VolumePercent { get => volumePercent; set => volumePercent = value; }
    }
}
