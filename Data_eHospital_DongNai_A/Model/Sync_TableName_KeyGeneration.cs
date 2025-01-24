namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sync_TableName_KeyGeneration : BaseModel
    {
        [Key]
        public string? TableName { get; set; }
public bool? KeyManage { get; set; }
public bool? CodeManage { get; set; }

        public Sync_TableName_KeyGeneration()
        {
        }
    }
}

