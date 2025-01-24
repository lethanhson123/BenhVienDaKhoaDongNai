namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sync_TransactionData_KeyGeneration : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? SiteCode { get; set; }
public string? TableName { get; set; }
public DateTime? UpdatedDate { get; set; }

        public Sync_TransactionData_KeyGeneration()
        {
        }
    }
}

