using CCExchange.Models.Base;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace CCExchange.Models
{
    public class Currency : Model
    {
        #region Private fields
        private string? id;
        private string? rank;
        private string? symbol;
        private string? name;
        private string? supply;
        private string? maxSupply;
        private string? marketCapUsd;
        private string? volumeUsd24Hr;
        private string? priceUsd;
        private string? changePercent24Hr;
        private string? vwap24Hr;
        #endregion

        [JsonProperty("id")]
        public string? Id { get => id; set => id = value; }

        [JsonProperty("rank")]
        public string? Rank { get => rank; set => rank = value; }

        [JsonProperty("symbol")]
        public string? Symbol { get => symbol; set => symbol = value; }

        [JsonProperty("name")]
        public string? Name { get => name; set => name = value; }

        [JsonProperty("supply")]
        public string? Supply
        {
            get => supply;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                supply = ConvertBig(val);
            }
        }

        [JsonProperty("maxSupply")]
        public string? MaxSupply
        {
            get => maxSupply;
            set
            {
                if (value == null)
                {
                    maxSupply = "UNLIM";
                    return;
                }
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                maxSupply = ConvertBig(val);
            }
        }

        [JsonProperty("marketCapUsd")]
        public string? MarketCapUsd
        {
            get => marketCapUsd;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                marketCapUsd = ConvertBig(val);
            }
        }

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

        [JsonProperty("changePercent24Hr")]
        public string? ChangePercent24Hr
        {
            get => changePercent24Hr;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                val = Math.Round(val, 2);
                changePercent24Hr = val.ToString();
            }
        }

        [JsonProperty("vwap24Hr")]
        public string? Vwap24Hr
        {
            get => vwap24Hr;
            set
            {
                decimal val;
                Decimal.TryParse(value, NumberStyles.Currency, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out val);
                val = Math.Round(val, 2);
                vwap24Hr = val.ToString();
            }
        }

    }
}
