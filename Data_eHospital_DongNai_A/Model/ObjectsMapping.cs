namespace Data_eHospital_DongNai_A.Model
{
    public partial class ObjectsMapping : BaseModel
    {
        [Key]
        public int? ObjectsMapping_Id { get; set; }
public int? CreatedBy { get; set; }
public DateTime? CreatedDate { get; set; }
public int? Object1_Id { get; set; }
public int? Object2_Id { get; set; }
public string? TableName { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public ObjectsMapping()
        {
        }
    }
}

