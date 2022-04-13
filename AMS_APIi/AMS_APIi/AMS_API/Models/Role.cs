using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class Role
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RoleId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RoleName { get; set; }
    }
}
