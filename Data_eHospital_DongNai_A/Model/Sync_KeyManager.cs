namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sync_KeyManager : BaseModel
    {
        [Key]
        public string? TableName { get; set; }
public int? StartValue { get; set; }
public int? CurrentValue { get; set; }
public DateTime? UpdatedDate { get; set; }

        public Sync_KeyManager()
        {
        }
    }
}

