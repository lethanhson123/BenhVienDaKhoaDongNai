namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sync_KeyOffline : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public bool? IsUpdate { get; set; }
public string? TableName { get; set; }
public DateTime? UpdatedDate { get; set; }

        public Sync_KeyOffline()
        {
        }
    }
}

