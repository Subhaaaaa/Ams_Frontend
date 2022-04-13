using System.Text.Json.Serialization;

namespace AMS_API.Models
{
    public class Asset
    {
        public int? AssetId { get; set; }
        public AssetType AssetType { get; set; }
        public string SerialNo { get; set; }
        public AssetCategory AssetCategory { get; set; }
        public Brand Brand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public Boolean IsWorking { get; set; }
        public Boolean IsWired { get; set; } 
        public DateTime CreatedOn { get; set; }

        

        public Asset()
        {
            AssetType = new AssetType();
            Brand = new Brand();
            AssetCategory = new AssetCategory();
        }
    }
}
