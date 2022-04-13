using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class AssetCategory
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AssetCategoryId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AssetCategoryName { get; set; }
        
    }
}
