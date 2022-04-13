using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class Status
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? StatusId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusName { get; set; }
    }
}
