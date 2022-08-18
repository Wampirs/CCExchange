using System.Collections.Generic;

namespace CCExchange.Models
{
    public class RootJson
    {
        public List<Currency> Data { get; set; }
        public long Timestamp { get; set; }
    }
}
