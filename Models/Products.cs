namespace ProductSerializer
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Product {
        public Product(String id, string name, string description, DateTimeOffset addedAt, string supplier, string barcode) {
            this.Id = Convert.ToInt64(id);
            this.Name = name;
            this.Description = description;
            this.AddedAt = addedAt;
            this.Supplier = supplier;
            this.Barcode = barcode;
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("addedAt")]
        public DateTimeOffset AddedAt { get; set; }

        [JsonProperty("supplyer")]
        public string Supplier { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public partial class Product {
        public static Product[] FromJsonArray(string json) => JsonConvert.DeserializeObject<Product[]>(json, Converter.Settings);
        public static Product FromJson(string json) => JsonConvert.DeserializeObject<Product>(json, Converter.Settings);
    }

    public static class Serialize {
        public static string ToJson(Product self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}