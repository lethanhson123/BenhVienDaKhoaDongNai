namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_DM_Duoc_SQD : BaseModel
    {
        [Key]
        public int? Duoc_id { get; set; }
public string? MaDuoc { get; set; }
public string? SQD { get; set; }

        public zzz_DM_Duoc_SQD()
        {
        }
    }
}

