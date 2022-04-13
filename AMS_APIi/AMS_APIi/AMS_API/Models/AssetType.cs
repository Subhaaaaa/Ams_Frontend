using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class AssetType
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? AssetTypeId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AssetTypeName { get; set; }

        public AssetCategory AssetCategory { get; set; }

        public AssetType()
        {
            AssetCategory = new AssetCategory();
        }

    }
}
