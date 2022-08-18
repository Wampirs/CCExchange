using System.Collections.Generic;

namespace CCExchange.Models
{
    public class JsonArray<T>
    {
        public List<T> Data { get; set; }
        public long Timestamp { get; set; }
    }

    public class JsonObject<T>
    {
        public T Data { get; set; }
        public long Timestamp { get; set; }
    }
}
