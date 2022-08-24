using CCExchange.Models.Base;
using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace CCExchange.Models
{
    public class Exchange : Model
    {
        #region Private fields
        private string exchangeId;
        private string? name;
        private string? rank;
        private string? percentTotalVolume;
        private string? volumeUsd;
        private string? tradingPairs;
        private bool? socket;
        private string? exchangeUrl;
        private long? updated;
        #endregion

        [JsonPropertyName("exchangeId")]
        public string ExchangeId { get => exchangeId; set => exchangeId = value; }

        [JsonPropertyName("name")]
        public string? Name { get => name; set => name = value; }

        [JsonPropertyName("rank")]
        public string? Rank { get => rank; set => rank = value; }

        [JsonPropertyName("percentTotalVolume")]
        public string? PercentTotalVolume
        {
            get => percentTotalVolume;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                percentTotalVolume = ConvertBig(val);

            }
        }

        [JsonPropertyName("volumeUsd")]
        public string? VolumeUsd
        {
            get => volumeUsd;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                volumeUsd = ConvertBig(val);
            }
        }

        [JsonPropertyName("tradingPairs")]
        public string? TradingPairs { get => tradingPairs; set => tradingPairs = value; }

        [JsonPropertyName("socket")]
        public bool? Socket { get => socket; set => socket = value; }

        [JsonPropertyName("exchangeUrl")]
        public string? ExchangeUrl { get => exchangeUrl; set => exchangeUrl = value; }

        [JsonPropertyName("updated")]
        public long? Updated { get => updated; set => updated = value; }
    }
}
