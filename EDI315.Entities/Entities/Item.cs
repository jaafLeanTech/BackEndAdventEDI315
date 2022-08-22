using Newtonsoft.Json;

namespace EDI315.Entities.Entities
{
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "container#")]
        public string ContainerNumber { get; set; }

        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "dimensions")]
        public string Dimensions { get; set; }

        [JsonProperty(PropertyName = "Book")]
        public bool Book { get; set; }
    }
}
