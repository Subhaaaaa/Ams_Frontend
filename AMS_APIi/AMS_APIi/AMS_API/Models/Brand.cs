using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class Brand
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BrandId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BrandName { get; set; }
    }
}
