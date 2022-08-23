using CCExchange.Models.Base;
using System.Text.Json.Serialization;

namespace CCExchange.Models
{
    public class Exchange : Model
    {
        [JsonPropertyName("exchangeId")]
        public string ExchangeId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rank")]
        public string? Rank { get; set; }

        [JsonPropertyName("percentTotalVolume")]
        public string? PercentTotalVolume { get; set; }

        [JsonPropertyName("volumeUsd")]
        public string? VolumeUsd { get; set; }

        [JsonPropertyName("tradingPairs")]
        public string? TradingPairs { get; set; }

        [JsonPropertyName("socket")]
        public bool? Socket { get; set; }

        [JsonPropertyName("exchangeUrl")]
        public string? ExchangeUrl { get; set; }

        [JsonPropertyName("updated")]
        public long? Updated { get; set; }
    }
}
